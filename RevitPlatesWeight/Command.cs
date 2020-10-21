#region License
/*Данный код опубликован под лицензией Creative Commons Attribution-ShareAlike.
Разрешено использовать, распространять, изменять и брать данный код за основу для производных в коммерческих и
некоммерческих целях, при условии указания авторства и если производные лицензируются на тех же условиях.
Код поставляется "как есть". Автор не несет ответственности за возможные последствия использования.
Зуев Александр, 2020, все права защищены.
This code is listed under the Creative Commons Attribution-ShareAlike license.
You may use, redistribute, remix, tweak, and build upon this work non-commercially and commercially,
as long as you credit the author by linking back and license your new creations under the same terms.
This code is provided 'as is'. Author disclaims any implied warranty.
Zuev Aleksandr, 2020, all rigths reserved.

More about solution / Подробнее: http://weandrevit.ru/plagin-massa-plastin-km/
 */
#endregion
#region Using
using System;
using System.Collections.Generic;
using System.Linq;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

using RVTDocument = Autodesk.Revit.DB.Document;
using ASDocument = Autodesk.AdvanceSteel.DocumentManagement.Document;
using RVTransaction = Autodesk.Revit.DB.Transaction;

#if R2021
using FabricationTransaction = Autodesk.SteelConnectionsDB.FabricationTransaction;
#else
using FabricationTransaction = RvtDwgAddon.FabricationTransaction;
#endif

using Autodesk.Revit.DB.Steel;
using Autodesk.Revit.DB.Structure;
using Autodesk.AdvanceSteel.DocumentManagement;
using Autodesk.AdvanceSteel.Geometry;
using Autodesk.AdvanceSteel.Modelling;
using Autodesk.AdvanceSteel.CADAccess;
using System.Security.Cryptography.X509Certificates;
#endregion

namespace RevitPlatesWeight
{
    public enum DimensionKind { Length, Width, Thickness }
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class Command : IExternalCommand
    {
        public const string GroupConstParamName = "КМ.ГруппаКонструкций";
        public const string ElementTypeParamName = "КМ.ТипЭлемента";
        public const string PlateNameParamName = "Мрк.НаименованиеСоставноеПрефикс";
        public const string WeightParamName = "О_Масса";
        public const string MaterialNameParam = "О_Материал";
        public const string VolumeParamName = "О_Объем";
        public const string ProfileNameParamName = "Орг.НаименованиеПрофиля";
        public const string ElementWeightTypeParamName = "Орг.СпособПодсчетаМассы";

        public const string ThicknessParamName = "Рзм.Толщина";
        public const string PlateLengthParamName = "Рзм.Длина";
        public const string PlateWidthParamName = "Рзм.Ширина";
        public const string LengthCorrectedParamName = "Рзм.КорректировкаДлины";

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            


            Settings sets = Settings.Activate();

            int platesCount = 0;

            RVTDocument doc = commandData.Application.ActiveUIDocument.Document;

            View calculateView = doc.ActiveView;
            if (!(calculateView is View3D) || calculateView.DetailLevel != ViewDetailLevel.Fine)
            {
                TaskDialog.Show("Ошибка", "Перед запуском плагина перейдите на 3D вид с включенным Высоким уровнем детализации");
                return Result.Failed;
            }

            List<BuiltInCategory> constrCats = new List<BuiltInCategory> {
                BuiltInCategory.OST_StructuralFraming,
                BuiltInCategory.OST_StructuralColumns,
            };
            List<Element> constrs = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .WherePasses(new ElementMulticategoryFilter(constrCats))
                .ToElements()
                .ToList();

            List<SteelProxyElement> PlatesFree = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .OfClass(typeof(SteelProxyElement))
                .Cast<SteelProxyElement>()
                .Where(i => i.GeomType == GeomObjectType.Plate)
                .ToList();

            List<StructuralConnectionHandler> joints = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .OfClass(typeof(StructuralConnectionHandler))
                .Cast<StructuralConnectionHandler>()
                .ToList();

            List<PlateInJoint> PlatesInJoint = new List<PlateInJoint>();

            using (FabricationTransaction t = new FabricationTransaction(doc, true, "Test plates"))
            {
                foreach (StructuralConnectionHandler joint in joints)
                {
                    List<Subelement> subelems = joint.GetSubelements().ToList();
                    foreach (Subelement subelem in subelems)
                    {
                        if (subelem.Category.Id != new ElementId(BuiltInCategory.OST_StructConnectionPlates)) continue;
                        PlateInJoint pij = new PlateInJoint();
                        pij.subelem = subelem;

                        Reference rf = subelem.GetReference();
                        FilerObject filerObj = AdvanceSteelUtils.GetFilerObject(doc, rf);
                        Plate pl = filerObj as Plate;
                        double vol = pl.Volume / (1000000 * 29.504);

                        pij.volume = vol;

                        PlatesInJoint.Add(pij);
                    }
                }
            }

            using (RVTransaction t = new RVTransaction(doc))
            {
                t.Start("КМ параметризация");

                foreach (Element elem in constrs)
                {
                    Parameter lengthParam = null;
                    if (elem.Category.Id == new ElementId(BuiltInCategory.OST_StructuralColumns))
                    {
                        lengthParam = elem.get_Parameter(BuiltInParameter.STEEL_ELEM_CUT_LENGTH);
                    }
                    else if (elem.Category.Id == new ElementId(BuiltInCategory.OST_StructuralFraming))
                    {
                        lengthParam = elem.get_Parameter(BuiltInParameter.STRUCTURAL_FRAME_CUT_LENGTH);
                    }
                    if (lengthParam == null) continue;
                    if (!lengthParam.HasValue) continue;
                    double cutLength = lengthParam.AsDouble();

                    Parameter trueLengthParam = elem.LookupParameter("Рзм.ДлинаБалкиИстинная");
                    if (trueLengthParam == null) continue;
                    if (!trueLengthParam.HasValue) continue;
                    double trueLength = trueLengthParam.AsDouble();

                    double delta = cutLength - trueLength;

                    Parameter deltaParam = elem.LookupParameter("Рзм.КорректировкаДлины");
                    if (deltaParam == null) continue;
                    if (deltaParam.IsReadOnly) continue;

                    deltaParam.Set(delta);
                }

                foreach (SteelProxyElement plate in PlatesFree)
                {
                    Options opt = new Options() { View = calculateView };
                    GeometryElement geoElem = plate.get_Geometry(opt);
                    GeometryInstance geoIns = geoElem.First() as GeometryInstance;
                    GeometryElement geosol = geoIns.GetInstanceGeometry();

                    Solid sol = geosol.First() as Solid;

                    ElementId mid = plate.get_Parameter(BuiltInParameter.STRUCTURAL_MATERIAL_PARAM).AsElementId();
                    double density = MaterialUtils.GetMaterialDensity(doc, mid);

                    double vol = sol.Volume;

                    double mass = vol * density;

                    double thickness = GetDimension<SteelProxyElement>(plate, DimensionKind.Thickness);

                    string thicknessName = "";
                    if (sets.writeThickName)
                    {
                        thicknessName = "-" + (thickness * 304.8).ToString("F0");
                    }

                    WriteParameter(plate, GroupConstParamName, sets.GroupConstParamValue, sets.Rewrite);
                    WriteParameter(plate, ElementTypeParamName, sets.ElementTypeParamValue, sets.Rewrite);
                    WriteParameter(plate, PlateNameParamName, thicknessName, true);
                    WriteParameter(plate, WeightParamName, mass, true);
                    WriteParameter(plate, MaterialNameParam, mid, true);
                    WriteParameter(plate, VolumeParamName, vol, true);
                    WriteParameter(plate, ProfileNameParamName, sets.ProfileNameValue, sets.Rewrite);
                    WriteParameter(plate, ElementWeightTypeParamName, sets.ElementWeightTypeValue, sets.Rewrite);

                    if (sets.writeThickvalue)
                    {
                        WriteParameter(plate, ThicknessParamName, thickness, true);
                    }
                    if (sets.writePlatesLengthWidth)
                    {
                        double plateLength = GetDimension<SteelProxyElement>(plate, DimensionKind.Length);
                        WriteParameter(plate, PlateLengthParamName, plateLength, true);
                        
                        double plateWidth = GetDimension<SteelProxyElement>(plate, DimensionKind.Width);
                        WriteParameter(plate, PlateWidthParamName, plateWidth, true);
                    }

                    platesCount++;
                }

                foreach (PlateInJoint pij in PlatesInJoint)
                {
                    Subelement subelem = pij.subelem;
                    ParameterValue pv = subelem.GetParameterValue(new ElementId(BuiltInParameter.STRUCTURAL_MATERIAL_PARAM));
                    ElementIdParameterValue idpv = pv as ElementIdParameterValue;
                    ElementId mid = idpv.Value;
                    double density = MaterialUtils.GetMaterialDensity(doc, mid);

                    double mass = pij.volume * density;

                    double thickness = GetDimension<Subelement>(subelem, DimensionKind.Thickness);

                    string thicknessName = "";
                    if (sets.writeThickName)
                    {
                        thicknessName = "-" + (thickness * 304.8).ToString("F0");
                    }

                    double plateLength = 0;
                    double plateWidth = 0;

                    if (sets.writePlatesLengthWidth)
                    {
                        plateLength = GetDimension<Subelement>(subelem, DimensionKind.Length);
                        plateWidth = GetDimension<Subelement>(subelem, DimensionKind.Width);
                    }


                    List<ElementId> paramIds = subelem.GetAllParameters().ToList();
                    foreach (ElementId paramId in paramIds)
                    {
                        Element param = doc.GetElement(paramId);

                        if (param == null) continue;

                        else if (param.Name == GroupConstParamName)
                            subelem.SetParameterValue(paramId, new IntegerParameterValue(sets.GroupConstParamValue));

                        else if (param.Name == ElementTypeParamName)
                            subelem.SetParameterValue(paramId, new IntegerParameterValue(sets.ElementTypeParamValue));

                        else if (param.Name == PlateNameParamName && sets.writeThickvalue)
                            subelem.SetParameterValue(paramId, new StringParameterValue(thicknessName));

                        else if (param.Name == WeightParamName)
                            subelem.SetParameterValue(paramId, new DoubleParameterValue(mass));

                        else if (param.Name == MaterialNameParam)
                            subelem.SetParameterValue(paramId, new ElementIdParameterValue(mid));

                        else if (param.Name == VolumeParamName)
                            subelem.SetParameterValue(paramId, new DoubleParameterValue(pij.volume));

                        else if (param.Name == ProfileNameParamName)
                            subelem.SetParameterValue(paramId, new StringParameterValue(sets.ProfileNameValue));

                        else if (param.Name == ElementWeightTypeParamName)
                            subelem.SetParameterValue(paramId, new IntegerParameterValue(sets.ElementWeightTypeValue));

                        else if (param.Name == ThicknessParamName)
                            subelem.SetParameterValue(paramId, new DoubleParameterValue(thickness));

                        else if(param.Name == PlateLengthParamName && sets.writePlatesLengthWidth)
                            subelem.SetParameterValue(paramId, new DoubleParameterValue(plateLength));

                        else if (param.Name == PlateWidthParamName && sets.writePlatesLengthWidth)
                            subelem.SetParameterValue(paramId, new DoubleParameterValue(plateWidth));

                    }
                    platesCount++;
                }
                t.Commit();
            }

            BalloonTip.Show("Успешно", "Обработано пластин: " + platesCount.ToString());
            sets.Save();
            return Result.Succeeded;
        }


        public double GetDimension<T>(T plate, DimensionKind kind)
        {
            BuiltInParameter param = BuiltInParameter.STEEL_ELEM_PLATE_LENGTH;

            switch (kind)
            {
                case DimensionKind.Length:
                    param = BuiltInParameter.STEEL_ELEM_PLATE_LENGTH;
                    break;
                case DimensionKind.Width:
                    param = BuiltInParameter.STEEL_ELEM_PLATE_WIDTH;
                    break;
                case DimensionKind.Thickness:
                    param = BuiltInParameter.STEEL_ELEM_PLATE_THICKNESS;
                    break;
            }

            if (plate is SteelProxyElement)
            {
                SteelProxyElement plateFree = plate as SteelProxyElement;
                Parameter plateParam = plateFree.get_Parameter(param);
                if (plateParam == null || !plateParam.HasValue)
                {
                    throw new Exception("Нет параметра " + Enum.GetName(typeof(DimensionKind), kind) + " в пластине " + plateFree.Id.IntegerValue.ToString());
                }
                double dim = plateParam.AsDouble();
                return dim;
            }
            if (plate is Subelement)
            {
                Subelement plateAsSubelem = plate as Subelement;
                ParameterValue lengthParamValue = plateAsSubelem.GetParameterValue(new ElementId(param));
                if(lengthParamValue == null)
                {
                    throw new Exception("Нет параметра " + Enum.GetName(typeof(DimensionKind), kind) + " в пластине " + plateAsSubelem.Element.Id.IntegerValue.ToString());
                }
                DoubleParameterValue lengthDoubleValue = lengthParamValue as DoubleParameterValue;
                return lengthDoubleValue.Value;
            }
            return -1;
        }

        public void WriteParameter(Element elem, string paramName, object Value, bool rewrite)
        {
            Parameter param = elem.LookupParameter(paramName);
            if (param == null)
            {
                TaskDialog.Show("Ошибка", "Нет параметра " + paramName);
                throw new Exception("Нет параметра " + paramName);
            }
            if (param.HasValue && !rewrite) return;
            switch (param.StorageType)
            {
                case StorageType.Integer:
                    param.Set((int)Value);
                    break;
                case StorageType.Double:
                    param.Set((double)Value);
                    break;
                case StorageType.String:
                    param.Set((string)Value);
                    break;
                case StorageType.ElementId:
                    param.Set((ElementId)Value);
                    break;
            }
        }
    }
}

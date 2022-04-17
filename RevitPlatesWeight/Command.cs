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
using System.Diagnostics;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RVTDocument = Autodesk.Revit.DB.Document;
using ASDocument = Autodesk.AdvanceSteel.DocumentManagement.Document;
using RVTransaction = Autodesk.Revit.DB.Transaction;

#if R2019 || R2020
using FabricationTransaction = RvtDwgAddon.FabricationTransaction;
#else
using FabricationTransaction = Autodesk.SteelConnectionsDB.FabricationTransaction;
#endif

using Autodesk.Revit.DB.Steel;
using Autodesk.Revit.DB.Structure;
#endregion

namespace RevitPlatesWeight
{
    public enum DimensionKind { Length, Width, Thickness }
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Debug.Listeners.Clear();
            Debug.Listeners.Add(new RbsLogger.Logger("SteelParametrisation"));
            int revitVersionNumber = int.Parse(commandData.Application.Application.VersionNumber);
            if (revitVersionNumber < 2019)
            {
                TaskDialog.Show("Ошибка", "Функция доступна только в Revit 2019 и выше!");
                Debug.WriteLine("Unsupportable Revit version");
                return Result.Cancelled;
            }

            Settings sets = Settings.Activate();
            int platesCount = 0;

            RVTDocument doc = commandData.Application.ActiveUIDocument.Document;

            View calculateView = doc.ActiveView;
            if (!(calculateView is View3D) || calculateView.DetailLevel != ViewDetailLevel.Fine)
            {
                TaskDialog.Show("Ошибка", "Перед запуском плагина перейдите на 3D вид с включенным Высоким уровнем детализации");
                Debug.WriteLine("Unable to use view " + calculateView.Name);
                return Result.Failed;
            }

            List<BuiltInCategory> constrCats = new List<BuiltInCategory> {
                BuiltInCategory.OST_StructuralFraming,
                BuiltInCategory.OST_StructuralColumns,
            };

            FilteredElementCollector collectorConstrs = null;
            FilteredElementCollector collectorPlatesFree = null;
            FilteredElementCollector collectorJoints = null;

            if (sets.useOnlyVisibleOnCurrentView)
            {
                collectorConstrs = new FilteredElementCollector(doc, calculateView.Id);
                collectorPlatesFree = new FilteredElementCollector(doc, calculateView.Id);
                collectorJoints = new FilteredElementCollector(doc, calculateView.Id);
            }
            else
            {
                collectorConstrs = new FilteredElementCollector(doc);
                collectorPlatesFree = new FilteredElementCollector(doc);
                collectorJoints = new FilteredElementCollector(doc);
            }

            
            List<Element> constrs = collectorConstrs
                .WhereElementIsNotElementType()
                .WherePasses(new ElementMulticategoryFilter(constrCats))
                .ToElements()
                .ToList();
            Debug.WriteLine("Beams and columns found: " + constrs.Count.ToString());

            List<Plate> plates = collectorPlatesFree
                .WhereElementIsNotElementType()
                .OfClass(typeof(SteelProxyElement))
                .Cast<SteelProxyElement>()
                .Where(i => i.GeomType == GeomObjectType.Plate)
                .Select(i => new PlateFree(i, calculateView, sets))
                .ToList<Plate>();
            Debug.WriteLine("PlatesFree found: " + plates.Count.ToString());


            List<StructuralConnectionHandler> joints = collectorJoints
                .WhereElementIsNotElementType()
                .OfClass(typeof(StructuralConnectionHandler))
                .Cast<StructuralConnectionHandler>()
                .ToList();
            Debug.WriteLine("Joints found: " + joints.Count.ToString());

            using (FabricationTransaction t = new FabricationTransaction(doc, true, "Test plates"))
            {
                Debug.WriteLine("Start fabrication transaction");
                foreach (StructuralConnectionHandler joint in joints)
                {
                    List<Subelement> subelems = joint.GetSubelements().ToList();
                    foreach (Subelement subelem in subelems)
                    {
                        if (subelem.Category.Id != new ElementId(BuiltInCategory.OST_StructConnectionPlates)) continue;
                        PlateInJoint pij = new PlateInJoint(subelem, doc, sets);
                        plates.Add(pij);

                    }
                }
                Debug.WriteLine("Fabrication transaction success");
            }

            foreach (Plate plate in plates)
            {
                plate.CalculateValues(doc);
            }

            Dictionary<string, List<Plate>> platesGrouped = plates
            .GroupBy(i => i.GetKey(sets.enablePlatesNumbering, sets.writePlatesLengthWidth))
            .ToDictionary(j => j.Key, j => j.ToList());
            Debug.WriteLine("Plates groups: " + platesGrouped.Keys.Count.ToString());


            using (RVTransaction t = new RVTransaction(doc))
            {
                t.Start("КМ параметризация");
                Debug.WriteLine("Start beams and columns parametrisation");

                foreach (Element elem in constrs)
                {
                    Parameter lengthParam = null;

                    if (elem.Category.Id == new ElementId(BuiltInCategory.OST_StructuralColumns))
                    {
#if !R2019
                        lengthParam = elem.get_Parameter(BuiltInParameter.STEEL_ELEM_CUT_LENGTH);
#endif
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

                Debug.WriteLine("Start plates parametrisation");
                int platePosition = sets.plateNumberingStartWith;
                foreach (var kvp in platesGrouped)
                {
                    List<Plate> curPlates = kvp.Value;
                    Debug.WriteLine("Plate group key: " + kvp.Key);

                    foreach (Plate plate in curPlates)
                    {
                        plate.WriteValues(sets, doc);
                        if (sets.enablePlatesNumbering)
                        {
                            plate.WriteParameter(doc, sets.plateNumberingParamName, StorageType.String, platePosition.ToString(), true);
                        }
                        platesCount++;
                    }

                    platePosition++;
                }

                t.Commit();
                Debug.WriteLine("Revit transaction finished");
            }

            BalloonTip.Show("Успешно", "Обработано пластин: " + platesCount.ToString());
            sets.Save();
            return Result.Succeeded;
        }






    }
}
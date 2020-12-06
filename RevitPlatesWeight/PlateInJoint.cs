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
    public class PlateInJoint : Plate
    {
        Subelement _subelem;
        public override bool isSubelement => true;

        double _volume;
        public override double Volume => _volume;

        double _thickness;
        public override double Thickness => _thickness;

        ElementId materialId;
        public override ElementId MaterialId => materialId;

#if !R2019
        double _length;
        public override double Length => _length;

        double _width;
        public override double Width => _width;
#endif

        public PlateInJoint(Subelement subelem, RVTDocument doc, Settings sets)
        {
            _subelem = subelem;
            Reference rf = _subelem.GetReference();
            FilerObject filerObj = AdvanceSteelUtils.GetFilerObject(doc, rf);
            Autodesk.AdvanceSteel.Modelling.Plate pl = filerObj as Autodesk.AdvanceSteel.Modelling.Plate;
            _volume = pl.Volume / (1000000 * 29.504);


            ParameterValue pv = _subelem.GetParameterValue(new ElementId(BuiltInParameter.STRUCTURAL_MATERIAL_PARAM));
            ElementIdParameterValue idpv = pv as ElementIdParameterValue;
            materialId = idpv.Value;
            _thickness = GetDimension<Subelement>(_subelem, DimensionKind.Thickness);
#if !R2019
            if (sets.writePlatesLengthWidth)
            {
                _length = GetDimension(_subelem, DimensionKind.Length);
                _width = GetDimension(_subelem, DimensionKind.Width);
            }
#endif
        }


        public override double GetDimension<T>(T plate, DimensionKind kind)
        {
            BuiltInParameter param = Plate.GetParameterByKind(kind);
            Subelement plateAsSubelem = plate as Subelement;
            ParameterValue lengthParamValue = plateAsSubelem.GetParameterValue(new ElementId(param));
            if (lengthParamValue == null)
            {
                throw new Exception("Нет параметра " + Enum.GetName(typeof(DimensionKind), kind) + " в пластине " + plateAsSubelem.Element.Id.IntegerValue.ToString());
            }
            DoubleParameterValue lengthDoubleValue = lengthParamValue as DoubleParameterValue;
            return lengthDoubleValue.Value;
        }

        public override void WriteParameter(RVTDocument doc, string paramName, StorageType stype, object Value, bool rewrite)
        {
            List<ElementId> paramIds = _subelem.GetAllParameters().Where(i => doc.GetElement(i).Name == paramName).ToList();
            if (paramIds.Count == 0)
            {
                TaskDialog.Show("Ошибка", "Нет параметра " + paramName);
                throw new Exception("Нет параметра " + paramName);
            }
            ElementId paramId = paramIds.First();

            switch (stype)
            {
                case StorageType.Integer:
                    _subelem.SetParameterValue(paramId, new IntegerParameterValue((int)Value));
                    break;
                case StorageType.Double:
                    _subelem.SetParameterValue(paramId, new DoubleParameterValue((double)Value));
                    break;
                case StorageType.String:
                    _subelem.SetParameterValue(paramId, new StringParameterValue((string)Value));
                    break;
            }
        }
    }
}

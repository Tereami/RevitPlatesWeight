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
    public abstract class Plate
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

        public abstract bool isSubelement { get; }
        public abstract double Volume { get; }
        public abstract double Thickness { get; }
#if !R2019
        public abstract double Length { get; }
        public abstract double Width { get; }
#endif

        public abstract ElementId MaterialId { get; }


        double _mass;
        public double Mass { get { return _mass; } }
        
        public string ThicknessName { get { return _thicknessName; } }
        

        string _thicknessName;
        public string MaterialName;


        public void CalculateValues(RVTDocument doc)
        {
            double density = MaterialUtils.GetMaterialDensity(doc, MaterialId);
            MaterialName = doc.GetElement(MaterialId).Name;

            _mass = Volume * density;
            _thicknessName = "-" + (Thickness * 304.8).ToString("F0");
        }


        public void WriteValues(Settings sets, RVTDocument _doc)
        {
            WriteParameter(_doc, GroupConstParamName, StorageType.Integer, sets.GroupConstParamValue, sets.Rewrite);
            WriteParameter(_doc, ElementTypeParamName, StorageType.Integer, sets.ElementTypeParamValue, sets.Rewrite);

            WriteParameter(_doc, ProfileNameParamName, StorageType.String, sets.ProfileNameValue, sets.Rewrite);
            WriteParameter(_doc, ElementWeightTypeParamName, StorageType.Integer, sets.ElementWeightTypeValue, sets.Rewrite);

            WriteParameter(_doc, PlateNameParamName, StorageType.String, _thicknessName, true);
            WriteParameter(_doc, WeightParamName, StorageType.Double, Mass, true);
            WriteParameter(_doc, MaterialNameParam, StorageType.String, MaterialName, true);
            WriteParameter(_doc, VolumeParamName, StorageType.Double, Volume, true);

            if (sets.writeThickvalue)
            {
                WriteParameter(_doc, ThicknessParamName, StorageType.Double, Thickness, true);
            }
#if !R2019
            if (sets.writePlatesLengthWidth)
            {
                WriteParameter(_doc, PlateLengthParamName, StorageType.Double, Length, true);
                WriteParameter(_doc, PlateWidthParamName, StorageType.Double, Width, true);
            }
#endif
        }


        public string GetKey(bool enableNumbering, bool calculateLengthWidth)
        {
            if(!enableNumbering)
            {
                return "1";
            }
            string key = "m" + Mass.ToString("F2") + "t" + (Thickness * 304.8).ToString("F2");
#if !R2019
            if (calculateLengthWidth)
            {
                key += "l" + Length.ToString("F2") + "b" + Width.ToString("F2");
            }
#endif
            return key;
        }
        abstract public double GetDimension<T>(T plate, DimensionKind kind);
        abstract public void WriteParameter(RVTDocument doc, string paramName, StorageType stype, object Value, bool rewrite);

        public static BuiltInParameter GetParameterByKind(DimensionKind kind)
        {
            BuiltInParameter param = BuiltInParameter.STEEL_ELEM_PLATE_THICKNESS;

            switch (kind)
            {
#if !R2019
                case DimensionKind.Length:
                    param = BuiltInParameter.STEEL_ELEM_PLATE_LENGTH;
                    break;
                case DimensionKind.Width:
                    param = BuiltInParameter.STEEL_ELEM_PLATE_WIDTH;
                    break;
                case DimensionKind.Thickness:
                    param = BuiltInParameter.STEEL_ELEM_PLATE_THICKNESS;
                    break;
#endif
            }
            return param;
        }
    }
}

using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitPlatesWeight
{
    public static class Geometry
    {

        public static double FindTheLongestCurveLength(View v, Element elem)
        {
            Options opt = new Options { View = v };
            GeometryElement geoElem = elem.get_Geometry(opt);
            List<Solid> solids = GetSolidsFromElement(geoElem);

            double length = 0;

            foreach(Solid sol in solids)
            {
                List<Curve> curves = GetAllCurves(sol);
                foreach(Curve c in curves)
                {
                    if(c.Length > length)
                        length = c.Length;
                }
            }

            return length;
        }

        /// <summary>
        /// Получить список солидов из данной геометрии
        /// </summary>
        private static List<Solid> GetSolidsFromElement(GeometryElement geoElem)
        {
            List<Solid> solids = new List<Solid>();

            foreach (GeometryObject geoObj in geoElem)
            {
                if (geoObj is Solid)
                {
                    Solid solid = geoObj as Solid;
                    if (solid == null) continue;
                    if (solid.Volume == 0) continue;
                    solids.Add(solid);
                    continue;
                }
                if (geoObj is GeometryInstance)
                {
                    GeometryInstance geomIns = geoObj as GeometryInstance;
                    GeometryElement instGeoElement = geomIns.GetInstanceGeometry();
                    List<Solid> solids2 = GetSolidsFromElement(instGeoElement);
                    solids.AddRange(solids2);
                }
            }
            return solids;
        }

        /// <summary>
        /// Проверить, содержит ли данный элемент объемную 3D-геометрию
        /// </summary>
        public static bool ContainsSolids(Element elem)
        {
            GeometryElement geoElem = elem.get_Geometry(new Options());
            if (geoElem == null) return false;

            bool check = ContainsSolids(geoElem);
            return check;
        }

        /// <summary>
        /// Проверить, содержит ли данный элемент объемную 3D-геометрию
        /// </summary>
        public static bool ContainsSolids(GeometryElement geoElem)
        {
            if (geoElem == null) return false;

            foreach (GeometryObject geoObj in geoElem)
            {
                if (geoObj is Solid)
                {
                    return true;
                }
                if (geoObj is GeometryInstance)
                {
                    GeometryInstance geomIns = geoObj as GeometryInstance;
                    GeometryElement instGeoElement = geomIns.GetInstanceGeometry();
                    return ContainsSolids(instGeoElement);
                }
            }
            return false;
        }


        /// <summary>
        /// Получить все ребра из солида
        /// </summary>
        private static List<Curve> GetAllCurves(Solid solid)
        {
            List<Curve> curves = new List<Curve>();
            foreach (Face face in solid.Faces)
                curves.AddRange(GetAllCurves(face));

            return curves;
        }

        /// <summary>
        /// Получить все ребра из грани
        /// </summary>
        private static List<Curve> GetAllCurves(Face face)
        {
            List<Curve> curves = new List<Curve>();

            foreach (EdgeArray loop in face.EdgeLoops)
            {
                foreach (Edge edge in loop)
                {
                    Curve c2 = edge.AsCurve();
                    curves.Add(c2);
                }
            }
            return curves;
        }
    }
}

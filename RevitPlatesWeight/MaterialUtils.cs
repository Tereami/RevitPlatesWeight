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

using Autodesk.Revit.DB;

namespace RevitPlatesWeight
{
    public static class MaterialUtils
    {
		public static double GetMaterialDensity(Document doc, ElementId materialId)
		{
			Material material = doc.GetElement(materialId) as Material;
			PropertySetElement materialStructuralParams = doc.GetElement(material.StructuralAssetId) as PropertySetElement;
			double density = materialStructuralParams.get_Parameter(BuiltInParameter.PHY_MATERIAL_PARAM_STRUCTURAL_DENSITY).AsDouble();
			return density;
		}
	}
}

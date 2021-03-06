﻿#region License
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;

namespace RevitPlatesWeight
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class App : IExternalApplication
    {
        public static string assemblyPath = "";
        public static string assemblyFolder = "";
        public static string solutionName = "";
        public Result OnStartup(UIControlledApplication application)
        {
            assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            assemblyFolder = System.IO.Path.GetDirectoryName(assemblyPath);

            string tabName = "BIM-STARTER TEST";
            solutionName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            try { application.CreateRibbonTab(tabName); } catch { }

            string panelName = "Steel";
            string buttonTitle = "Plate weight";

            RibbonPanel panel = application.CreateRibbonPanel(tabName, panelName);

            PushButton btn = panel.AddItem(new PushButtonData(
                "CommandPlateWeight",
                buttonTitle,
                assemblyPath,
                "RevitPlatesWeight.Command")
                ) as PushButton;

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        private PushButton CreateButton(string Name, RibbonPanel pan)
        {
            PushButton btn = pan.AddItem(new PushButtonData(
                "CommandPlateWeight",
                "Plate weight",
                assemblyPath,
                solutionName + "." + Name)
                ) as PushButton;

            return btn;
        }
    }
}

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

            string tabName = "Weandrevit";
            solutionName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            try { application.CreateRibbonTab(tabName); } catch { }

            string panelName = "Steel";
            string buttonTitle = "Plate weight";
            string toltip = "Calculate weight of plates that creates by Steel tab. F1 for help";

            if(application.ControlledApplication.Language == LanguageType.Russian)
            {
                panelName = "Сталь";
                buttonTitle = "Масса пластин";
                toltip = "Вычисление массы пластин, созданных через вкладку Сталь. F1 для справки";
            }

            RibbonPanel panel = application.CreateRibbonPanel(tabName, panelName);

            PushButton btn = panel.AddItem(new PushButtonData(
                "CommandPlateWeight",
                buttonTitle,
                assemblyPath,
                "RevitPlatesWeight.Command")
                ) as PushButton;

            btn.LargeImage = PngImageSource("RevitPlatesWeight.Resources.Command_large.png");
            btn.Image = PngImageSource("RevitPlatesWeight.Resources.Command_small.png");

            btn.ToolTip = toltip;

            string url = @"http://weandrevit.ru/plagin-massa-plastin-km/";
            ContextualHelp chelp = new ContextualHelp(ContextualHelpType.Url, url);
            btn.SetContextualHelp(chelp);

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

            btn.LargeImage = PngImageSource("RevitPlatesWeight.Resources.Command_large.png");
            btn.Image = PngImageSource("RevitPlatesWeight.Resources.Command_small.png");
            return btn;
        }

        private System.Windows.Media.ImageSource PngImageSource(string embeddedPathname)
        {
            System.IO.Stream st = this.GetType().Assembly.GetManifestResourceStream(embeddedPathname);
            System.Windows.Media.Imaging.PngBitmapDecoder decoder = 
                new System.Windows.Media.Imaging.PngBitmapDecoder(st,
                System.Windows.Media.Imaging.BitmapCreateOptions.PreservePixelFormat,
                System.Windows.Media.Imaging.BitmapCacheOption.Default);
            return decoder.Frames[0];
        }
    }
}

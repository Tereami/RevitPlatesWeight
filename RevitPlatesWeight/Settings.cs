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
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace RevitPlatesWeight
{
    [Serializable]
    public class Settings
    {
        public string ProfileNameValue = "Сталь листовая (ГОСТ 19903-2015)";
        public int GroupConstParamValue = 10;
        public int ElementTypeParamValue = 6;
        public int ElementWeightTypeValue = 5;
        public bool Rewrite = true;
        public bool writeThickName = true;
        public bool writeThickvalue = true;
        public bool writePlatesLengthWidth = false;
        public bool enablePlatesNumbering = false;
        public string plateNumberingParamName = "Марка";
        public int plateNumberingStartWith = 1;
        public bool writeBeamLength = false;
        public bool writeColumnLength = false;

        private static string xmlPath = "";
        
        public static Settings Activate()
        {
            Debug.WriteLine("Start activate settins");
            string appdataPath =  Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string rbspath = Path.Combine(appdataPath, "bim-starter");
            if (!Directory.Exists(rbspath))
            {
                Debug.WriteLine("Create directory " + rbspath);
                Directory.CreateDirectory(rbspath);
            }
            string solutionName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string solutionFolder = Path.Combine(rbspath, solutionName);
            if (!Directory.Exists(solutionFolder))
            {
                Directory.CreateDirectory(solutionFolder);
                Debug.WriteLine("Create directory " + solutionFolder);
            }
            xmlPath = Path.Combine(solutionFolder, "settings.xml");
            Settings s = null;

            if (File.Exists(xmlPath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                using (StreamReader reader = new StreamReader(xmlPath))
                {
                    try
                    {
                        s = (Settings)serializer.Deserialize(reader);
                        Debug.WriteLine("Settings deserialize success");
                    }
                    catch { }
                }
            }
            if(s == null)
            {
                s = new Settings();
                Debug.WriteLine("Settings is null, create new one");
            }
            SettingsForm form = new SettingsForm(s, xmlPath);
            Debug.WriteLine("Show settings form");
            form.ShowDialog();
            if(form.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                Debug.WriteLine("Setting form cancelled");
                throw new Exception("Отменено");
            }
            s = form.newSets;
            Debug.WriteLine("Settings success");
            return s;
        }

        public void Save()
        {
            Debug.WriteLine("Start save settins to file " + xmlPath);
            if (File.Exists(xmlPath)) File.Delete(xmlPath);
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            using (FileStream writer = new FileStream(xmlPath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(writer, this);
            }
            Debug.WriteLine("Save settings success");
        }
    }
}

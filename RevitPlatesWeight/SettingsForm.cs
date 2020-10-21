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
using System.Windows.Forms;

namespace RevitPlatesWeight
{
    public partial class SettingsForm : Form
    {
        public Settings newSets;
        public SettingsForm(Settings set, string xmlpath)
        {
            InitializeComponent();

            this.textBoxProfileName.Text = set.ProfileNameValue;
            this.numGroupConstr.Value = set.GroupConstParamValue;
            this.numElemType.Value = set.ElementTypeParamValue;
            this.numWeightType.Value = set.ElementWeightTypeValue;
            this.checkBoxRewrite.Checked = set.Rewrite;
            this.checkBoxWriteThickName.Checked = set.writeThickName;
            this.checkBoxWriteThickness.Checked = set.writeThickvalue;
            this.checkBoxWritePlateLengthWidth.Checked = set.writePlatesLengthWidth;
            this.checkBoxWriteBeamsLength.Checked = set.writeBeamLength;
            this.checkBoxWriteColumnsLength.Checked = set.writeColumnLength;

#if R2019
            checkBoxWritePlateLengthWidth.Enabled = false;
            checkBoxWritePlateLengthWidth.Enabled = false;
#endif

            this.labelPath.Text = xmlpath;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            newSets = new Settings()
            {
                ProfileNameValue = textBoxProfileName.Text,
                GroupConstParamValue = (int)numGroupConstr.Value,
                ElementTypeParamValue = (int)numElemType.Value,
                ElementWeightTypeValue = (int)numWeightType.Value,
                writeThickName = checkBoxWriteThickName.Checked,
                writeThickvalue= checkBoxWriteThickness.Checked,
                writePlatesLengthWidth = checkBoxWritePlateLengthWidth.Checked,
                writeBeamLength = checkBoxWriteBeamsLength.Checked,
                writeColumnLength = checkBoxWriteColumnsLength.Checked,
                Rewrite = checkBoxRewrite.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

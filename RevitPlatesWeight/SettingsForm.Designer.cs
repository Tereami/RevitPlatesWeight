namespace RevitPlatesWeight
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRewrite = new System.Windows.Forms.CheckBox();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.numWeightType = new System.Windows.Forms.NumericUpDown();
            this.numElemType = new System.Windows.Forms.NumericUpDown();
            this.numGroupConstr = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxWritePlateLengthWidth = new System.Windows.Forms.CheckBox();
            this.checkBoxWriteThickness = new System.Windows.Forms.CheckBox();
            this.checkBoxWriteThickName = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxWriteColumnsLength = new System.Windows.Forms.CheckBox();
            this.checkBoxWriteBeamsLength = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numElemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupConstr)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "КМ.ГруппаКонструкций:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "КМ.ТипЭлемента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Орг.НаименованиеПрофиля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Орг.СпособПодсчетаМассы";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxRewrite);
            this.groupBox1.Controls.Add(this.textBoxProfileName);
            this.groupBox1.Controls.Add(this.numWeightType);
            this.groupBox1.Controls.Add(this.numElemType);
            this.groupBox1.Controls.Add(this.numGroupConstr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(250, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры по умолчанию";
            // 
            // checkBoxRewrite
            // 
            this.checkBoxRewrite.AutoSize = true;
            this.checkBoxRewrite.Location = new System.Drawing.Point(13, 152);
            this.checkBoxRewrite.Name = "checkBoxRewrite";
            this.checkBoxRewrite.Size = new System.Drawing.Size(163, 17);
            this.checkBoxRewrite.TabIndex = 6;
            this.checkBoxRewrite.Text = "Перезаписывать значения";
            this.checkBoxRewrite.UseVisualStyleBackColor = true;
            // 
            // textBoxProfileName
            // 
            this.textBoxProfileName.Location = new System.Drawing.Point(13, 44);
            this.textBoxProfileName.Name = "textBoxProfileName";
            this.textBoxProfileName.Size = new System.Drawing.Size(223, 20);
            this.textBoxProfileName.TabIndex = 5;
            this.textBoxProfileName.Text = "Сталь листовая (ГОСТ 19903-2015)";
            // 
            // numWeightType
            // 
            this.numWeightType.Location = new System.Drawing.Point(175, 124);
            this.numWeightType.Name = "numWeightType";
            this.numWeightType.Size = new System.Drawing.Size(61, 20);
            this.numWeightType.TabIndex = 4;
            this.numWeightType.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numElemType
            // 
            this.numElemType.Location = new System.Drawing.Point(175, 101);
            this.numElemType.Name = "numElemType";
            this.numElemType.Size = new System.Drawing.Size(61, 20);
            this.numElemType.TabIndex = 4;
            this.numElemType.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numGroupConstr
            // 
            this.numGroupConstr.Location = new System.Drawing.Point(175, 78);
            this.numGroupConstr.Name = "numGroupConstr";
            this.numGroupConstr.Size = new System.Drawing.Size(61, 20);
            this.numGroupConstr.TabIndex = 4;
            this.numGroupConstr.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(106, 466);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(187, 466);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Настройки будут сохранены в файле:";
            // 
            // labelPath
            // 
            this.labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPath.Location = new System.Drawing.Point(12, 421);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(250, 39);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "C:\\Users\\Username\\AppData\\Roaming\\bim-starter\\RevitPlatesWeight\\settings.xml";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.checkBoxWritePlateLengthWidth);
            this.groupBox2.Controls.Add(this.checkBoxWriteThickness);
            this.groupBox2.Controls.Add(this.checkBoxWriteThickName);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размеры пластины";
            // 
            // checkBoxWritePlateLengthWidth
            // 
            this.checkBoxWritePlateLengthWidth.AutoSize = true;
            this.checkBoxWritePlateLengthWidth.Location = new System.Drawing.Point(13, 66);
            this.checkBoxWritePlateLengthWidth.Name = "checkBoxWritePlateLengthWidth";
            this.checkBoxWritePlateLengthWidth.Size = new System.Drawing.Size(215, 17);
            this.checkBoxWritePlateLengthWidth.TabIndex = 1;
            this.checkBoxWritePlateLengthWidth.Text = "Заполнить Рзм.Длина и Рзм.Ширина";
            this.checkBoxWritePlateLengthWidth.UseVisualStyleBackColor = true;
            // 
            // checkBoxWriteThickness
            // 
            this.checkBoxWriteThickness.AutoSize = true;
            this.checkBoxWriteThickness.Location = new System.Drawing.Point(13, 43);
            this.checkBoxWriteThickness.Name = "checkBoxWriteThickness";
            this.checkBoxWriteThickness.Size = new System.Drawing.Size(153, 17);
            this.checkBoxWriteThickness.TabIndex = 0;
            this.checkBoxWriteThickness.Text = "Заполнить Рзм.Толщина";
            this.checkBoxWriteThickness.UseVisualStyleBackColor = true;
            // 
            // checkBoxWriteThickName
            // 
            this.checkBoxWriteThickName.AutoSize = true;
            this.checkBoxWriteThickName.Checked = true;
            this.checkBoxWriteThickName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWriteThickName.Location = new System.Drawing.Point(13, 20);
            this.checkBoxWriteThickName.Name = "checkBoxWriteThickName";
            this.checkBoxWriteThickName.Size = new System.Drawing.Size(173, 17);
            this.checkBoxWriteThickName.TabIndex = 0;
            this.checkBoxWriteThickName.Text = "Заполнить О_Наименование";
            this.checkBoxWriteThickName.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxWriteColumnsLength);
            this.groupBox3.Controls.Add(this.checkBoxWriteBeamsLength);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 72);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заполнение Рзм.КорректировкаДлины";
            // 
            // checkBoxWriteColumnsLength
            // 
            this.checkBoxWriteColumnsLength.AutoSize = true;
            this.checkBoxWriteColumnsLength.Location = new System.Drawing.Point(13, 44);
            this.checkBoxWriteColumnsLength.Name = "checkBoxWriteColumnsLength";
            this.checkBoxWriteColumnsLength.Size = new System.Drawing.Size(220, 17);
            this.checkBoxWriteColumnsLength.TabIndex = 7;
            this.checkBoxWriteColumnsLength.Text = "Для колонн (через \"Длину подрезки\")";
            this.checkBoxWriteColumnsLength.UseVisualStyleBackColor = true;
            // 
            // checkBoxWriteBeamsLength
            // 
            this.checkBoxWriteBeamsLength.AutoSize = true;
            this.checkBoxWriteBeamsLength.Location = new System.Drawing.Point(13, 21);
            this.checkBoxWriteBeamsLength.Name = "checkBoxWriteBeamsLength";
            this.checkBoxWriteBeamsLength.Size = new System.Drawing.Size(233, 17);
            this.checkBoxWriteBeamsLength.TabIndex = 6;
            this.checkBoxWriteBeamsLength.Text = "Для балок (через \"Фактическую длину\")";
            this.checkBoxWriteBeamsLength.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Только Revit 2020 и выше";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(274, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numElemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupConstr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxProfileName;
        private System.Windows.Forms.NumericUpDown numWeightType;
        private System.Windows.Forms.NumericUpDown numElemType;
        private System.Windows.Forms.NumericUpDown numGroupConstr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxWriteThickness;
        private System.Windows.Forms.CheckBox checkBoxWriteThickName;
        private System.Windows.Forms.CheckBox checkBoxRewrite;
        private System.Windows.Forms.CheckBox checkBoxWritePlateLengthWidth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxWriteColumnsLength;
        private System.Windows.Forms.CheckBox checkBoxWriteBeamsLength;
        private System.Windows.Forms.Label label6;
    }
}
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
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxWritePlateLengthWidth = new System.Windows.Forms.CheckBox();
            this.checkBoxWriteThickness = new System.Windows.Forms.CheckBox();
            this.checkBoxWriteThickName = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxWriteColumnsLength = new System.Windows.Forms.CheckBox();
            this.checkBoxWriteBeamsLength = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnablePlateNumbering = new System.Windows.Forms.CheckBox();
            this.textBoxPlateNumberingParamName = new System.Windows.Forms.TextBox();
            this.numericUpDownNumberingStartWith = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioAllProject = new System.Windows.Forms.RadioButton();
            this.radioOnlyCurrentView = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numElemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupConstr)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingStartWith)).BeginInit();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.checkBoxRewrite);
            this.groupBox1.Controls.Add(this.textBoxProfileName);
            this.groupBox1.Controls.Add(this.numWeightType);
            this.groupBox1.Controls.Add(this.numElemType);
            this.groupBox1.Controls.Add(this.numGroupConstr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
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
            this.buttonOk.Location = new System.Drawing.Point(106, 644);
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
            this.buttonCancel.Location = new System.Drawing.Point(187, 644);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Настройки будут сохранены в файле:";
            // 
            // labelPath
            // 
            this.labelPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPath.Location = new System.Drawing.Point(9, 604);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(250, 39);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "C:\\Users\\Username\\AppData\\Roaming\\bim-starter\\RevitPlatesWeight\\settings.xml";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.checkBoxWritePlateLengthWidth);
            this.groupBox2.Controls.Add(this.checkBoxWriteThickness);
            this.groupBox2.Controls.Add(this.checkBoxWriteThickName);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размеры пластины";
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
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.checkBoxWriteColumnsLength);
            this.groupBox3.Controls.Add(this.checkBoxWriteBeamsLength);
            this.groupBox3.Location = new System.Drawing.Point(12, 511);
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
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.checkBoxEnablePlateNumbering);
            this.groupBox4.Controls.Add(this.textBoxPlateNumberingParamName);
            this.groupBox4.Controls.Add(this.numericUpDownNumberingStartWith);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 112);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Нумерация пластин";
            // 
            // checkBoxEnablePlateNumbering
            // 
            this.checkBoxEnablePlateNumbering.AutoSize = true;
            this.checkBoxEnablePlateNumbering.Location = new System.Drawing.Point(13, 19);
            this.checkBoxEnablePlateNumbering.Name = "checkBoxEnablePlateNumbering";
            this.checkBoxEnablePlateNumbering.Size = new System.Drawing.Size(75, 17);
            this.checkBoxEnablePlateNumbering.TabIndex = 2;
            this.checkBoxEnablePlateNumbering.Text = "Включить";
            this.checkBoxEnablePlateNumbering.UseVisualStyleBackColor = true;
            // 
            // textBoxPlateNumberingParamName
            // 
            this.textBoxPlateNumberingParamName.Location = new System.Drawing.Point(13, 58);
            this.textBoxPlateNumberingParamName.Name = "textBoxPlateNumberingParamName";
            this.textBoxPlateNumberingParamName.Size = new System.Drawing.Size(223, 20);
            this.textBoxPlateNumberingParamName.TabIndex = 1;
            this.textBoxPlateNumberingParamName.Text = "О_Позиция";
            // 
            // numericUpDownNumberingStartWith
            // 
            this.numericUpDownNumberingStartWith.Location = new System.Drawing.Point(172, 84);
            this.numericUpDownNumberingStartWith.Name = "numericUpDownNumberingStartWith";
            this.numericUpDownNumberingStartWith.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownNumberingStartWith.TabIndex = 4;
            this.numericUpDownNumberingStartWith.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Имя параметра для нумерации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Начать с позиции:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.radioOnlyCurrentView);
            this.groupBox5.Controls.Add(this.radioAllProject);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 70);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Обрабатывать элементы:";
            // 
            // radioAllProject
            // 
            this.radioAllProject.AutoSize = true;
            this.radioAllProject.Location = new System.Drawing.Point(13, 42);
            this.radioAllProject.Name = "radioAllProject";
            this.radioAllProject.Size = new System.Drawing.Size(111, 17);
            this.radioAllProject.TabIndex = 0;
            this.radioAllProject.Text = "Во всём проекте";
            this.radioAllProject.UseVisualStyleBackColor = true;
            // 
            // radioOnlyCurrentView
            // 
            this.radioOnlyCurrentView.AutoSize = true;
            this.radioOnlyCurrentView.Checked = true;
            this.radioOnlyCurrentView.Location = new System.Drawing.Point(13, 19);
            this.radioOnlyCurrentView.Name = "radioOnlyCurrentView";
            this.radioOnlyCurrentView.Size = new System.Drawing.Size(218, 17);
            this.radioOnlyCurrentView.TabIndex = 0;
            this.radioOnlyCurrentView.TabStop = true;
            this.radioOnlyCurrentView.Text = "Только видимые на текущем 3D виде";
            this.radioOnlyCurrentView.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(274, 679);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingStartWith)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxEnablePlateNumbering;
        private System.Windows.Forms.TextBox textBoxPlateNumberingParamName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberingStartWith;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioOnlyCurrentView;
        private System.Windows.Forms.RadioButton radioAllProject;
    }
}
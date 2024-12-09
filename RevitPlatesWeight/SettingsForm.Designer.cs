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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
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
            this.textBoxPlatePrefix = new System.Windows.Forms.TextBox();
            this.checkBoxWritePlateLengthWidth = new System.Windows.Forms.CheckBox();
            this.checkBoxWriteThickness = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.radioOnlyCurrentView = new System.Windows.Forms.RadioButton();
            this.radioAllProject = new System.Windows.Forms.RadioButton();
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.checkBoxRewrite);
            this.groupBox1.Controls.Add(this.textBoxProfileName);
            this.groupBox1.Controls.Add(this.numWeightType);
            this.groupBox1.Controls.Add(this.numElemType);
            this.groupBox1.Controls.Add(this.numGroupConstr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBoxRewrite
            // 
            resources.ApplyResources(this.checkBoxRewrite, "checkBoxRewrite");
            this.checkBoxRewrite.Name = "checkBoxRewrite";
            this.checkBoxRewrite.UseVisualStyleBackColor = true;
            // 
            // textBoxProfileName
            // 
            resources.ApplyResources(this.textBoxProfileName, "textBoxProfileName");
            this.textBoxProfileName.Name = "textBoxProfileName";
            // 
            // numWeightType
            // 
            resources.ApplyResources(this.numWeightType, "numWeightType");
            this.numWeightType.Name = "numWeightType";
            this.numWeightType.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numElemType
            // 
            resources.ApplyResources(this.numElemType, "numElemType");
            this.numElemType.Name = "numElemType";
            this.numElemType.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numGroupConstr
            // 
            resources.ApplyResources(this.numGroupConstr, "numGroupConstr");
            this.numGroupConstr.Name = "numGroupConstr";
            this.numGroupConstr.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // labelPath
            // 
            resources.ApplyResources(this.labelPath, "labelPath");
            this.labelPath.Name = "labelPath";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxPlatePrefix);
            this.groupBox2.Controls.Add(this.checkBoxWritePlateLengthWidth);
            this.groupBox2.Controls.Add(this.checkBoxWriteThickness);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.checkBoxWriteThickName);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBoxPlatePrefix
            // 
            resources.ApplyResources(this.textBoxPlatePrefix, "textBoxPlatePrefix");
            this.textBoxPlatePrefix.Name = "textBoxPlatePrefix";
            // 
            // checkBoxWritePlateLengthWidth
            // 
            resources.ApplyResources(this.checkBoxWritePlateLengthWidth, "checkBoxWritePlateLengthWidth");
            this.checkBoxWritePlateLengthWidth.Name = "checkBoxWritePlateLengthWidth";
            this.checkBoxWritePlateLengthWidth.UseVisualStyleBackColor = true;
            // 
            // checkBoxWriteThickness
            // 
            resources.ApplyResources(this.checkBoxWriteThickness, "checkBoxWriteThickness");
            this.checkBoxWriteThickness.Name = "checkBoxWriteThickness";
            this.checkBoxWriteThickness.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // checkBoxWriteThickName
            // 
            resources.ApplyResources(this.checkBoxWriteThickName, "checkBoxWriteThickName");
            this.checkBoxWriteThickName.Checked = true;
            this.checkBoxWriteThickName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWriteThickName.Name = "checkBoxWriteThickName";
            this.checkBoxWriteThickName.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.checkBoxWriteColumnsLength);
            this.groupBox3.Controls.Add(this.checkBoxWriteBeamsLength);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // checkBoxWriteColumnsLength
            // 
            resources.ApplyResources(this.checkBoxWriteColumnsLength, "checkBoxWriteColumnsLength");
            this.checkBoxWriteColumnsLength.Name = "checkBoxWriteColumnsLength";
            this.checkBoxWriteColumnsLength.UseVisualStyleBackColor = true;
            // 
            // checkBoxWriteBeamsLength
            // 
            resources.ApplyResources(this.checkBoxWriteBeamsLength, "checkBoxWriteBeamsLength");
            this.checkBoxWriteBeamsLength.Name = "checkBoxWriteBeamsLength";
            this.checkBoxWriteBeamsLength.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.checkBoxEnablePlateNumbering);
            this.groupBox4.Controls.Add(this.textBoxPlateNumberingParamName);
            this.groupBox4.Controls.Add(this.numericUpDownNumberingStartWith);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // checkBoxEnablePlateNumbering
            // 
            resources.ApplyResources(this.checkBoxEnablePlateNumbering, "checkBoxEnablePlateNumbering");
            this.checkBoxEnablePlateNumbering.Name = "checkBoxEnablePlateNumbering";
            this.checkBoxEnablePlateNumbering.UseVisualStyleBackColor = true;
            // 
            // textBoxPlateNumberingParamName
            // 
            resources.ApplyResources(this.textBoxPlateNumberingParamName, "textBoxPlateNumberingParamName");
            this.textBoxPlateNumberingParamName.Name = "textBoxPlateNumberingParamName";
            // 
            // numericUpDownNumberingStartWith
            // 
            resources.ApplyResources(this.numericUpDownNumberingStartWith, "numericUpDownNumberingStartWith");
            this.numericUpDownNumberingStartWith.Name = "numericUpDownNumberingStartWith";
            this.numericUpDownNumberingStartWith.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.radioOnlyCurrentView);
            this.groupBox5.Controls.Add(this.radioAllProject);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // radioOnlyCurrentView
            // 
            resources.ApplyResources(this.radioOnlyCurrentView, "radioOnlyCurrentView");
            this.radioOnlyCurrentView.Checked = true;
            this.radioOnlyCurrentView.Name = "radioOnlyCurrentView";
            this.radioOnlyCurrentView.TabStop = true;
            this.radioOnlyCurrentView.UseVisualStyleBackColor = true;
            // 
            // radioAllProject
            // 
            resources.ApplyResources(this.radioAllProject, "radioAllProject");
            this.radioAllProject.Name = "radioAllProject";
            this.radioAllProject.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
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
        private System.Windows.Forms.TextBox textBoxPlatePrefix;
        private System.Windows.Forms.Label label9;
    }
}
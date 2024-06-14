namespace Курсач
{
    partial class PrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.comboBoxDiagnosis = new System.Windows.Forms.ComboBox();
            this.comboBoxMedicines = new System.Windows.Forms.ComboBox();
            this.btnSaveP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMedicineName = new System.Windows.Forms.TextBox();
            this.btnCheckMedicine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(131, 32);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(295, 22);
            this.textBoxPatientName.TabIndex = 0;
            // 
            // comboBoxDiagnosis
            // 
            this.comboBoxDiagnosis.FormattingEnabled = true;
            this.comboBoxDiagnosis.Location = new System.Drawing.Point(131, 65);
            this.comboBoxDiagnosis.Name = "comboBoxDiagnosis";
            this.comboBoxDiagnosis.Size = new System.Drawing.Size(295, 24);
            this.comboBoxDiagnosis.TabIndex = 1;
            // 
            // comboBoxMedicines
            // 
            this.comboBoxMedicines.FormattingEnabled = true;
            this.comboBoxMedicines.Location = new System.Drawing.Point(131, 107);
            this.comboBoxMedicines.Name = "comboBoxMedicines";
            this.comboBoxMedicines.Size = new System.Drawing.Size(295, 24);
            this.comboBoxMedicines.TabIndex = 2;
            // 
            // btnSaveP
            // 
            this.btnSaveP.Location = new System.Drawing.Point(156, 157);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(112, 42);
            this.btnSaveP.TabIndex = 3;
            this.btnSaveP.Text = "Зберегти рецепт";
            this.btnSaveP.UseVisualStyleBackColor = true;
            this.btnSaveP.Click += new System.EventHandler(this.btnSaveP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ПІБ Пацієнта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Діагноз";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Медикамент";
            // 
            // textBoxMedicineName
            // 
            this.textBoxMedicineName.Location = new System.Drawing.Point(170, 213);
            this.textBoxMedicineName.Name = "textBoxMedicineName";
            this.textBoxMedicineName.Size = new System.Drawing.Size(150, 22);
            this.textBoxMedicineName.TabIndex = 7;
            // 
            // btnCheckMedicine
            // 
            this.btnCheckMedicine.Location = new System.Drawing.Point(326, 210);
            this.btnCheckMedicine.Name = "btnCheckMedicine";
            this.btnCheckMedicine.Size = new System.Drawing.Size(100, 28);
            this.btnCheckMedicine.TabIndex = 8;
            this.btnCheckMedicine.Text = "Перевірити";
            this.btnCheckMedicine.UseVisualStyleBackColor = true;
            this.btnCheckMedicine.Click += new System.EventHandler(this.btnCheckMedicine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Перевірити наявність:";
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckMedicine);
            this.Controls.Add(this.textBoxMedicineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveP);
            this.Controls.Add(this.comboBoxMedicines);
            this.Controls.Add(this.comboBoxDiagnosis);
            this.Controls.Add(this.textBoxPatientName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.ComboBox comboBoxDiagnosis;
        private System.Windows.Forms.ComboBox comboBoxMedicines;
        private System.Windows.Forms.Button btnSaveP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMedicineName;
        private System.Windows.Forms.Button btnCheckMedicine;
        private System.Windows.Forms.Label label4;
    }
}
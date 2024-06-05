namespace Курсач
{
    partial class AddDisease
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSeverityLevel = new System.Windows.Forms.TextBox();
            this.tbDot = new System.Windows.Forms.TextBox();
            this.tbSymptoms = new System.Windows.Forms.TextBox();
            this.tbRecommendedMedicines = new System.Windows.Forms.TextBox();
            this.tbProcedures = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chbIsContagious = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.tbMortalityRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbIsContagious);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbMortalityRate);
            this.groupBox1.Controls.Add(this.tbSeverityLevel);
            this.groupBox1.Controls.Add(this.tbDot);
            this.groupBox1.Controls.Add(this.tbSymptoms);
            this.groupBox1.Controls.Add(this.tbRecommendedMedicines);
            this.groupBox1.Controls.Add(this.tbProcedures);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні данні";
            // 
            // tbSeverityLevel
            // 
            this.tbSeverityLevel.Location = new System.Drawing.Point(183, 166);
            this.tbSeverityLevel.Name = "tbSeverityLevel";
            this.tbSeverityLevel.Size = new System.Drawing.Size(100, 22);
            this.tbSeverityLevel.TabIndex = 11;
            // 
            // tbDot
            // 
            this.tbDot.Location = new System.Drawing.Point(183, 138);
            this.tbDot.Name = "tbDot";
            this.tbDot.Size = new System.Drawing.Size(100, 22);
            this.tbDot.TabIndex = 10;
            // 
            // tbSymptoms
            // 
            this.tbSymptoms.Location = new System.Drawing.Point(183, 53);
            this.tbSymptoms.Name = "tbSymptoms";
            this.tbSymptoms.Size = new System.Drawing.Size(100, 22);
            this.tbSymptoms.TabIndex = 7;
            // 
            // tbRecommendedMedicines
            // 
            this.tbRecommendedMedicines.Location = new System.Drawing.Point(183, 110);
            this.tbRecommendedMedicines.Name = "tbRecommendedMedicines";
            this.tbRecommendedMedicines.Size = new System.Drawing.Size(100, 22);
            this.tbRecommendedMedicines.TabIndex = 9;
            // 
            // tbProcedures
            // 
            this.tbProcedures.Location = new System.Drawing.Point(183, 82);
            this.tbProcedures.Name = "tbProcedures";
            this.tbProcedures.Size = new System.Drawing.Size(100, 22);
            this.tbProcedures.TabIndex = 8;
            this.tbProcedures.TextChanged += new System.EventHandler(this.tbUniversity_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Рівень тяжкості (1-10)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тривалість лікування (дн)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Рекомендовані ліки, к-сть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Процедури";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Симптоми";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chbIsContagious
            // 
            this.chbIsContagious.AutoSize = true;
            this.chbIsContagious.Location = new System.Drawing.Point(15, 225);
            this.chbIsContagious.Name = "chbIsContagious";
            this.chbIsContagious.Size = new System.Drawing.Size(144, 20);
            this.chbIsContagious.TabIndex = 1;
            this.chbIsContagious.Text = "Хвороба заразна";
            this.chbIsContagious.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(307, 18);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 37);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(307, 71);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(105, 37);
            this.btnCansel.TabIndex = 14;
            this.btnCansel.Text = "Скасувати";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // tbMortalityRate
            // 
            this.tbMortalityRate.Location = new System.Drawing.Point(183, 197);
            this.tbMortalityRate.Name = "tbMortalityRate";
            this.tbMortalityRate.Size = new System.Drawing.Size(100, 22);
            this.tbMortalityRate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Смертність %";
            // 
            // AddDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 482);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AddDisease";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данні про нового студента";
            this.Load += new System.EventHandler(this.fStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbSeverityLevel;
        private System.Windows.Forms.TextBox tbDot;
        private System.Windows.Forms.TextBox tbRecommendedMedicines;
        private System.Windows.Forms.TextBox tbProcedures;
        private System.Windows.Forms.TextBox tbSymptoms;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox chbIsContagious;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.TextBox tbMortalityRate;
        private System.Windows.Forms.Label label7;
    }
}
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
            this.tbScholarship = new System.Windows.Forms.TextBox();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.tbSymptoms = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbProcedures = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasScholarship = new System.Windows.Forms.CheckBox();
            this.chbHasHostel = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbScholarship);
            this.groupBox1.Controls.Add(this.tbSemester);
            this.groupBox1.Controls.Add(this.tbSymptoms);
            this.groupBox1.Controls.Add(this.tbAge);
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
            this.groupBox1.Size = new System.Drawing.Size(265, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні данні";
            // 
            // tbScholarship
            // 
            this.tbScholarship.Location = new System.Drawing.Point(154, 166);
            this.tbScholarship.Name = "tbScholarship";
            this.tbScholarship.Size = new System.Drawing.Size(100, 22);
            this.tbScholarship.TabIndex = 11;
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(154, 138);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(100, 22);
            this.tbSemester.TabIndex = 10;
            // 
            // tbSymptoms
            // 
            this.tbSymptoms.Location = new System.Drawing.Point(154, 53);
            this.tbSymptoms.Name = "tbSymptoms";
            this.tbSymptoms.Size = new System.Drawing.Size(100, 22);
            this.tbSymptoms.TabIndex = 7;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(154, 110);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 22);
            this.tbAge.TabIndex = 9;
            // 
            // tbProcedures
            // 
            this.tbProcedures.Location = new System.Drawing.Point(154, 82);
            this.tbProcedures.Name = "tbProcedures";
            this.tbProcedures.Size = new System.Drawing.Size(100, 22);
            this.tbProcedures.TabIndex = 8;
            this.tbProcedures.TextChanged += new System.EventHandler(this.tbUniversity_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(154, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Стипендія";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Семестр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вік";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Факультет";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasScholarship);
            this.groupBox2.Controls.Add(this.chbHasHostel);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 108);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Інше";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chbHasScholarship
            // 
            this.chbHasScholarship.AutoSize = true;
            this.chbHasScholarship.Location = new System.Drawing.Point(6, 74);
            this.chbHasScholarship.Name = "chbHasScholarship";
            this.chbHasScholarship.Size = new System.Drawing.Size(213, 20);
            this.chbHasScholarship.TabIndex = 1;
            this.chbHasScholarship.Text = "Студент отримує стипендію";
            this.chbHasScholarship.UseVisualStyleBackColor = true;
            // 
            // chbHasHostel
            // 
            this.chbHasHostel.AutoSize = true;
            this.chbHasHostel.Location = new System.Drawing.Point(6, 36);
            this.chbHasHostel.Name = "chbHasHostel";
            this.chbHasHostel.Size = new System.Drawing.Size(242, 20);
            this.chbHasHostel.TabIndex = 0;
            this.chbHasHostel.Text = "Студент проживає у гуртожитку";
            this.chbHasHostel.UseVisualStyleBackColor = true;
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
            // AddDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 348);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AddDisease";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данні про нового студента";
            this.Load += new System.EventHandler(this.fStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox tbScholarship;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbProcedures;
        private System.Windows.Forms.TextBox tbSymptoms;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasScholarship;
        private System.Windows.Forms.CheckBox chbHasHostel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCansel;
    }
}
namespace Курсач
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsBinary = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromText = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromBinary = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.tbGoMedBase = new System.Windows.Forms.ToolStripButton();
            this.gvDisease = new System.Windows.Forms.DataGridView();
            this.bindSrcDiseases = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Search = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCanselSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCanselFilter = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcDiseases)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.tsSeparator1,
            this.btnDel,
            this.btnClear,
            this.tsSeparator2,
            this.btnSaveAsText,
            this.btnSaveAsBinary,
            this.btnOpenFromText,
            this.btnOpenFromBinary,
            this.btnExit,
            this.tbGoMedBase});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1287, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 24);
            this.btnAdd.Text = "Додати запис про Хворобу";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 28);
            this.btnEdit.Text = "Редагувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.BackColor = System.Drawing.SystemColors.Control;
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(29, 28);
            this.btnDel.Text = "Видалити запис";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(29, 28);
            this.btnClear.Text = "Очистити данні";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsText.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsText.Image")));
            this.btnSaveAsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(29, 28);
            this.btnSaveAsText.Text = "Зберегти у текстовому форматі";
            this.btnSaveAsText.ToolTipText = "Зберегти у текстовому форматі";
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsBinary.Image")));
            this.btnSaveAsBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            this.btnSaveAsBinary.Size = new System.Drawing.Size(29, 28);
            this.btnSaveAsBinary.Text = "Зберегти у бінарному форматі";
            this.btnSaveAsBinary.ToolTipText = "Зберегти у бінарному форматі";
            this.btnSaveAsBinary.Click += new System.EventHandler(this.btnSaveAsBinary_Click);
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromText.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromText.Image")));
            this.btnOpenFromText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Size = new System.Drawing.Size(29, 28);
            this.btnOpenFromText.Text = "Читати текстові дані";
            this.btnOpenFromText.ToolTipText = "Читати текстові дані";
            this.btnOpenFromText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // btnOpenFromBinary
            // 
            this.btnOpenFromBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromBinary.Image")));
            this.btnOpenFromBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromBinary.Name = "btnOpenFromBinary";
            this.btnOpenFromBinary.Size = new System.Drawing.Size(29, 28);
            this.btnOpenFromBinary.Text = "Читати бінарні дані";
            this.btnOpenFromBinary.ToolTipText = "Читати бінарні дані";
            this.btnOpenFromBinary.Click += new System.EventHandler(this.btnOpenFromBinary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(29, 28);
            this.btnExit.Text = "Вийти з програми";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbGoMedBase
            // 
            this.tbGoMedBase.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbGoMedBase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbGoMedBase.Image = ((System.Drawing.Image)(resources.GetObject("tbGoMedBase.Image")));
            this.tbGoMedBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbGoMedBase.Name = "tbGoMedBase";
            this.tbGoMedBase.Size = new System.Drawing.Size(29, 28);
            this.tbGoMedBase.Text = "Перейти до бази медикаментів";
            this.tbGoMedBase.Click += new System.EventHandler(this.tbGoMedBase_Click);
            // 
            // gvDisease
            // 
            this.gvDisease.AllowUserToAddRows = false;
            this.gvDisease.AllowUserToDeleteRows = false;
            this.gvDisease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDisease.AutoGenerateColumns = false;
            this.gvDisease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDisease.DataSource = this.bindSrcDiseases;
            this.gvDisease.Location = new System.Drawing.Point(0, 143);
            this.gvDisease.Name = "gvDisease";
            this.gvDisease.ReadOnly = true;
            this.gvDisease.RowHeadersWidth = 51;
            this.gvDisease.RowTemplate.Height = 24;
            this.gvDisease.Size = new System.Drawing.Size(1287, 393);
            this.gvDisease.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Search);
            this.groupBox1.Location = new System.Drawing.Point(0, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук";
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Location = new System.Drawing.Point(281, 76);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(121, 31);
            this.btnCancelSearch.TabIndex = 4;
            this.btnCancelSearch.Text = "Скасувати";
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(6, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Шукати";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(302, 46);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 22);
            this.tbSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шукати по";
            // 
            // cb_Search
            // 
            this.cb_Search.FormattingEnabled = true;
            this.cb_Search.Items.AddRange(new object[] {
            "Назва",
            "Симптоми",
            "Процедури",
            "Рекомендовані ліки, к-сть"});
            this.cb_Search.Location = new System.Drawing.Point(6, 46);
            this.cb_Search.Name = "cb_Search";
            this.cb_Search.Size = new System.Drawing.Size(243, 24);
            this.cb_Search.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSort);
            this.groupBox4.Controls.Add(this.btnCanselSort);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cbSort);
            this.groupBox4.Location = new System.Drawing.Point(408, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 113);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сортування";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(6, 76);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(121, 31);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Відсортувати";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCanselSort
            // 
            this.btnCanselSort.Location = new System.Drawing.Point(294, 76);
            this.btnCanselSort.Name = "btnCanselSort";
            this.btnCanselSort.Size = new System.Drawing.Size(119, 31);
            this.btnCanselSort.TabIndex = 6;
            this.btnCanselSort.Text = "Скасувати";
            this.btnCanselSort.UseVisualStyleBackColor = true;
            this.btnCanselSort.Click += new System.EventHandler(this.btnCanselSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Відсортувати за";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Назва",
            "Симптоми",
            "Процедури",
            "Рекомендовані ліки, к-сть",
            "Тривалість лікування (дн)",
            "Рівень тяжкості (1-10)",
            "Смертність %"});
            this.cbSort.Location = new System.Drawing.Point(10, 46);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(403, 24);
            this.cbSort.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFilter);
            this.groupBox5.Controls.Add(this.btnCanselFilter);
            this.groupBox5.Controls.Add(this.tbFilter);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cbFilter);
            this.groupBox5.Location = new System.Drawing.Point(838, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(449, 113);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фільтрація";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(6, 76);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 31);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Фільтрувати\r\n";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnCanselFilter
            // 
            this.btnCanselFilter.Location = new System.Drawing.Point(318, 74);
            this.btnCanselFilter.Name = "btnCanselFilter";
            this.btnCanselFilter.Size = new System.Drawing.Size(119, 31);
            this.btnCanselFilter.TabIndex = 8;
            this.btnCanselFilter.Text = "Скасувати";
            this.btnCanselFilter.UseVisualStyleBackColor = true;
            this.btnCanselFilter.Click += new System.EventHandler(this.btnCanselFilter_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(337, 46);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(100, 22);
            this.tbFilter.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Рівень тяжкості";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Вищий за",
            "Нижчий за"});
            this.cbFilter.Location = new System.Drawing.Point(10, 46);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(260, 24);
            this.cbFilter.TabIndex = 0;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1287, 535);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvDisease);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMBase";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcDiseases)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.BindingSource bindSrcDiseases;
        private System.Windows.Forms.DataGridView gvDisease;
        private System.Windows.Forms.ToolStripButton btnSaveAsText;
        private System.Windows.Forms.ToolStripButton btnSaveAsBinary;
        private System.Windows.Forms.ToolStripButton btnOpenFromText;
        private System.Windows.Forms.ToolStripButton btnOpenFromBinary;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton tbGoMedBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cb_Search;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnCanselSort;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCanselFilter;
        private System.Windows.Forms.TextBox tbFilter;
    }
}


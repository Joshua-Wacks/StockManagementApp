namespace StockManagementApp.src.views
{
    partial class BrandCategoryLedgerTypeForm
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            btnAddBrand = new Button();
            txtBrandName = new TextBox();
            label1 = new Label();
            tabPage1 = new TabPage();
            btnAddCategory = new Button();
            txtCategoryName = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            btnLedgerType = new Button();
            txtLedgerTypeName = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(34, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(465, 306);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAddBrand);
            tabPage2.Controls.Add(txtBrandName);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(457, 273);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "BRAND";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddBrand
            // 
            btnAddBrand.Location = new Point(186, 152);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(170, 29);
            btnAddBrand.TabIndex = 2;
            btnAddBrand.Text = "Add Brand";
            btnAddBrand.UseVisualStyleBackColor = true;
            btnAddBrand.Click += btnAddBrand_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(231, 79);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(125, 27);
            txtBrandName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 79);
            label1.Name = "label1";
            label1.Size = new Size(203, 31);
            label1.TabIndex = 0;
            label1.Text = "Enter brand name:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAddCategory);
            tabPage1.Controls.Add(txtCategoryName);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(457, 273);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "CATEGORY";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(193, 139);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(170, 29);
            btnAddCategory.TabIndex = 5;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(238, 73);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(125, 27);
            txtCategoryName.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 73);
            label2.Name = "label2";
            label2.Size = new Size(203, 31);
            label2.TabIndex = 3;
            label2.Text = "Enter category name:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnLedgerType);
            tabPage3.Controls.Add(txtLedgerTypeName);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(457, 273);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "LEDGERTYPE";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnLedgerType
            // 
            btnLedgerType.Location = new Point(224, 102);
            btnLedgerType.Name = "btnLedgerType";
            btnLedgerType.Size = new Size(170, 29);
            btnLedgerType.TabIndex = 8;
            btnLedgerType.Text = "Add LedgerType";
            btnLedgerType.UseVisualStyleBackColor = true;
            btnLedgerType.Click += btnLedgerType_Click;
            // 
            // txtLedgerTypeName
            // 
            txtLedgerTypeName.Location = new Point(269, 37);
            txtLedgerTypeName.Name = "txtLedgerTypeName";
            txtLedgerTypeName.Size = new Size(125, 27);
            txtLedgerTypeName.TabIndex = 7;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 37);
            label3.Name = "label3";
            label3.Size = new Size(241, 31);
            label3.TabIndex = 6;
            label3.Text = "Enter LedgerType name:";
            // 
            // BrandCategoryLedgerTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 382);
            Controls.Add(tabControl1);
            Name = "BrandCategoryLedgerTypeForm";
            Text = "Insert";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Button btnAddBrand;
        private TextBox txtBrandName;
        private Label label1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Button btnAddCategory;
        private TextBox txtCategoryName;
        private Label label2;
        private Button btnLedgerType;
        private TextBox txtLedgerTypeName;
        private Label label3;
    }
}
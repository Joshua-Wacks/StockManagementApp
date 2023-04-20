namespace StockManagementApp.src.views
{
    partial class Input
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
            label1 = new Label();
            comboBoxBrand = new ComboBox();
            label2 = new Label();
            comboBoxCategories = new ComboBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label4 = new Label();
            comboBoxAction = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Brand";
            label1.Click += label1_Click;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Items.AddRange(new object[] { "Nestle", "Kraft Heinz", "General Mills", "Kellogg's", "Coca-Cola", "Adidas", "Levis", "Ralph Lauren", "Vans", "Tommy Hilfiger", "Apple", "Samsung" });
            comboBoxBrand.Location = new Point(34, 32);
            comboBoxBrand.MaxDropDownItems = 15;
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(185, 28);
            comboBoxBrand.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Categories";
            label2.Click += label2_Click;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Items.AddRange(new object[] { "Food", "Clothes", "Electronics" });
            comboBoxCategories.Location = new Point(34, 102);
            comboBoxCategories.MaxDropDownItems = 5;
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(185, 28);
            comboBoxCategories.TabIndex = 3;
            comboBoxCategories.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 154);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(34, 177);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(185, 27);
            textBoxName.TabIndex = 5;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 224);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "Action";
            // 
            // comboBoxAction
            // 
            comboBoxAction.FormattingEnabled = true;
            comboBoxAction.Location = new Point(34, 247);
            comboBoxAction.Name = "comboBoxAction";
            comboBoxAction.Size = new Size(185, 28);
            comboBoxAction.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(34, 306);
            button1.Name = "button1";
            button1.Size = new Size(185, 65);
            button1.TabIndex = 8;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // Input
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBoxAction);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(comboBoxCategories);
            Controls.Add(label2);
            Controls.Add(comboBoxBrand);
            Controls.Add(label1);
            Name = "Input";
            Text = "Input";
            Load += Input_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxBrand;
        private Label label2;
        private ComboBox comboBoxCategories;
        private Label label3;
        private TextBox textBoxName;
        private Label label4;
        private ComboBox comboBoxAction;
        private Button button1;
    }
}
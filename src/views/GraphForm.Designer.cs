namespace StockManagementApp
{
    partial class GraphForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formsPlot = new ScottPlot.FormsPlot();
            this.label1 = new System.Windows.Forms.Label();
            this.viewGraphBtn = new System.Windows.Forms.Button();
            this.comboBoxOverall = new System.Windows.Forms.ComboBox();
            this.comboBoxLedgerType = new System.Windows.Forms.ComboBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // formsPlot
            // 
            this.formsPlot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formsPlot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.formsPlot.Location = new System.Drawing.Point(41, 69);
            this.formsPlot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot.Name = "formsPlot";
            this.formsPlot.Size = new System.Drawing.Size(719, 573);
            this.formsPlot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Graph Stock View";
            // 
            // viewGraphBtn
            // 
            this.viewGraphBtn.Location = new System.Drawing.Point(784, 493);
            this.viewGraphBtn.Name = "viewGraphBtn";
            this.viewGraphBtn.Size = new System.Drawing.Size(239, 48);
            this.viewGraphBtn.TabIndex = 4;
            this.viewGraphBtn.Text = "View";
            this.viewGraphBtn.UseVisualStyleBackColor = true;
            this.viewGraphBtn.Click += new System.EventHandler(this.viewGraphBtn_Click);
            // 
            // comboBoxOverall
            // 
            this.comboBoxOverall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOverall.FormattingEnabled = true;
            this.comboBoxOverall.Items.AddRange(new object[] {
            "All Items",
            "By Brand",
            "By Category"});
            this.comboBoxOverall.Location = new System.Drawing.Point(795, 185);
            this.comboBoxOverall.Name = "comboBoxOverall";
            this.comboBoxOverall.Size = new System.Drawing.Size(209, 23);
            this.comboBoxOverall.TabIndex = 5;
            // 
            // comboBoxLedgerType
            // 
            this.comboBoxLedgerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLedgerType.FormattingEnabled = true;
            this.comboBoxLedgerType.Items.AddRange(new object[] {
            "Sales",
            "Returns",
            "Restocks",
            "Broken"});
            this.comboBoxLedgerType.Location = new System.Drawing.Point(795, 277);
            this.comboBoxLedgerType.Name = "comboBoxLedgerType";
            this.comboBoxLedgerType.Size = new System.Drawing.Size(209, 23);
            this.comboBoxLedgerType.TabIndex = 6;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "Yearly",
            "Monthly"});
            this.comboBoxTime.Location = new System.Drawing.Point(795, 389);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(209, 23);
            this.comboBoxTime.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(833, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Items to View";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(864, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(848, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Timeframe";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(767, 123);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 11;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 715);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.comboBoxLedgerType);
            this.Controls.Add(this.comboBoxOverall);
            this.Controls.Add(this.viewGraphBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formsPlot);
            this.Name = "GraphForm";
            this.Text = "Graph View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot;
        private Label label1;
        private Button viewGraphBtn;
        private ComboBox comboBoxOverall;
        private ComboBox comboBoxLedgerType;
        private ComboBox comboBoxTime;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckedListBox checkedListBox1;
    }
}
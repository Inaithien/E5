namespace gestion
{
    partial class fAdmin
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
            tbAdmin = new TabControl();
            tpAccount = new TabPage();
            tbFood = new TabPage();
            tpCategory = new TabPage();
            tpTable = new TabPage();
            tbBill = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            dtgvBill = new DataGridView();
            dtpkFrom = new DateTimePicker();
            dtpkToday = new DateTimePicker();
            btnViewBill = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            tbAdmin.SuspendLayout();
            tbFood.SuspendLayout();
            tbBill.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tbAdmin
            // 
            tbAdmin.Controls.Add(tpAccount);
            tbAdmin.Controls.Add(tbFood);
            tbAdmin.Controls.Add(tpCategory);
            tbAdmin.Controls.Add(tpTable);
            tbAdmin.Controls.Add(tbBill);
            tbAdmin.Location = new Point(12, 12);
            tbAdmin.Name = "tbAdmin";
            tbAdmin.SelectedIndex = 0;
            tbAdmin.Size = new Size(776, 470);
            tbAdmin.TabIndex = 0;
            // 
            // tpAccount
            // 
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(768, 437);
            tpAccount.TabIndex = 0;
            tpAccount.Text = "Account";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // tbFood
            // 
            tbFood.Controls.Add(panel6);
            tbFood.Controls.Add(panel5);
            tbFood.Controls.Add(panel4);
            tbFood.Controls.Add(panel3);
            tbFood.Location = new Point(4, 29);
            tbFood.Name = "tbFood";
            tbFood.Padding = new Padding(3);
            tbFood.Size = new Size(768, 437);
            tbFood.TabIndex = 1;
            tbFood.Text = "Food";
            tbFood.UseVisualStyleBackColor = true;
            // 
            // tpCategory
            // 
            tpCategory.Location = new Point(4, 29);
            tpCategory.Name = "tpCategory";
            tpCategory.Padding = new Padding(3);
            tpCategory.Size = new Size(768, 437);
            tpCategory.TabIndex = 2;
            tpCategory.Text = "Category";
            tpCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(768, 437);
            tpTable.TabIndex = 3;
            tpTable.Text = "Table";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // tbBill
            // 
            tbBill.Controls.Add(panel2);
            tbBill.Controls.Add(panel1);
            tbBill.Location = new Point(4, 29);
            tbBill.Name = "tbBill";
            tbBill.Padding = new Padding(3);
            tbBill.Size = new Size(768, 437);
            tbBill.TabIndex = 4;
            tbBill.Text = "Bill";
            tbBill.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(6, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 374);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewBill);
            panel2.Controls.Add(dtpkToday);
            panel2.Controls.Add(dtpkFrom);
            panel2.Location = new Point(6, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 36);
            panel2.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 16);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.RowTemplate.Height = 29;
            dtgvBill.Size = new Size(759, 361);
            dtgvBill.TabIndex = 0;
            // 
            // dtpkFrom
            // 
            dtpkFrom.Location = new Point(3, 0);
            dtpkFrom.Name = "dtpkFrom";
            dtpkFrom.Size = new Size(250, 27);
            dtpkFrom.TabIndex = 0;
            // 
            // dtpkToday
            // 
            dtpkToday.Location = new Point(503, 0);
            dtpkToday.Name = "dtpkToday";
            dtpkToday.Size = new Size(250, 27);
            dtpkToday.TabIndex = 1;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(326, 4);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(118, 29);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Show Bill";
            btnViewBill.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Location = new Point(6, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 328);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(9, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(391, 78);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Location = new Point(406, 103);
            panel5.Name = "panel5";
            panel5.Size = new Size(356, 328);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(button5);
            panel6.Location = new Point(406, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(356, 78);
            panel6.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(89, 72);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(98, 3);
            button2.Name = "button2";
            button2.Size = new Size(85, 72);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(189, 3);
            button3.Name = "button3";
            button3.Size = new Size(86, 72);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(281, 3);
            button4.Name = "button4";
            button4.Size = new Size(83, 72);
            button4.TabIndex = 1;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 3);
            button5.Name = "button5";
            button5.Size = new Size(69, 72);
            button5.TabIndex = 2;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 0;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(tbAdmin);
            Name = "fAdmin";
            Text = "Admin";
            tbAdmin.ResumeLayout(false);
            tbFood.ResumeLayout(false);
            tbBill.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbAdmin;
        private TabPage tpAccount;
        private TabPage tbFood;
        private TabPage tpCategory;
        private TabPage tpTable;
        private TabPage tbBill;
        private Panel panel2;
        private Button btnViewBill;
        private DateTimePicker dtpkToday;
        private DateTimePicker dtpkFrom;
        private Panel panel1;
        private DataGridView dtgvBill;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
    }
}
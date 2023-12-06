namespace gestion
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            admoToolStripMenuItem = new ToolStripMenuItem();
            detailDeCompteToolStripMenuItem = new ToolStripMenuItem();
            informationPersonelToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            listView1 = new ListView();
            panel3 = new Panel();
            comboBox2 = new ComboBox();
            btnSwitchTable = new Button();
            nmdiscount = new NumericUpDown();
            btndiscount = new Button();
            btnpay = new Button();
            panel4 = new Panel();
            nmAddFood = new NumericUpDown();
            btnAddFood = new Button();
            comboBox1 = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmAddFood).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { admoToolStripMenuItem, detailDeCompteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1205, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // admoToolStripMenuItem
            // 
            admoToolStripMenuItem.Name = "admoToolStripMenuItem";
            admoToolStripMenuItem.Size = new Size(65, 24);
            admoToolStripMenuItem.Text = "admin";
            admoToolStripMenuItem.Click += admoToolStripMenuItem_Click;
            // 
            // detailDeCompteToolStripMenuItem
            // 
            detailDeCompteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informationPersonelToolStripMenuItem, logoutToolStripMenuItem });
            detailDeCompteToolStripMenuItem.Name = "detailDeCompteToolStripMenuItem";
            detailDeCompteToolStripMenuItem.Size = new Size(137, 24);
            detailDeCompteToolStripMenuItem.Text = "detail de compte";
            // 
            // informationPersonelToolStripMenuItem
            // 
            informationPersonelToolStripMenuItem.Name = "informationPersonelToolStripMenuItem";
            informationPersonelToolStripMenuItem.Size = new Size(231, 26);
            informationPersonelToolStripMenuItem.Text = "information personel";
            informationPersonelToolStripMenuItem.Click += informationPersonelToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(231, 26);
            logoutToolStripMenuItem.Text = "logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(711, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 309);
            panel2.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 7);
            listView1.Name = "listView1";
            listView1.Size = new Size(471, 289);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmdiscount);
            panel3.Controls.Add(btndiscount);
            panel3.Controls.Add(btnpay);
            panel3.Location = new Point(711, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(482, 81);
            panel3.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(0, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(93, 28);
            comboBox2.TabIndex = 6;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(3, 6);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(90, 29);
            btnSwitchTable.TabIndex = 5;
            btnSwitchTable.Text = "Changer ";
            btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nmdiscount
            // 
            nmdiscount.Location = new Point(134, 44);
            nmdiscount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmdiscount.Name = "nmdiscount";
            nmdiscount.Size = new Size(90, 27);
            nmdiscount.TabIndex = 3;
            // 
            // btndiscount
            // 
            btndiscount.Location = new Point(134, 6);
            btndiscount.Name = "btndiscount";
            btndiscount.Size = new Size(90, 32);
            btndiscount.TabIndex = 4;
            btndiscount.Text = "Discount";
            btndiscount.UseVisualStyleBackColor = true;
            // 
            // btnpay
            // 
            btnpay.Location = new Point(384, 6);
            btnpay.Name = "btnpay";
            btnpay.Size = new Size(83, 75);
            btnpay.TabIndex = 3;
            btnpay.Text = "Encaisser";
            btnpay.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmAddFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(711, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(482, 81);
            panel4.TabIndex = 4;
            // 
            // nmAddFood
            // 
            nmAddFood.Location = new Point(384, 50);
            nmAddFood.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmAddFood.Name = "nmAddFood";
            nmAddFood.Size = new Size(92, 27);
            nmAddFood.TabIndex = 0;
            nmAddFood.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(295, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(83, 75);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Ajouter";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 28);
            comboBox1.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(286, 28);
            cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(12, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(693, 494);
            flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 527);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            Text = "Manage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmdiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmAddFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem admoToolStripMenuItem;
        private ToolStripMenuItem detailDeCompteToolStripMenuItem;
        private ToolStripMenuItem informationPersonelToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown nmAddFood;
        private Button btnAddFood;
        private ComboBox comboBox1;
        private ComboBox cbCategory;
        private ListView listView1;
        private NumericUpDown nmdiscount;
        private Button btndiscount;
        private Button btnpay;
        private FlowLayoutPanel flpTable;
        private ComboBox comboBox2;
        private Button btnSwitchTable;
    }
}
namespace gestion
{
    partial class fLogin
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
            panel1 = new Panel();
            btnexit = new Button();
            btnlogin = new Button();
            panel3 = new Panel();
            txbpassword = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbusername = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnexit);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 193);
            panel1.TabIndex = 0;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(313, 156);
            btnexit.Margin = new Padding(3, 4, 3, 4);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(86, 31);
            btnexit.TabIndex = 3;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(90, 156);
            btnlogin.Margin = new Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(86, 31);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbpassword);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 91);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 57);
            panel3.TabIndex = 1;
            // 
            // txbpassword
            // 
            txbpassword.Location = new Point(87, 13);
            txbpassword.Margin = new Padding(3, 4, 3, 4);
            txbpassword.Name = "txbpassword";
            txbpassword.Size = new Size(308, 27);
            txbpassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbusername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 57);
            panel2.TabIndex = 0;
            // 
            // txbusername
            // 
            txbusername.Location = new Point(87, 13);
            txbusername.Margin = new Padding(3, 4, 3, 4);
            txbusername.Name = "txbusername";
            txbusername.Size = new Size(308, 27);
            txbusername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Identifiant :";
            // 
            // fLogin
            // 
            AcceptButton = btnlogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnexit;
            ClientSize = new Size(433, 213);
            Controls.Add(panel1);
            Name = "fLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txbpassword;
        private Label label2;
        private Panel panel2;
        private TextBox txbusername;
        private Label label1;
        private Button btnexit;
        private Button btnlogin;
    }
}
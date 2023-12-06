namespace gestion
{
    partial class fAccountProfile
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
            panel2 = new Panel();
            txbusername = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassword = new TextBox();
            lable3 = new Label();
            panel4 = new Panel();
            txbNewPassword = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            txbReenter = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbusername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 57);
            panel2.TabIndex = 1;
            // 
            // txbusername
            // 
            txbusername.Location = new Point(187, 10);
            txbusername.Margin = new Padding(3, 4, 3, 4);
            txbusername.Name = "txbusername";
            txbusername.ReadOnly = true;
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
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(8, 94);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 57);
            panel1.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(191, 14);
            txbDisplayName.Margin = new Padding(3, 4, 3, 4);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(308, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Nom :";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassword);
            panel3.Controls.Add(lable3);
            panel3.Location = new Point(8, 168);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(502, 57);
            panel3.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(191, 14);
            txbPassword.Margin = new Padding(3, 4, 3, 4);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(308, 27);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // lable3
            // 
            lable3.AutoSize = true;
            lable3.Location = new Point(3, 17);
            lable3.Name = "lable3";
            lable3.Size = new Size(77, 20);
            lable3.TabIndex = 1;
            lable3.Text = "Password :";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPassword);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(8, 245);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(502, 57);
            panel4.TabIndex = 4;
            // 
            // txbNewPassword
            // 
            txbNewPassword.Location = new Point(191, 17);
            txbNewPassword.Margin = new Padding(3, 4, 3, 4);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(308, 27);
            txbNewPassword.TabIndex = 1;
            txbNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 1;
            label3.Text = "New Password :";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReenter);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(8, 320);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(502, 57);
            panel5.TabIndex = 5;
            // 
            // txbReenter
            // 
            txbReenter.Location = new Point(191, 17);
            txbReenter.Margin = new Padding(3, 4, 3, 4);
            txbReenter.Name = "txbReenter";
            txbReenter.Size = new Size(308, 27);
            txbReenter.TabIndex = 1;
            txbReenter.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 1;
            label4.Text = "Confirmer Password :";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(230, 384);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(395, 384);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(522, 428);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            Text = "Profile";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbusername;
        private Label label1;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassword;
        private Label lable3;
        private Panel panel4;
        private TextBox txbNewPassword;
        private Label label3;
        private Panel panel5;
        private TextBox txbReenter;
        private Label label4;
        private Button btnUpdate;
        private Button btnExit;
    }
}
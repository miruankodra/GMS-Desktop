namespace GMS
{
    partial class LoginForm
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.regLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.forgotPass = new System.Windows.Forms.LinkLabel();
            this.password = new System.Windows.Forms.TextBox();
            this.usename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1100, 159);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 159);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 357);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(858, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 357);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.regLink);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.loginBtn);
            this.panel4.Controls.Add(this.forgotPass);
            this.panel4.Controls.Add(this.password);
            this.panel4.Controls.Add(this.usename);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(242, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(616, 357);
            this.panel4.TabIndex = 4;
            // 
            // regLink
            // 
            this.regLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regLink.AutoSize = true;
            this.regLink.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLink.Location = new System.Drawing.Point(408, 284);
            this.regLink.Name = "regLink";
            this.regLink.Size = new System.Drawing.Size(72, 21);
            this.regLink.TabIndex = 5;
            this.regLink.TabStop = true;
            this.regLink.Text = "Register";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "If you dont have an account";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(257, 229);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(110, 43);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // forgotPass
            // 
            this.forgotPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPass.AutoSize = true;
            this.forgotPass.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPass.Location = new System.Drawing.Point(207, 196);
            this.forgotPass.Name = "forgotPass";
            this.forgotPass.Size = new System.Drawing.Size(145, 21);
            this.forgotPass.TabIndex = 3;
            this.forgotPass.TabStop = true;
            this.forgotPass.Text = "Forgot Password?";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(210, 141);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(210, 43);
            this.password.TabIndex = 2;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usename
            // 
            this.usename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usename.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usename.Location = new System.Drawing.Point(210, 82);
            this.usename.Multiline = true;
            this.usename.Name = "usename";
            this.usename.Size = new System.Drawing.Size(210, 43);
            this.usename.TabIndex = 1;
            this.usename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "GMS";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginPanel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel forgotPass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox usename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel regLink;
    }
}
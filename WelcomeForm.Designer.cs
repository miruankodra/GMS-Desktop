namespace GMS
{
    partial class WelcomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GMS = new System.Windows.Forms.Label();
            this.bigLogo = new System.Windows.Forms.PictureBox();
            this.signupCaller = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginFormCaller = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1000, 700);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 550);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loginFormCaller);
            this.panel2.Controls.Add(this.signupCaller);
            this.panel2.Location = new System.Drawing.Point(683, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 682);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 682);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.panel4.Controls.Add(this.GMS);
            this.panel4.Controls.Add(this.bigLogo);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1183, 682);
            this.panel4.TabIndex = 9;
            // 
            // GMS
            // 
            this.GMS.AutoSize = true;
            this.GMS.Font = new System.Drawing.Font("Montserrat Alternates", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GMS.Location = new System.Drawing.Point(156, 528);
            this.GMS.Name = "GMS";
            this.GMS.Size = new System.Drawing.Size(258, 111);
            this.GMS.TabIndex = 9;
            this.GMS.Text = "GMS";
            this.GMS.Click += new System.EventHandler(this.GMS_Click);
            // 
            // bigLogo
            // 
            this.bigLogo.Image = global::GMS.Properties.Resources.bitmap;
            this.bigLogo.Location = new System.Drawing.Point(36, 25);
            this.bigLogo.Name = "bigLogo";
            this.bigLogo.Size = new System.Drawing.Size(500, 500);
            this.bigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bigLogo.TabIndex = 8;
            this.bigLogo.TabStop = false;
            // 
            // signupCaller
            // 
            this.signupCaller.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.signupCaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.signupCaller.FlatAppearance.BorderSize = 0;
            this.signupCaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupCaller.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupCaller.ForeColor = System.Drawing.Color.White;
            this.signupCaller.Location = new System.Drawing.Point(118, 380);
            this.signupCaller.Name = "signupCaller";
            this.signupCaller.Size = new System.Drawing.Size(287, 57);
            this.signupCaller.TabIndex = 7;
            this.signupCaller.Text = "SignUp";
            this.signupCaller.UseVisualStyleBackColor = false;
            this.signupCaller.Click += new System.EventHandler(this.signupCaller_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(850, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Member";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Already Member";
            // 
            // loginFormCaller
            // 
            this.loginFormCaller.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginFormCaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.loginFormCaller.FlatAppearance.BorderSize = 0;
            this.loginFormCaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginFormCaller.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormCaller.ForeColor = System.Drawing.Color.White;
            this.loginFormCaller.Location = new System.Drawing.Point(118, 184);
            this.loginFormCaller.Name = "loginFormCaller";
            this.loginFormCaller.Size = new System.Drawing.Size(287, 57);
            this.loginFormCaller.TabIndex = 4;
            this.loginFormCaller.Text = "LogIn";
            this.loginFormCaller.UseVisualStyleBackColor = true;
            this.loginFormCaller.Click += new System.EventHandler(this.loginFormCaller_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 682);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1201, 729);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox bigLogo;
        private System.Windows.Forms.Button signupCaller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loginFormCaller;
        private System.Windows.Forms.Label GMS;
    }
}
namespace GMS
{
    partial class ResetPassword
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
            this.resetpass = new System.Windows.Forms.Label();
            this.emailsender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resetpass
            // 
            this.resetpass.AutoSize = true;
            this.resetpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpass.Location = new System.Drawing.Point(176, 28);
            this.resetpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resetpass.Name = "resetpass";
            this.resetpass.Size = new System.Drawing.Size(185, 26);
            this.resetpass.TabIndex = 0;
            this.resetpass.Text = "Reset Password";
            // 
            // emailsender
            // 
            this.emailsender.AutoSize = true;
            this.emailsender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailsender.ForeColor = System.Drawing.SystemColors.Control;
            this.emailsender.Location = new System.Drawing.Point(72, 91);
            this.emailsender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailsender.Name = "emailsender";
            this.emailsender.Size = new System.Drawing.Size(154, 24);
            this.emailsender.TabIndex = 2;
            this.emailsender.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm Password:";
            // 
            // reset
            // 
            this.reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reset.Location = new System.Drawing.Point(326, 296);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(144, 41);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // newpassword
            // 
            this.newpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword.Location = new System.Drawing.Point(232, 91);
            this.newpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(194, 26);
            this.newpassword.TabIndex = 7;
            // 
            // confirmpassword
            // 
            this.confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassword.Location = new System.Drawing.Point(232, 185);
            this.confirmpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(194, 26);
            this.confirmpassword.TabIndex = 8;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(498, 367);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailsender);
            this.Controls.Add(this.resetpass);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resetpass;
        private System.Windows.Forms.Label emailsender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.TextBox confirmpassword;
    }
}
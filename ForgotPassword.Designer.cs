namespace GMS
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.emailsender = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sendcode = new System.Windows.Forms.Button();
            this.verify = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(98, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            // 
            // emailsender
            // 
            this.emailsender.AutoSize = true;
            this.emailsender.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailsender.ForeColor = System.Drawing.SystemColors.Control;
            this.emailsender.Location = new System.Drawing.Point(150, 145);
            this.emailsender.Name = "emailsender";
            this.emailsender.Size = new System.Drawing.Size(161, 32);
            this.emailsender.TabIndex = 1;
            this.emailsender.Text = "Enter Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(150, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Code:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(105, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 32);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Montserrat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(105, 467);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 32);
            this.textBox2.TabIndex = 4;
            // 
            // sendcode
            // 
            this.sendcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.sendcode.FlatAppearance.BorderSize = 0;
            this.sendcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendcode.Location = new System.Drawing.Point(138, 251);
            this.sendcode.Margin = new System.Windows.Forms.Padding(5);
            this.sendcode.Name = "sendcode";
            this.sendcode.Size = new System.Drawing.Size(192, 50);
            this.sendcode.TabIndex = 5;
            this.sendcode.Text = "Send Code";
            this.sendcode.UseVisualStyleBackColor = false;
            this.sendcode.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // verify
            // 
            this.verify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.verify.FlatAppearance.BorderSize = 0;
            this.verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.verify.Location = new System.Drawing.Point(138, 529);
            this.verify.Margin = new System.Windows.Forms.Padding(5);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(192, 50);
            this.verify.TabIndex = 6;
            this.verify.Text = "Verify";
            this.verify.UseVisualStyleBackColor = false;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 401);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(482, 674);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.sendcode);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailsender);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailsender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sendcode;
        private System.Windows.Forms.Button verify;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
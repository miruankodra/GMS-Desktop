namespace GMS
{
    partial class RegisterForm
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
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.GmsLogo = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.LatNameText = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.PaswordText = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.ConfirmText = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Prefixtext = new System.Windows.Forms.TextBox();
            this.TelText = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Choose = new System.Windows.Forms.ListBox();
            this.CityList = new System.Windows.Forms.ListBox();
            this.DateTimeChoose = new System.Windows.Forms.DateTimePicker();
            this.TermsServices = new System.Windows.Forms.Label();
            this.TermsServicesBox = new System.Windows.Forms.CheckBox();
            this.TermsServicesLink = new System.Windows.Forms.LinkLabel();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.PanelLogo.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.GmsLogo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(982, 100);
            this.PanelLogo.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ConfirmText);
            this.LeftPanel.Controls.Add(this.ConfirmPassword);
            this.LeftPanel.Controls.Add(this.PaswordText);
            this.LeftPanel.Controls.Add(this.Password);
            this.LeftPanel.Controls.Add(this.LatNameText);
            this.LeftPanel.Controls.Add(this.LastName);
            this.LeftPanel.Controls.Add(this.EmailText);
            this.LeftPanel.Controls.Add(this.Email);
            this.LeftPanel.Controls.Add(this.FirstNameText);
            this.LeftPanel.Controls.Add(this.FirstName);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 100);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(484, 553);
            this.LeftPanel.TabIndex = 1;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.SignUpButton);
            this.RightPanel.Controls.Add(this.TermsServicesLink);
            this.RightPanel.Controls.Add(this.TermsServicesBox);
            this.RightPanel.Controls.Add(this.TermsServices);
            this.RightPanel.Controls.Add(this.DateTimeChoose);
            this.RightPanel.Controls.Add(this.CityList);
            this.RightPanel.Controls.Add(this.Choose);
            this.RightPanel.Controls.Add(this.Birthday);
            this.RightPanel.Controls.Add(this.City);
            this.RightPanel.Controls.Add(this.Country);
            this.RightPanel.Controls.Add(this.TelText);
            this.RightPanel.Controls.Add(this.Prefixtext);
            this.RightPanel.Controls.Add(this.PhoneNumber);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(490, 100);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(492, 553);
            this.RightPanel.TabIndex = 2;
            this.RightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RightPanel_Paint);
            // 
            // GmsLogo
            // 
            this.GmsLogo.AutoSize = true;
            this.GmsLogo.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmsLogo.Location = new System.Drawing.Point(404, 29);
            this.GmsLogo.Name = "GmsLogo";
            this.GmsLogo.Size = new System.Drawing.Size(119, 55);
            this.GmsLogo.TabIndex = 0;
            this.GmsLogo.Text = "GMS";
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.ForeColor = System.Drawing.Color.DimGray;
            this.EmailText.Location = new System.Drawing.Point(199, 118);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(186, 34);
            this.EmailText.TabIndex = 8;
            this.EmailText.Text = "Text...";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(63, 120);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(79, 32);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameText.ForeColor = System.Drawing.Color.DimGray;
            this.FirstNameText.Location = new System.Drawing.Point(199, 29);
            this.FirstNameText.Multiline = true;
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(186, 34);
            this.FirstNameText.TabIndex = 6;
            this.FirstNameText.Text = "Text...";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(37, 29);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(141, 32);
            this.FirstName.TabIndex = 5;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(37, 208);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(133, 32);
            this.LastName.TabIndex = 9;
            this.LastName.Text = "LastName";
            // 
            // LatNameText
            // 
            this.LatNameText.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatNameText.ForeColor = System.Drawing.Color.DimGray;
            this.LatNameText.Location = new System.Drawing.Point(199, 211);
            this.LatNameText.Multiline = true;
            this.LatNameText.Name = "LatNameText";
            this.LatNameText.Size = new System.Drawing.Size(186, 34);
            this.LatNameText.TabIndex = 10;
            this.LatNameText.Text = "Text...";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(37, 292);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(126, 32);
            this.Password.TabIndex = 11;
            this.Password.Text = "Password";
            // 
            // PaswordText
            // 
            this.PaswordText.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaswordText.ForeColor = System.Drawing.Color.DimGray;
            this.PaswordText.Location = new System.Drawing.Point(199, 295);
            this.PaswordText.Multiline = true;
            this.PaswordText.Name = "PaswordText";
            this.PaswordText.Size = new System.Drawing.Size(186, 34);
            this.PaswordText.TabIndex = 12;
            this.PaswordText.Text = "Text...";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(50, 375);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(113, 32);
            this.ConfirmPassword.TabIndex = 13;
            this.ConfirmPassword.Text = "Confirm ";
            // 
            // ConfirmText
            // 
            this.ConfirmText.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmText.ForeColor = System.Drawing.Color.DimGray;
            this.ConfirmText.Location = new System.Drawing.Point(199, 378);
            this.ConfirmText.Multiline = true;
            this.ConfirmText.Name = "ConfirmText";
            this.ConfirmText.Size = new System.Drawing.Size(186, 34);
            this.ConfirmText.TabIndex = 14;
            this.ConfirmText.Text = "Text...";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(3, 26);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(194, 32);
            this.PhoneNumber.TabIndex = 6;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // Prefixtext
            // 
            this.Prefixtext.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prefixtext.ForeColor = System.Drawing.Color.DimGray;
            this.Prefixtext.Location = new System.Drawing.Point(214, 27);
            this.Prefixtext.Multiline = true;
            this.Prefixtext.Name = "Prefixtext";
            this.Prefixtext.Size = new System.Drawing.Size(64, 34);
            this.Prefixtext.TabIndex = 7;
            this.Prefixtext.Text = "+";
            // 
            // TelText
            // 
            this.TelText.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelText.ForeColor = System.Drawing.Color.DimGray;
            this.TelText.Location = new System.Drawing.Point(294, 27);
            this.TelText.Multiline = true;
            this.TelText.Name = "TelText";
            this.TelText.Size = new System.Drawing.Size(186, 34);
            this.TelText.TabIndex = 8;
            this.TelText.Text = "Number";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.Location = new System.Drawing.Point(26, 120);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(105, 32);
            this.Country.TabIndex = 9;
            this.Country.Text = "Country";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(55, 208);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(58, 32);
            this.City.TabIndex = 11;
            this.City.Text = "City";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.Location = new System.Drawing.Point(35, 297);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(113, 32);
            this.Birthday.TabIndex = 13;
            this.Birthday.Text = "Birthday";
            // 
            // Choose
            // 
            this.Choose.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Choose.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose.ForeColor = System.Drawing.Color.DimGray;
            this.Choose.FormattingEnabled = true;
            this.Choose.ItemHeight = 25;
            this.Choose.Location = new System.Drawing.Point(184, 120);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(186, 29);
            this.Choose.TabIndex = 15;
            // 
            // CityList
            // 
            this.CityList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CityList.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityList.ForeColor = System.Drawing.Color.DimGray;
            this.CityList.FormattingEnabled = true;
            this.CityList.ItemHeight = 25;
            this.CityList.Location = new System.Drawing.Point(184, 208);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(186, 29);
            this.CityList.TabIndex = 16;
            // 
            // DateTimeChoose
            // 
            this.DateTimeChoose.Location = new System.Drawing.Point(184, 307);
            this.DateTimeChoose.Name = "DateTimeChoose";
            this.DateTimeChoose.Size = new System.Drawing.Size(186, 22);
            this.DateTimeChoose.TabIndex = 17;
            // 
            // TermsServices
            // 
            this.TermsServices.AutoSize = true;
            this.TermsServices.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermsServices.Location = new System.Drawing.Point(28, 391);
            this.TermsServices.Name = "TermsServices";
            this.TermsServices.Size = new System.Drawing.Size(262, 21);
            this.TermsServices.TabIndex = 18;
            this.TermsServices.Text = "I Agree with the Terms of Services";
            this.TermsServices.Click += new System.EventHandler(this.TermsServices_Click);
            // 
            // TermsServicesBox
            // 
            this.TermsServicesBox.AutoSize = true;
            this.TermsServicesBox.Location = new System.Drawing.Point(313, 395);
            this.TermsServicesBox.Name = "TermsServicesBox";
            this.TermsServicesBox.Size = new System.Drawing.Size(18, 17);
            this.TermsServicesBox.TabIndex = 19;
            this.TermsServicesBox.UseVisualStyleBackColor = true;
            // 
            // TermsServicesLink
            // 
            this.TermsServicesLink.AutoSize = true;
            this.TermsServicesLink.Location = new System.Drawing.Point(49, 426);
            this.TermsServicesLink.Name = "TermsServicesLink";
            this.TermsServicesLink.Size = new System.Drawing.Size(116, 16);
            this.TermsServicesLink.TabIndex = 20;
            this.TermsServicesLink.TabStop = true;
            this.TermsServicesLink.Text = "Terms of Services";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(294, 475);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(124, 36);
            this.SignUpButton.TabIndex = 21;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.PanelLogo);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Label GmsLogo;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox PaswordText;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox LatNameText;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox ConfirmText;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.ListBox Choose;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.TextBox TelText;
        private System.Windows.Forms.TextBox Prefixtext;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.CheckBox TermsServicesBox;
        private System.Windows.Forms.Label TermsServices;
        private System.Windows.Forms.DateTimePicker DateTimeChoose;
        private System.Windows.Forms.ListBox CityList;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.LinkLabel TermsServicesLink;
    }
}
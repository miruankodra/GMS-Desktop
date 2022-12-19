namespace GMS
{
    partial class Climate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Climate));
            this.TempPanel = new System.Windows.Forms.Panel();
            this.TempLbl = new System.Windows.Forms.Label();
            this.TempGrade = new System.Windows.Forms.Label();
            this.TempParameters = new System.Windows.Forms.Label();
            this.AirHumidityPanel = new System.Windows.Forms.Panel();
            this.ahLbl = new System.Windows.Forms.Label();
            this.AirHumiditypercent = new System.Windows.Forms.Label();
            this.AirHumidity = new System.Windows.Forms.Label();
            this.LiveParameterslbl = new System.Windows.Forms.Label();
            this.SoilHumidity = new System.Windows.Forms.Label();
            this.LiveIcon = new System.Windows.Forms.PictureBox();
            this.SoilHumiditypercent = new System.Windows.Forms.Label();
            this.SoilHumidityPanel = new System.Windows.Forms.Panel();
            this.shLbl = new System.Windows.Forms.Label();
            this.TempPanel.SuspendLayout();
            this.AirHumidityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveIcon)).BeginInit();
            this.SoilHumidityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TempPanel
            // 
            this.TempPanel.Controls.Add(this.TempLbl);
            this.TempPanel.Controls.Add(this.TempGrade);
            this.TempPanel.Controls.Add(this.TempParameters);
            this.TempPanel.Location = new System.Drawing.Point(49, 84);
            this.TempPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TempPanel.Name = "TempPanel";
            this.TempPanel.Size = new System.Drawing.Size(262, 119);
            this.TempPanel.TabIndex = 0;
            // 
            // TempLbl
            // 
            this.TempLbl.AutoSize = true;
            this.TempLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TempLbl.Location = new System.Drawing.Point(139, 23);
            this.TempLbl.Name = "TempLbl";
            this.TempLbl.Size = new System.Drawing.Size(46, 18);
            this.TempLbl.TabIndex = 3;
            this.TempLbl.Text = "label1";
            // 
            // TempGrade
            // 
            this.TempGrade.AutoSize = true;
            this.TempGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TempGrade.Location = new System.Drawing.Point(196, 23);
            this.TempGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TempGrade.Name = "TempGrade";
            this.TempGrade.Size = new System.Drawing.Size(27, 18);
            this.TempGrade.TabIndex = 1;
            this.TempGrade.Text = "°C";
            // 
            // TempParameters
            // 
            this.TempParameters.AutoSize = true;
            this.TempParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.TempParameters.Location = new System.Drawing.Point(19, 23);
            this.TempParameters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TempParameters.Name = "TempParameters";
            this.TempParameters.Size = new System.Drawing.Size(103, 18);
            this.TempParameters.TabIndex = 0;
            this.TempParameters.Text = "Temperature";
            // 
            // AirHumidityPanel
            // 
            this.AirHumidityPanel.Controls.Add(this.ahLbl);
            this.AirHumidityPanel.Controls.Add(this.AirHumiditypercent);
            this.AirHumidityPanel.Controls.Add(this.AirHumidity);
            this.AirHumidityPanel.Location = new System.Drawing.Point(346, 84);
            this.AirHumidityPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AirHumidityPanel.Name = "AirHumidityPanel";
            this.AirHumidityPanel.Size = new System.Drawing.Size(261, 119);
            this.AirHumidityPanel.TabIndex = 1;
            // 
            // ahLbl
            // 
            this.ahLbl.AutoSize = true;
            this.ahLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ahLbl.Location = new System.Drawing.Point(141, 23);
            this.ahLbl.Name = "ahLbl";
            this.ahLbl.Size = new System.Drawing.Size(46, 18);
            this.ahLbl.TabIndex = 5;
            this.ahLbl.Text = "label4";
            // 
            // AirHumiditypercent
            // 
            this.AirHumiditypercent.AutoSize = true;
            this.AirHumiditypercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.AirHumiditypercent.Location = new System.Drawing.Point(204, 22);
            this.AirHumiditypercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AirHumiditypercent.Name = "AirHumiditypercent";
            this.AirHumiditypercent.Size = new System.Drawing.Size(22, 18);
            this.AirHumiditypercent.TabIndex = 2;
            this.AirHumiditypercent.Text = "%";
            this.AirHumiditypercent.Click += new System.EventHandler(this.AirHumiditypercent_Click);
            // 
            // AirHumidity
            // 
            this.AirHumidity.AutoSize = true;
            this.AirHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.AirHumidity.Location = new System.Drawing.Point(25, 23);
            this.AirHumidity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AirHumidity.Name = "AirHumidity";
            this.AirHumidity.Size = new System.Drawing.Size(98, 18);
            this.AirHumidity.TabIndex = 0;
            this.AirHumidity.Text = "Air Humidity";
            this.AirHumidity.Click += new System.EventHandler(this.AirHumidity_Click);
            // 
            // LiveParameterslbl
            // 
            this.LiveParameterslbl.AutoSize = true;
            this.LiveParameterslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveParameterslbl.Location = new System.Drawing.Point(225, 36);
            this.LiveParameterslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LiveParameterslbl.Name = "LiveParameterslbl";
            this.LiveParameterslbl.Size = new System.Drawing.Size(202, 29);
            this.LiveParameterslbl.TabIndex = 2;
            this.LiveParameterslbl.Text = "Live Parameters";
            // 
            // SoilHumidity
            // 
            this.SoilHumidity.AutoSize = true;
            this.SoilHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoilHumidity.Location = new System.Drawing.Point(26, 20);
            this.SoilHumidity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SoilHumidity.Name = "SoilHumidity";
            this.SoilHumidity.Size = new System.Drawing.Size(107, 18);
            this.SoilHumidity.TabIndex = 1;
            this.SoilHumidity.Text = "Soil Humidity";
            // 
            // LiveIcon
            // 
            this.LiveIcon.Image = ((System.Drawing.Image)(resources.GetObject("LiveIcon.Image")));
            this.LiveIcon.Location = new System.Drawing.Point(181, 45);
            this.LiveIcon.Margin = new System.Windows.Forms.Padding(2);
            this.LiveIcon.Name = "LiveIcon";
            this.LiveIcon.Size = new System.Drawing.Size(40, 24);
            this.LiveIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LiveIcon.TabIndex = 3;
            this.LiveIcon.TabStop = false;
            // 
            // SoilHumiditypercent
            // 
            this.SoilHumiditypercent.AutoSize = true;
            this.SoilHumiditypercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.SoilHumiditypercent.Location = new System.Drawing.Point(204, 19);
            this.SoilHumiditypercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SoilHumiditypercent.Name = "SoilHumiditypercent";
            this.SoilHumiditypercent.Size = new System.Drawing.Size(22, 18);
            this.SoilHumiditypercent.TabIndex = 3;
            this.SoilHumiditypercent.Text = "%";
            // 
            // SoilHumidityPanel
            // 
            this.SoilHumidityPanel.Controls.Add(this.shLbl);
            this.SoilHumidityPanel.Controls.Add(this.SoilHumiditypercent);
            this.SoilHumidityPanel.Controls.Add(this.SoilHumidity);
            this.SoilHumidityPanel.Location = new System.Drawing.Point(201, 279);
            this.SoilHumidityPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SoilHumidityPanel.Name = "SoilHumidityPanel";
            this.SoilHumidityPanel.Size = new System.Drawing.Size(260, 109);
            this.SoilHumidityPanel.TabIndex = 4;
            // 
            // shLbl
            // 
            this.shLbl.AutoSize = true;
            this.shLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.shLbl.Location = new System.Drawing.Point(142, 20);
            this.shLbl.Name = "shLbl";
            this.shLbl.Size = new System.Drawing.Size(46, 18);
            this.shLbl.TabIndex = 5;
            this.shLbl.Text = "label2";
            // 
            // Climate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 445);
            this.Controls.Add(this.SoilHumidityPanel);
            this.Controls.Add(this.LiveIcon);
            this.Controls.Add(this.LiveParameterslbl);
            this.Controls.Add(this.AirHumidityPanel);
            this.Controls.Add(this.TempPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Climate";
            this.Text = "Climate";
            this.Load += new System.EventHandler(this.Climate_Load);
            this.TempPanel.ResumeLayout(false);
            this.TempPanel.PerformLayout();
            this.AirHumidityPanel.ResumeLayout(false);
            this.AirHumidityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveIcon)).EndInit();
            this.SoilHumidityPanel.ResumeLayout(false);
            this.SoilHumidityPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TempPanel;
        private System.Windows.Forms.Label TempGrade;
        private System.Windows.Forms.Label TempParameters;
        private System.Windows.Forms.Panel AirHumidityPanel;
        private System.Windows.Forms.Label AirHumiditypercent;
        private System.Windows.Forms.Label AirHumidity;
        private System.Windows.Forms.Label LiveParameterslbl;
        private System.Windows.Forms.Label SoilHumidity;
        private System.Windows.Forms.PictureBox LiveIcon;
        private System.Windows.Forms.Label SoilHumiditypercent;
        private System.Windows.Forms.Panel SoilHumidityPanel;
        private System.Windows.Forms.Label TempLbl;
        private System.Windows.Forms.Label ahLbl;
        private System.Windows.Forms.Label shLbl;
    }
}
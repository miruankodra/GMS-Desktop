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
            this.AirHumidityPanel = new System.Windows.Forms.Panel();
            this.LiveParameterslbl = new System.Windows.Forms.Label();
            this.TempParameters = new System.Windows.Forms.Label();
            this.AirHumidity = new System.Windows.Forms.Label();
            this.SoilHumidity = new System.Windows.Forms.Label();
            this.LiveIcon = new System.Windows.Forms.PictureBox();
            this.TempGrade = new System.Windows.Forms.Label();
            this.AirHumiditypercent = new System.Windows.Forms.Label();
            this.SoilHumiditypercent = new System.Windows.Forms.Label();
            this.SoilHumidityPanel = new System.Windows.Forms.Panel();
            this.TempPanel.SuspendLayout();
            this.AirHumidityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveIcon)).BeginInit();
            this.SoilHumidityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TempPanel
            // 
            this.TempPanel.Controls.Add(this.TempGrade);
            this.TempPanel.Controls.Add(this.TempParameters);
            this.TempPanel.Location = new System.Drawing.Point(65, 103);
            this.TempPanel.Name = "TempPanel";
            this.TempPanel.Size = new System.Drawing.Size(349, 147);
            this.TempPanel.TabIndex = 0;
            // 
            // AirHumidityPanel
            // 
            this.AirHumidityPanel.Controls.Add(this.AirHumiditypercent);
            this.AirHumidityPanel.Controls.Add(this.AirHumidity);
            this.AirHumidityPanel.Location = new System.Drawing.Point(462, 103);
            this.AirHumidityPanel.Name = "AirHumidityPanel";
            this.AirHumidityPanel.Size = new System.Drawing.Size(348, 147);
            this.AirHumidityPanel.TabIndex = 1;
            // 
            // LiveParameterslbl
            // 
            this.LiveParameterslbl.AutoSize = true;
            this.LiveParameterslbl.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveParameterslbl.Location = new System.Drawing.Point(300, 44);
            this.LiveParameterslbl.Name = "LiveParameterslbl";
            this.LiveParameterslbl.Size = new System.Drawing.Size(269, 41);
            this.LiveParameterslbl.TabIndex = 2;
            this.LiveParameterslbl.Text = "Live Parameters";
            // 
            // TempParameters
            // 
            this.TempParameters.AutoSize = true;
            this.TempParameters.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempParameters.Location = new System.Drawing.Point(25, 28);
            this.TempParameters.Name = "TempParameters";
            this.TempParameters.Size = new System.Drawing.Size(131, 25);
            this.TempParameters.TabIndex = 0;
            this.TempParameters.Text = "Temperature";
            // 
            // AirHumidity
            // 
            this.AirHumidity.AutoSize = true;
            this.AirHumidity.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirHumidity.Location = new System.Drawing.Point(33, 28);
            this.AirHumidity.Name = "AirHumidity";
            this.AirHumidity.Size = new System.Drawing.Size(149, 25);
            this.AirHumidity.TabIndex = 0;
            this.AirHumidity.Text = "Humidity of Air";
            // 
            // SoilHumidity
            // 
            this.SoilHumidity.AutoSize = true;
            this.SoilHumidity.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoilHumidity.Location = new System.Drawing.Point(34, 24);
            this.SoilHumidity.Name = "SoilHumidity";
            this.SoilHumidity.Size = new System.Drawing.Size(156, 25);
            this.SoilHumidity.TabIndex = 1;
            this.SoilHumidity.Text = "Humidity of Soil";
            // 
            // LiveIcon
            // 
            this.LiveIcon.Image = ((System.Drawing.Image)(resources.GetObject("LiveIcon.Image")));
            this.LiveIcon.Location = new System.Drawing.Point(241, 55);
            this.LiveIcon.Name = "LiveIcon";
            this.LiveIcon.Size = new System.Drawing.Size(53, 30);
            this.LiveIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LiveIcon.TabIndex = 3;
            this.LiveIcon.TabStop = false;
            // 
            // TempGrade
            // 
            this.TempGrade.AutoSize = true;
            this.TempGrade.Location = new System.Drawing.Point(261, 35);
            this.TempGrade.Name = "TempGrade";
            this.TempGrade.Size = new System.Drawing.Size(51, 16);
            this.TempGrade.TabIndex = 1;
            this.TempGrade.Text = "Celcius";
            // 
            // AirHumiditypercent
            // 
            this.AirHumiditypercent.AutoSize = true;
            this.AirHumiditypercent.Location = new System.Drawing.Point(273, 35);
            this.AirHumiditypercent.Name = "AirHumiditypercent";
            this.AirHumiditypercent.Size = new System.Drawing.Size(19, 16);
            this.AirHumiditypercent.TabIndex = 2;
            this.AirHumiditypercent.Text = "%";
            // 
            // SoilHumiditypercent
            // 
            this.SoilHumiditypercent.AutoSize = true;
            this.SoilHumiditypercent.Location = new System.Drawing.Point(257, 31);
            this.SoilHumiditypercent.Name = "SoilHumiditypercent";
            this.SoilHumiditypercent.Size = new System.Drawing.Size(19, 16);
            this.SoilHumiditypercent.TabIndex = 3;
            this.SoilHumiditypercent.Text = "%";
            // 
            // SoilHumidityPanel
            // 
            this.SoilHumidityPanel.Controls.Add(this.SoilHumiditypercent);
            this.SoilHumidityPanel.Controls.Add(this.SoilHumidity);
            this.SoilHumidityPanel.Location = new System.Drawing.Point(268, 343);
            this.SoilHumidityPanel.Name = "SoilHumidityPanel";
            this.SoilHumidityPanel.Size = new System.Drawing.Size(347, 134);
            this.SoilHumidityPanel.TabIndex = 4;
            // 
            // Climate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 548);
            this.Controls.Add(this.SoilHumidityPanel);
            this.Controls.Add(this.LiveIcon);
            this.Controls.Add(this.LiveParameterslbl);
            this.Controls.Add(this.AirHumidityPanel);
            this.Controls.Add(this.TempPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Climate";
            this.Text = "Climate";
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
    }
}
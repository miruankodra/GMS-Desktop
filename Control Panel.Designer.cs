namespace GMS
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.heating_picbox = new System.Windows.Forms.PictureBox();
            this.Heating = new System.Windows.Forms.Button();
            this.water_system = new System.Windows.Forms.PictureBox();
            this.Activate_water = new System.Windows.Forms.Button();
            this.window_picbox = new System.Windows.Forms.PictureBox();
            this.ControlParametreslabel = new System.Windows.Forms.Label();
            this.ventilation_picbox = new System.Windows.Forms.PictureBox();
            this.On_Of_Ventilation = new System.Windows.Forms.Button();
            this.Open_close_windows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heating_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_system)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilation_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 548);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(898, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 548);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 548);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(898, 0);
            this.panel4.TabIndex = 3;
            // 
            // heating_picbox
            // 
            this.heating_picbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heating_picbox.Image = ((System.Drawing.Image)(resources.GetObject("heating_picbox.Image")));
            this.heating_picbox.Location = new System.Drawing.Point(765, 359);
            this.heating_picbox.Name = "heating_picbox";
            this.heating_picbox.Size = new System.Drawing.Size(47, 42);
            this.heating_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heating_picbox.TabIndex = 17;
            this.heating_picbox.TabStop = false;
            // 
            // Heating
            // 
            this.Heating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Heating.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heating.Location = new System.Drawing.Point(539, 359);
            this.Heating.Name = "Heating";
            this.Heating.Size = new System.Drawing.Size(196, 42);
            this.Heating.TabIndex = 16;
            this.Heating.Text = "Heating";
            this.Heating.UseVisualStyleBackColor = true;
            // 
            // water_system
            // 
            this.water_system.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.water_system.Image = ((System.Drawing.Image)(resources.GetObject("water_system.Image")));
            this.water_system.Location = new System.Drawing.Point(765, 218);
            this.water_system.Name = "water_system";
            this.water_system.Size = new System.Drawing.Size(47, 42);
            this.water_system.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.water_system.TabIndex = 15;
            this.water_system.TabStop = false;
            // 
            // Activate_water
            // 
            this.Activate_water.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Activate_water.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activate_water.Location = new System.Drawing.Point(539, 218);
            this.Activate_water.Name = "Activate_water";
            this.Activate_water.Size = new System.Drawing.Size(196, 42);
            this.Activate_water.TabIndex = 14;
            this.Activate_water.Text = "Activate Water";
            this.Activate_water.UseVisualStyleBackColor = true;
            // 
            // window_picbox
            // 
            this.window_picbox.Image = ((System.Drawing.Image)(resources.GetObject("window_picbox.Image")));
            this.window_picbox.Location = new System.Drawing.Point(302, 359);
            this.window_picbox.Name = "window_picbox";
            this.window_picbox.Size = new System.Drawing.Size(47, 42);
            this.window_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.window_picbox.TabIndex = 13;
            this.window_picbox.TabStop = false;
            // 
            // ControlParametreslabel
            // 
            this.ControlParametreslabel.AutoSize = true;
            this.ControlParametreslabel.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlParametreslabel.Location = new System.Drawing.Point(229, 63);
            this.ControlParametreslabel.Name = "ControlParametreslabel";
            this.ControlParametreslabel.Size = new System.Drawing.Size(383, 41);
            this.ControlParametreslabel.TabIndex = 10;
            this.ControlParametreslabel.Text = "Control the Parametres";
            // 
            // ventilation_picbox
            // 
            this.ventilation_picbox.Image = ((System.Drawing.Image)(resources.GetObject("ventilation_picbox.Image")));
            this.ventilation_picbox.Location = new System.Drawing.Point(302, 218);
            this.ventilation_picbox.Name = "ventilation_picbox";
            this.ventilation_picbox.Size = new System.Drawing.Size(47, 42);
            this.ventilation_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ventilation_picbox.TabIndex = 12;
            this.ventilation_picbox.TabStop = false;
            // 
            // On_Of_Ventilation
            // 
            this.On_Of_Ventilation.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.On_Of_Ventilation.Location = new System.Drawing.Point(83, 218);
            this.On_Of_Ventilation.Name = "On_Of_Ventilation";
            this.On_Of_Ventilation.Size = new System.Drawing.Size(196, 42);
            this.On_Of_Ventilation.TabIndex = 9;
            this.On_Of_Ventilation.Text = "Ventilation";
            this.On_Of_Ventilation.UseVisualStyleBackColor = true;
            // 
            // Open_close_windows
            // 
            this.Open_close_windows.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_close_windows.Location = new System.Drawing.Point(83, 359);
            this.Open_close_windows.Name = "Open_close_windows";
            this.Open_close_windows.Size = new System.Drawing.Size(196, 42);
            this.Open_close_windows.TabIndex = 11;
            this.Open_close_windows.Text = "Windows ";
            this.Open_close_windows.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 548);
            this.Controls.Add(this.heating_picbox);
            this.Controls.Add(this.Heating);
            this.Controls.Add(this.water_system);
            this.Controls.Add(this.Activate_water);
            this.Controls.Add(this.window_picbox);
            this.Controls.Add(this.ControlParametreslabel);
            this.Controls.Add(this.ventilation_picbox);
            this.Controls.Add(this.On_Of_Ventilation);
            this.Controls.Add(this.Open_close_windows);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.heating_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_system)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilation_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox heating_picbox;
        private System.Windows.Forms.Button Heating;
        private System.Windows.Forms.PictureBox water_system;
        private System.Windows.Forms.Button Activate_water;
        private System.Windows.Forms.PictureBox window_picbox;
        private System.Windows.Forms.Label ControlParametreslabel;
        private System.Windows.Forms.PictureBox ventilation_picbox;
        private System.Windows.Forms.Button On_Of_Ventilation;
        private System.Windows.Forms.Button Open_close_windows;
    }
}
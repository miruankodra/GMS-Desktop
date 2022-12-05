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
            this.ControlPanel_parameter = new System.Windows.Forms.Panel();
            this.On_Of_Ventilation = new System.Windows.Forms.Button();
            this.ControlParametreslabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Open_close_windows = new System.Windows.Forms.Button();
            this.ventilation_picbox = new System.Windows.Forms.PictureBox();
            this.window_picbox = new System.Windows.Forms.PictureBox();
            this.Activate_water = new System.Windows.Forms.Button();
            this.water_system = new System.Windows.Forms.PictureBox();
            this.Heating = new System.Windows.Forms.Button();
            this.heating_picbox = new System.Windows.Forms.PictureBox();
            this.ControlPanel_parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventilation_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_system)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heating_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel_parameter
            // 
            this.ControlPanel_parameter.Controls.Add(this.heating_picbox);
            this.ControlPanel_parameter.Controls.Add(this.Heating);
            this.ControlPanel_parameter.Controls.Add(this.water_system);
            this.ControlPanel_parameter.Controls.Add(this.Activate_water);
            this.ControlPanel_parameter.Controls.Add(this.window_picbox);
            this.ControlPanel_parameter.Controls.Add(this.ventilation_picbox);
            this.ControlPanel_parameter.Controls.Add(this.Open_close_windows);
            this.ControlPanel_parameter.Controls.Add(this.ControlParametreslabel);
            this.ControlPanel_parameter.Controls.Add(this.On_Of_Ventilation);
            this.ControlPanel_parameter.Location = new System.Drawing.Point(38, 29);
            this.ControlPanel_parameter.Name = "ControlPanel_parameter";
            this.ControlPanel_parameter.Size = new System.Drawing.Size(820, 482);
            this.ControlPanel_parameter.TabIndex = 0;
            // 
            // On_Of_Ventilation
            // 
            this.On_Of_Ventilation.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.On_Of_Ventilation.Location = new System.Drawing.Point(39, 164);
            this.On_Of_Ventilation.Name = "On_Of_Ventilation";
            this.On_Of_Ventilation.Size = new System.Drawing.Size(196, 42);
            this.On_Of_Ventilation.TabIndex = 0;
            this.On_Of_Ventilation.Text = "Ventilation";
            this.On_Of_Ventilation.UseVisualStyleBackColor = true;
            // 
            // ControlParametreslabel
            // 
            this.ControlParametreslabel.AutoSize = true;
            this.ControlParametreslabel.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlParametreslabel.Location = new System.Drawing.Point(194, 28);
            this.ControlParametreslabel.Name = "ControlParametreslabel";
            this.ControlParametreslabel.Size = new System.Drawing.Size(383, 41);
            this.ControlParametreslabel.TabIndex = 1;
            this.ControlParametreslabel.Text = "Control the Parametres";
            // 
            // Open_close_windows
            // 
            this.Open_close_windows.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_close_windows.Location = new System.Drawing.Point(39, 305);
            this.Open_close_windows.Name = "Open_close_windows";
            this.Open_close_windows.Size = new System.Drawing.Size(196, 42);
            this.Open_close_windows.TabIndex = 2;
            this.Open_close_windows.Text = "Windows ";
            this.Open_close_windows.UseVisualStyleBackColor = true;
            // 
            // ventilation_picbox
            // 
            this.ventilation_picbox.Image = ((System.Drawing.Image)(resources.GetObject("ventilation_picbox.Image")));
            this.ventilation_picbox.Location = new System.Drawing.Point(258, 164);
            this.ventilation_picbox.Name = "ventilation_picbox";
            this.ventilation_picbox.Size = new System.Drawing.Size(47, 42);
            this.ventilation_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ventilation_picbox.TabIndex = 3;
            this.ventilation_picbox.TabStop = false;
            // 
            // window_picbox
            // 
            this.window_picbox.Image = ((System.Drawing.Image)(resources.GetObject("window_picbox.Image")));
            this.window_picbox.Location = new System.Drawing.Point(258, 305);
            this.window_picbox.Name = "window_picbox";
            this.window_picbox.Size = new System.Drawing.Size(47, 42);
            this.window_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.window_picbox.TabIndex = 4;
            this.window_picbox.TabStop = false;
            // 
            // Activate_water
            // 
            this.Activate_water.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activate_water.Location = new System.Drawing.Point(495, 164);
            this.Activate_water.Name = "Activate_water";
            this.Activate_water.Size = new System.Drawing.Size(196, 42);
            this.Activate_water.TabIndex = 5;
            this.Activate_water.Text = "Activate Water";
            this.Activate_water.UseVisualStyleBackColor = true;
            // 
            // water_system
            // 
            this.water_system.Image = ((System.Drawing.Image)(resources.GetObject("water_system.Image")));
            this.water_system.Location = new System.Drawing.Point(721, 164);
            this.water_system.Name = "water_system";
            this.water_system.Size = new System.Drawing.Size(47, 42);
            this.water_system.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.water_system.TabIndex = 6;
            this.water_system.TabStop = false;
            // 
            // Heating
            // 
            this.Heating.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heating.Location = new System.Drawing.Point(495, 305);
            this.Heating.Name = "Heating";
            this.Heating.Size = new System.Drawing.Size(196, 42);
            this.Heating.TabIndex = 7;
            this.Heating.Text = "Heating";
            this.Heating.UseVisualStyleBackColor = true;
            // 
            // heating_picbox
            // 
            this.heating_picbox.Image = ((System.Drawing.Image)(resources.GetObject("heating_picbox.Image")));
            this.heating_picbox.Location = new System.Drawing.Point(721, 305);
            this.heating_picbox.Name = "heating_picbox";
            this.heating_picbox.Size = new System.Drawing.Size(47, 42);
            this.heating_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heating_picbox.TabIndex = 8;
            this.heating_picbox.TabStop = false;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 548);
            this.Controls.Add(this.ControlPanel_parameter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.ControlPanel_parameter.ResumeLayout(false);
            this.ControlPanel_parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventilation_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_system)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heating_picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel_parameter;
        private System.Windows.Forms.Button On_Of_Ventilation;
        private System.Windows.Forms.Label ControlParametreslabel;
        private System.Windows.Forms.PictureBox heating_picbox;
        private System.Windows.Forms.Button Heating;
        private System.Windows.Forms.PictureBox water_system;
        private System.Windows.Forms.Button Activate_water;
        private System.Windows.Forms.PictureBox window_picbox;
        private System.Windows.Forms.PictureBox ventilation_picbox;
        private System.Windows.Forms.Button Open_close_windows;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
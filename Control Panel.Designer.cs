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
            this.water_system = new System.Windows.Forms.PictureBox();
            this.window_picbox = new System.Windows.Forms.PictureBox();
            this.ControlParametreslabel = new System.Windows.Forms.Label();
            this.ventilation_picbox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Ventilationlbl = new System.Windows.Forms.Label();
            this.Windowslbl = new System.Windows.Forms.Label();
            this.Watersystemlbl = new System.Windows.Forms.Label();
            this.Heatinglbl = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.toggleSwitch2 = new GMS.CustomControls.ToggleSwitch();
            this.panel11 = new System.Windows.Forms.Panel();
            this.toggleSwitch4 = new GMS.CustomControls.ToggleSwitch();
            this.panel12 = new System.Windows.Forms.Panel();
            this.toggleSwitch1 = new GMS.CustomControls.ToggleSwitch();
            this.panel9 = new System.Windows.Forms.Panel();
            this.toggleSwitch3 = new GMS.CustomControls.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.heating_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_system)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilation_picbox)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 814);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1452, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 814);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 814);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1452, 0);
            this.panel4.TabIndex = 3;
            // 
            // heating_picbox
            // 
            this.heating_picbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heating_picbox.Image = ((System.Drawing.Image)(resources.GetObject("heating_picbox.Image")));
            this.heating_picbox.Location = new System.Drawing.Point(-1, -2);
            this.heating_picbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heating_picbox.Name = "heating_picbox";
            this.heating_picbox.Size = new System.Drawing.Size(64, 64);
            this.heating_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.heating_picbox.TabIndex = 17;
            this.heating_picbox.TabStop = false;
            // 
            // water_system
            // 
            this.water_system.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.water_system.Image = ((System.Drawing.Image)(resources.GetObject("water_system.Image")));
            this.water_system.Location = new System.Drawing.Point(-4, 0);
            this.water_system.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.water_system.Name = "water_system";
            this.water_system.Size = new System.Drawing.Size(85, 79);
            this.water_system.TabIndex = 15;
            this.water_system.TabStop = false;
            // 
            // window_picbox
            // 
            this.window_picbox.Image = ((System.Drawing.Image)(resources.GetObject("window_picbox.Image")));
            this.window_picbox.Location = new System.Drawing.Point(-1, 2);
            this.window_picbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window_picbox.Name = "window_picbox";
            this.window_picbox.Size = new System.Drawing.Size(50, 50);
            this.window_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.window_picbox.TabIndex = 13;
            this.window_picbox.TabStop = false;
            // 
            // ControlParametreslabel
            // 
            this.ControlParametreslabel.AutoSize = true;
            this.ControlParametreslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlParametreslabel.ForeColor = System.Drawing.Color.White;
            this.ControlParametreslabel.Location = new System.Drawing.Point(483, 20);
            this.ControlParametreslabel.Name = "ControlParametreslabel";
            this.ControlParametreslabel.Size = new System.Drawing.Size(209, 36);
            this.ControlParametreslabel.TabIndex = 10;
            this.ControlParametreslabel.Text = "Control Panel";
            this.ControlParametreslabel.Click += new System.EventHandler(this.ControlParametreslabel_Click);
            // 
            // ventilation_picbox
            // 
            this.ventilation_picbox.Image = ((System.Drawing.Image)(resources.GetObject("ventilation_picbox.Image")));
            this.ventilation_picbox.Location = new System.Drawing.Point(-1, 2);
            this.ventilation_picbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ventilation_picbox.Name = "ventilation_picbox";
            this.ventilation_picbox.Size = new System.Drawing.Size(64, 64);
            this.ventilation_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ventilation_picbox.TabIndex = 12;
            this.ventilation_picbox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1452, 76);
            this.panel2.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 738);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1452, 76);
            this.panel5.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1339, 76);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(113, 662);
            this.panel6.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 76);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(113, 662);
            this.panel7.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel8.Controls.Add(this.Ventilationlbl);
            this.panel8.Controls.Add(this.Windowslbl);
            this.panel8.Controls.Add(this.Watersystemlbl);
            this.panel8.Controls.Add(this.Heatinglbl);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.ControlParametreslabel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(113, 76);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1226, 662);
            this.panel8.TabIndex = 22;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // Ventilationlbl
            // 
            this.Ventilationlbl.AutoSize = true;
            this.Ventilationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventilationlbl.ForeColor = System.Drawing.Color.Transparent;
            this.Ventilationlbl.Location = new System.Drawing.Point(304, 114);
            this.Ventilationlbl.Name = "Ventilationlbl";
            this.Ventilationlbl.Size = new System.Drawing.Size(293, 25);
            this.Ventilationlbl.TabIndex = 27;
            this.Ventilationlbl.Text = "Ventilation System Activation";
            // 
            // Windowslbl
            // 
            this.Windowslbl.AutoSize = true;
            this.Windowslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Windowslbl.ForeColor = System.Drawing.Color.Transparent;
            this.Windowslbl.Location = new System.Drawing.Point(304, 268);
            this.Windowslbl.Name = "Windowslbl";
            this.Windowslbl.Size = new System.Drawing.Size(279, 25);
            this.Windowslbl.TabIndex = 26;
            this.Windowslbl.Text = "Windows System Activation";
            // 
            // Watersystemlbl
            // 
            this.Watersystemlbl.AutoSize = true;
            this.Watersystemlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Watersystemlbl.ForeColor = System.Drawing.Color.Transparent;
            this.Watersystemlbl.Location = new System.Drawing.Point(304, 414);
            this.Watersystemlbl.Name = "Watersystemlbl";
            this.Watersystemlbl.Size = new System.Drawing.Size(249, 25);
            this.Watersystemlbl.TabIndex = 25;
            this.Watersystemlbl.Text = "Water System Activation";
            // 
            // Heatinglbl
            // 
            this.Heatinglbl.AutoSize = true;
            this.Heatinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heatinglbl.ForeColor = System.Drawing.Color.Transparent;
            this.Heatinglbl.Location = new System.Drawing.Point(316, 551);
            this.Heatinglbl.Name = "Heatinglbl";
            this.Heatinglbl.Size = new System.Drawing.Size(265, 25);
            this.Heatinglbl.TabIndex = 24;
            this.Heatinglbl.Text = "Heating System Activation";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.window_picbox);
            this.panel10.Controls.Add(this.toggleSwitch2);
            this.panel10.Location = new System.Drawing.Point(11, 238);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(269, 84);
            this.panel10.TabIndex = 23;
            // 
            // toggleSwitch2
            // 
            this.toggleSwitch2.Location = new System.Drawing.Point(111, 28);
            this.toggleSwitch2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toggleSwitch2.MinimumSize = new System.Drawing.Size(60, 27);
            this.toggleSwitch2.Name = "toggleSwitch2";
            this.toggleSwitch2.OffBackColor = System.Drawing.Color.Gray;
            this.toggleSwitch2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleSwitch2.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.toggleSwitch2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleSwitch2.Size = new System.Drawing.Size(67, 27);
            this.toggleSwitch2.TabIndex = 19;
            this.toggleSwitch2.Text = "toggleSwitch2";
            this.toggleSwitch2.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.heating_picbox);
            this.panel11.Controls.Add(this.toggleSwitch4);
            this.panel11.Location = new System.Drawing.Point(8, 523);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(269, 82);
            this.panel11.TabIndex = 23;
            // 
            // toggleSwitch4
            // 
            this.toggleSwitch4.Location = new System.Drawing.Point(111, 27);
            this.toggleSwitch4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toggleSwitch4.MinimumSize = new System.Drawing.Size(60, 27);
            this.toggleSwitch4.Name = "toggleSwitch4";
            this.toggleSwitch4.OffBackColor = System.Drawing.Color.Gray;
            this.toggleSwitch4.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleSwitch4.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.toggleSwitch4.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleSwitch4.Size = new System.Drawing.Size(67, 27);
            this.toggleSwitch4.TabIndex = 21;
            this.toggleSwitch4.Text = "toggleSwitch4";
            this.toggleSwitch4.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.water_system);
            this.panel12.Controls.Add(this.toggleSwitch1);
            this.panel12.Location = new System.Drawing.Point(11, 383);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(267, 78);
            this.panel12.TabIndex = 23;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(108, 28);
            this.toggleSwitch1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toggleSwitch1.MinimumSize = new System.Drawing.Size(60, 27);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleSwitch1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleSwitch1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.toggleSwitch1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleSwitch1.Size = new System.Drawing.Size(67, 27);
            this.toggleSwitch1.TabIndex = 18;
            this.toggleSwitch1.Text = "toggleSwitch1";
            this.toggleSwitch1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.ventilation_picbox);
            this.panel9.Controls.Add(this.toggleSwitch3);
            this.panel9.Location = new System.Drawing.Point(8, 86);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(269, 87);
            this.panel9.TabIndex = 22;
            // 
            // toggleSwitch3
            // 
            this.toggleSwitch3.Location = new System.Drawing.Point(111, 26);
            this.toggleSwitch3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toggleSwitch3.MinimumSize = new System.Drawing.Size(60, 27);
            this.toggleSwitch3.Name = "toggleSwitch3";
            this.toggleSwitch3.OffBackColor = System.Drawing.Color.Gray;
            this.toggleSwitch3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleSwitch3.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.toggleSwitch3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleSwitch3.Size = new System.Drawing.Size(67, 27);
            this.toggleSwitch3.TabIndex = 20;
            this.toggleSwitch3.Text = "toggleSwitch3";
            this.toggleSwitch3.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1452, 814);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.heating_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_system)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilation_picbox)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox heating_picbox;
        private System.Windows.Forms.PictureBox water_system;
        private System.Windows.Forms.PictureBox window_picbox;
        private System.Windows.Forms.Label ControlParametreslabel;
        private System.Windows.Forms.PictureBox ventilation_picbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private CustomControls.ToggleSwitch toggleSwitch4;
        private CustomControls.ToggleSwitch toggleSwitch3;
        private CustomControls.ToggleSwitch toggleSwitch2;
        private CustomControls.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label Watersystemlbl;
        private System.Windows.Forms.Label Heatinglbl;
        private System.Windows.Forms.Label Ventilationlbl;
        private System.Windows.Forms.Label Windowslbl;
    }
}
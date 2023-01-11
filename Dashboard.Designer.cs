﻿namespace GMS
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoGms = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.ModalitetBtn = new System.Windows.Forms.Button();
            this.ControlPanelBtn = new System.Windows.Forms.Button();
            this.ClimateBtn = new System.Windows.Forms.Button();
            this.DashBoardBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gmsName = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GMS.Properties.Resources.bitmap;
            this.pictureBox1.Location = new System.Drawing.Point(27, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LogoGms
            // 
            this.LogoGms.AutoSize = true;
            this.LogoGms.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoGms.ForeColor = System.Drawing.Color.Snow;
            this.LogoGms.Location = new System.Drawing.Point(71, 10);
            this.LogoGms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogoGms.Name = "LogoGms";
            this.LogoGms.Size = new System.Drawing.Size(92, 37);
            this.LogoGms.TabIndex = 0;
            this.LogoGms.Text = "GMS";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sidebarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebarPanel.Controls.Add(this.pictureBox5);
            this.sidebarPanel.Controls.Add(this.pictureBox4);
            this.sidebarPanel.Controls.Add(this.pictureBox3);
            this.sidebarPanel.Controls.Add(this.pictureBox2);
            this.sidebarPanel.Controls.Add(this.pictureBox1);
            this.sidebarPanel.Controls.Add(this.ModalitetBtn);
            this.sidebarPanel.Controls.Add(this.LogoGms);
            this.sidebarPanel.Controls.Add(this.ControlPanelBtn);
            this.sidebarPanel.Controls.Add(this.ClimateBtn);
            this.sidebarPanel.Controls.Add(this.DashBoardBtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(331, 531);
            this.sidebarPanel.TabIndex = 1;
            this.sidebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarPanel_Paint);
            // 
            // ModalitetBtn
            // 
            this.ModalitetBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModalitetBtn.FlatAppearance.BorderSize = 0;
            this.ModalitetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.ModalitetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModalitetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModalitetBtn.ForeColor = System.Drawing.Color.White;
            this.ModalitetBtn.Location = new System.Drawing.Point(71, 281);
            this.ModalitetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModalitetBtn.Name = "ModalitetBtn";
            this.ModalitetBtn.Size = new System.Drawing.Size(259, 61);
            this.ModalitetBtn.TabIndex = 3;
            this.ModalitetBtn.Text = "Modalities";
            this.ModalitetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModalitetBtn.UseVisualStyleBackColor = false;
            this.ModalitetBtn.Click += new System.EventHandler(this.ModalitetBtn_Click);
            // 
            // ControlPanelBtn
            // 
            this.ControlPanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanelBtn.FlatAppearance.BorderSize = 0;
            this.ControlPanelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.ControlPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlPanelBtn.ForeColor = System.Drawing.Color.White;
            this.ControlPanelBtn.Location = new System.Drawing.Point(71, 215);
            this.ControlPanelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ControlPanelBtn.Name = "ControlPanelBtn";
            this.ControlPanelBtn.Size = new System.Drawing.Size(259, 61);
            this.ControlPanelBtn.TabIndex = 2;
            this.ControlPanelBtn.Text = "Control Panel";
            this.ControlPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ControlPanelBtn.UseVisualStyleBackColor = false;
            this.ControlPanelBtn.Click += new System.EventHandler(this.ControlPanelBtn_Click);
            // 
            // ClimateBtn
            // 
            this.ClimateBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClimateBtn.FlatAppearance.BorderSize = 0;
            this.ClimateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.ClimateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClimateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimateBtn.ForeColor = System.Drawing.Color.White;
            this.ClimateBtn.Location = new System.Drawing.Point(71, 152);
            this.ClimateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClimateBtn.Name = "ClimateBtn";
            this.ClimateBtn.Size = new System.Drawing.Size(259, 61);
            this.ClimateBtn.TabIndex = 1;
            this.ClimateBtn.Text = "Climate";
            this.ClimateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClimateBtn.UseVisualStyleBackColor = false;
            this.ClimateBtn.Click += new System.EventHandler(this.ClimateBtn_Click);
            // 
            // DashBoardBtn
            // 
            this.DashBoardBtn.BackColor = System.Drawing.Color.Transparent;
            this.DashBoardBtn.FlatAppearance.BorderSize = 0;
            this.DashBoardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.DashBoardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardBtn.ForeColor = System.Drawing.Color.White;
            this.DashBoardBtn.Location = new System.Drawing.Point(71, 89);
            this.DashBoardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DashBoardBtn.Name = "DashBoardBtn";
            this.DashBoardBtn.Size = new System.Drawing.Size(259, 61);
            this.DashBoardBtn.TabIndex = 0;
            this.DashBoardBtn.Text = "Dashboard";
            this.DashBoardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBoardBtn.UseVisualStyleBackColor = false;
            this.DashBoardBtn.Click += new System.EventHandler(this.DashBoardBtn_Click);
            this.DashBoardBtn.MouseHover += new System.EventHandler(this.DashBoardBtn_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(27, 293);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(27, 229);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.gmsName);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(331, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 66);
            this.panel1.TabIndex = 2;
            // 
            // gmsName
            // 
            this.gmsName.AutoSize = true;
            this.gmsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmsName.ForeColor = System.Drawing.Color.Snow;
            this.gmsName.Location = new System.Drawing.Point(87, 15);
            this.gmsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gmsName.Name = "gmsName";
            this.gmsName.Size = new System.Drawing.Size(202, 37);
            this.gmsName.TabIndex = 1;
            this.gmsName.Text = "Greenhouse";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(17, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(65, 63);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(331, 66);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(591, 465);
            this.mainPanel.TabIndex = 3;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(922, 531);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebarPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LogoGms;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button ModalitetBtn;
        private System.Windows.Forms.Button ControlPanelBtn;
        private System.Windows.Forms.Button ClimateBtn;
        private System.Windows.Forms.Button DashBoardBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gmsName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel mainPanel;
    }
}
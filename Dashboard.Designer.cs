namespace GMS
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
            this.TopPanelDash = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoGms = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.ModalitetBtn = new System.Windows.Forms.Button();
            this.ControlPanelBtn = new System.Windows.Forms.Button();
            this.ClimateBtn = new System.Windows.Forms.Button();
            this.DashBoardBtn = new System.Windows.Forms.Button();
            this.MiddelPanelDash = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.TopPanelDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            this.MiddelPanelDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanelDash
            // 
            this.TopPanelDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.TopPanelDash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanelDash.Controls.Add(this.pictureBox1);
            this.TopPanelDash.Controls.Add(this.LogoGms);
            this.TopPanelDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelDash.Location = new System.Drawing.Point(0, 0);
            this.TopPanelDash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.TopPanelDash.Name = "TopPanelDash";
            this.TopPanelDash.Size = new System.Drawing.Size(922, 48);
            this.TopPanelDash.TabIndex = 0;
            this.TopPanelDash.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanelDash_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GMS.Properties.Resources.bitmap;
            this.pictureBox1.Location = new System.Drawing.Point(26, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.LogoGms.Location = new System.Drawing.Point(70, 0);
            this.LogoGms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogoGms.Name = "LogoGms";
            this.LogoGms.Size = new System.Drawing.Size(92, 37);
            this.LogoGms.TabIndex = 0;
            this.LogoGms.Text = "GMS";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.sidebarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebarPanel.Controls.Add(this.ModalitetBtn);
            this.sidebarPanel.Controls.Add(this.ControlPanelBtn);
            this.sidebarPanel.Controls.Add(this.ClimateBtn);
            this.sidebarPanel.Controls.Add(this.DashBoardBtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 48);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(236, 483);
            this.sidebarPanel.TabIndex = 1;
            // 
            // ModalitetBtn
            // 
            this.ModalitetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.ModalitetBtn.FlatAppearance.BorderSize = 0;
            this.ModalitetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.ModalitetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModalitetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModalitetBtn.Location = new System.Drawing.Point(0, 211);
            this.ModalitetBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModalitetBtn.Name = "ModalitetBtn";
            this.ModalitetBtn.Size = new System.Drawing.Size(236, 61);
            this.ModalitetBtn.TabIndex = 3;
            this.ModalitetBtn.Text = "Modalities";
            this.ModalitetBtn.UseVisualStyleBackColor = false;
            this.ModalitetBtn.Click += new System.EventHandler(this.ModalitetBtn_Click);
            // 
            // ControlPanelBtn
            // 
            this.ControlPanelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.ControlPanelBtn.FlatAppearance.BorderSize = 0;
            this.ControlPanelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.ControlPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlPanelBtn.Location = new System.Drawing.Point(0, 145);
            this.ControlPanelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ControlPanelBtn.Name = "ControlPanelBtn";
            this.ControlPanelBtn.Size = new System.Drawing.Size(236, 61);
            this.ControlPanelBtn.TabIndex = 2;
            this.ControlPanelBtn.Text = "Control Panel";
            this.ControlPanelBtn.UseVisualStyleBackColor = false;
            this.ControlPanelBtn.Click += new System.EventHandler(this.ControlPanelBtn_Click);
            // 
            // ClimateBtn
            // 
            this.ClimateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.ClimateBtn.FlatAppearance.BorderSize = 0;
            this.ClimateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.ClimateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClimateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClimateBtn.Location = new System.Drawing.Point(0, 82);
            this.ClimateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClimateBtn.Name = "ClimateBtn";
            this.ClimateBtn.Size = new System.Drawing.Size(236, 61);
            this.ClimateBtn.TabIndex = 1;
            this.ClimateBtn.Text = "Climate";
            this.ClimateBtn.UseVisualStyleBackColor = false;
            this.ClimateBtn.Click += new System.EventHandler(this.ClimateBtn_Click);
            // 
            // DashBoardBtn
            // 
            this.DashBoardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.DashBoardBtn.FlatAppearance.BorderSize = 0;
            this.DashBoardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.DashBoardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardBtn.Location = new System.Drawing.Point(0, 19);
            this.DashBoardBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DashBoardBtn.Name = "DashBoardBtn";
            this.DashBoardBtn.Size = new System.Drawing.Size(236, 61);
            this.DashBoardBtn.TabIndex = 0;
            this.DashBoardBtn.Text = "Dashboard";
            this.DashBoardBtn.UseVisualStyleBackColor = false;
            this.DashBoardBtn.Click += new System.EventHandler(this.DashBoardBtn_Click);
            this.DashBoardBtn.MouseHover += new System.EventHandler(this.DashBoardBtn_MouseHover);
            // 
            // MiddelPanelDash
            // 
            this.MiddelPanelDash.BackColor = System.Drawing.Color.White;
            this.MiddelPanelDash.Controls.Add(this.mainPanel);
            this.MiddelPanelDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddelPanelDash.Location = new System.Drawing.Point(236, 48);
            this.MiddelPanelDash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.MiddelPanelDash.Name = "MiddelPanelDash";
            this.MiddelPanelDash.Size = new System.Drawing.Size(686, 483);
            this.MiddelPanelDash.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(687, 483);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(228)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(922, 531);
            this.Controls.Add(this.MiddelPanelDash);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.TopPanelDash);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.TopPanelDash.ResumeLayout(false);
            this.TopPanelDash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.MiddelPanelDash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanelDash;
        private System.Windows.Forms.Label LogoGms;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button ModalitetBtn;
        private System.Windows.Forms.Button ControlPanelBtn;
        private System.Windows.Forms.Button ClimateBtn;
        private System.Windows.Forms.Button DashBoardBtn;
        private System.Windows.Forms.Panel MiddelPanelDash;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
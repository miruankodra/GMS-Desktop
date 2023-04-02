namespace GMS
{
    partial class UserManagement
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
            this.usermangagementlbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchlbl = new System.Windows.Forms.Label();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.showrecodrsbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usermangagementlbl
            // 
            this.usermangagementlbl.AutoSize = true;
            this.usermangagementlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.usermangagementlbl.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usermangagementlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.usermangagementlbl.Location = new System.Drawing.Point(502, 56);
            this.usermangagementlbl.Name = "usermangagementlbl";
            this.usermangagementlbl.Size = new System.Drawing.Size(288, 39);
            this.usermangagementlbl.TabIndex = 1;
            this.usermangagementlbl.Text = "User Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 360);
            this.dataGridView1.TabIndex = 2;
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.searchlbl.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlbl.ForeColor = System.Drawing.Color.White;
            this.searchlbl.Location = new System.Drawing.Point(258, 169);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(90, 27);
            this.searchlbl.TabIndex = 14;
            this.searchlbl.Text = "Search:";
            // 
            // searchtext
            // 
            this.searchtext.Font = new System.Drawing.Font("Montserrat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtext.Location = new System.Drawing.Point(366, 164);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(263, 32);
            this.searchtext.TabIndex = 34;
            this.searchtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchtext_KeyDown);
            // 
            // showrecodrsbtn
            // 
            this.showrecodrsbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showrecodrsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.showrecodrsbtn.FlatAppearance.BorderSize = 0;
            this.showrecodrsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showrecodrsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showrecodrsbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showrecodrsbtn.Location = new System.Drawing.Point(891, 663);
            this.showrecodrsbtn.Margin = new System.Windows.Forms.Padding(5);
            this.showrecodrsbtn.Name = "showrecodrsbtn";
            this.showrecodrsbtn.Size = new System.Drawing.Size(192, 50);
            this.showrecodrsbtn.TabIndex = 37;
            this.showrecodrsbtn.Text = "Show Records";
            this.showrecodrsbtn.UseVisualStyleBackColor = false;
            this.showrecodrsbtn.Click += new System.EventHandler(this.adduserbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.Clearbtn.FlatAppearance.BorderSize = 0;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clearbtn.Location = new System.Drawing.Point(1136, 663);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(192, 50);
            this.Clearbtn.TabIndex = 38;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1434, 767);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.showrecodrsbtn);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.usermangagementlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usermangagementlbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label searchlbl;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Button showrecodrsbtn;
        private System.Windows.Forms.Button Clearbtn;
    }
}
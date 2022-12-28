namespace GMS
{
    partial class Modalities
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
            this.AddModBtn = new System.Windows.Forms.Button();
            this.AddLbl = new System.Windows.Forms.Label();
            this.dataGridViewModalities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModalities)).BeginInit();
            this.SuspendLayout();
            // 
            // AddModBtn
            // 
            this.AddModBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddModBtn.Location = new System.Drawing.Point(110, 108);
            this.AddModBtn.Name = "AddModBtn";
            this.AddModBtn.Size = new System.Drawing.Size(110, 110);
            this.AddModBtn.TabIndex = 0;
            this.AddModBtn.Text = "+\r\n";
            this.AddModBtn.UseVisualStyleBackColor = true;
            // 
            // AddLbl
            // 
            this.AddLbl.AutoSize = true;
            this.AddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLbl.Location = new System.Drawing.Point(89, 234);
            this.AddLbl.Name = "AddLbl";
            this.AddLbl.Size = new System.Drawing.Size(149, 25);
            this.AddLbl.TabIndex = 1;
            this.AddLbl.Text = "Add Modality";
            // 
            // dataGridViewModalities
            // 
            this.dataGridViewModalities.AllowUserToAddRows = false;
            this.dataGridViewModalities.AllowUserToDeleteRows = false;
            this.dataGridViewModalities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModalities.Location = new System.Drawing.Point(412, 68);
            this.dataGridViewModalities.Name = "dataGridViewModalities";
            this.dataGridViewModalities.Size = new System.Drawing.Size(638, 475);
            this.dataGridViewModalities.TabIndex = 2;
            this.dataGridViewModalities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModalities_CellContentClick);
            // 
            // Modalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 661);
            this.Controls.Add(this.dataGridViewModalities);
            this.Controls.Add(this.AddLbl);
            this.Controls.Add(this.AddModBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Modalities";
            this.Text = "Modalities";
            this.Load += new System.EventHandler(this.Modalities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModalities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddModBtn;
        private System.Windows.Forms.Label AddLbl;
        private System.Windows.Forms.DataGridView dataGridViewModalities;
    }
}
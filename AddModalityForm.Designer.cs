namespace GMS
{
    partial class AddModalityForm
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
            this.modalitytitle = new System.Windows.Forms.Label();
            this.modalityNames = new System.Windows.Forms.Label();
            this.modalitytextlbl = new System.Windows.Forms.TextBox();
            this.descriptionlbl = new System.Windows.Forms.Label();
            this.descriptiontextlbl = new System.Windows.Forms.TextBox();
            this.mintemplbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modalitytitle
            // 
            this.modalitytitle.AutoSize = true;
            this.modalitytitle.Font = new System.Drawing.Font("Montserrat SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalitytitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modalitytitle.Location = new System.Drawing.Point(497, 33);
            this.modalitytitle.Name = "modalitytitle";
            this.modalitytitle.Size = new System.Drawing.Size(307, 51);
            this.modalitytitle.TabIndex = 0;
            this.modalitytitle.Text = "Add Modalities";
            // 
            // modalityNames
            // 
            this.modalityNames.AutoSize = true;
            this.modalityNames.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalityNames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modalityNames.Location = new System.Drawing.Point(110, 157);
            this.modalityNames.Name = "modalityNames";
            this.modalityNames.Size = new System.Drawing.Size(204, 32);
            this.modalityNames.TabIndex = 1;
            this.modalityNames.Text = "Modality Name:";
            // 
            // modalitytextlbl
            // 
            this.modalitytextlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalitytextlbl.Location = new System.Drawing.Point(336, 160);
            this.modalitytextlbl.Name = "modalitytextlbl";
            this.modalitytextlbl.Size = new System.Drawing.Size(185, 30);
            this.modalitytextlbl.TabIndex = 2;
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionlbl.Location = new System.Drawing.Point(110, 277);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(161, 32);
            this.descriptionlbl.TabIndex = 3;
            this.descriptionlbl.Text = "Description:";
            // 
            // descriptiontextlbl
            // 
            this.descriptiontextlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontextlbl.Location = new System.Drawing.Point(336, 280);
            this.descriptiontextlbl.Name = "descriptiontextlbl";
            this.descriptiontextlbl.Size = new System.Drawing.Size(185, 30);
            this.descriptiontextlbl.TabIndex = 4;
            // 
            // mintemplbl
            // 
            this.mintemplbl.AutoSize = true;
            this.mintemplbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintemplbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mintemplbl.Location = new System.Drawing.Point(110, 384);
            this.mintemplbl.Name = "mintemplbl";
            this.mintemplbl.Size = new System.Drawing.Size(229, 32);
            this.mintemplbl.TabIndex = 5;
            this.mintemplbl.Text = "Min Temperature:";
            // 
            // AddModalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1434, 767);
            this.Controls.Add(this.mintemplbl);
            this.Controls.Add(this.descriptiontextlbl);
            this.Controls.Add(this.descriptionlbl);
            this.Controls.Add(this.modalitytextlbl);
            this.Controls.Add(this.modalityNames);
            this.Controls.Add(this.modalitytitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddModalityForm";
            this.Text = "AddModalityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modalitytitle;
        private System.Windows.Forms.Label modalityNames;
        private System.Windows.Forms.TextBox modalitytextlbl;
        private System.Windows.Forms.Label descriptionlbl;
        private System.Windows.Forms.TextBox descriptiontextlbl;
        private System.Windows.Forms.Label mintemplbl;
    }
}
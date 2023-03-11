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
            this.name = new System.Windows.Forms.TextBox();
            this.descriptionlbl = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.mintemplbl = new System.Windows.Forms.Label();
            this.minTemp = new System.Windows.Forms.TextBox();
            this.maxtemplbl = new System.Windows.Forms.Label();
            this.maxTemp = new System.Windows.Forms.TextBox();
            this.Minairhumlbl = new System.Windows.Forms.Label();
            this.minAir = new System.Windows.Forms.TextBox();
            this.maxairhumlbl = new System.Windows.Forms.Label();
            this.maxAir = new System.Windows.Forms.TextBox();
            this.minsoilhumlbl = new System.Windows.Forms.Label();
            this.minSoil = new System.Windows.Forms.TextBox();
            this.maxsoilhumlbl = new System.Windows.Forms.Label();
            this.maxSoil = new System.Windows.Forms.TextBox();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modalitytitle
            // 
            this.modalitytitle.AutoSize = true;
            this.modalitytitle.Font = new System.Drawing.Font("Montserrat SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalitytitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modalitytitle.Location = new System.Drawing.Point(552, 35);
            this.modalitytitle.Name = "modalitytitle";
            this.modalitytitle.Size = new System.Drawing.Size(307, 51);
            this.modalitytitle.TabIndex = 0;
            this.modalitytitle.Text = "Add Modalities";
            this.modalitytitle.Click += new System.EventHandler(this.modalitytitle_Click);
            // 
            // modalityNames
            // 
            this.modalityNames.AutoSize = true;
            this.modalityNames.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalityNames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modalityNames.Location = new System.Drawing.Point(85, 157);
            this.modalityNames.Name = "modalityNames";
            this.modalityNames.Size = new System.Drawing.Size(204, 32);
            this.modalityNames.TabIndex = 1;
            this.modalityNames.Text = "Modality Name:";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(349, 160);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(185, 30);
            this.name.TabIndex = 2;
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionlbl.Location = new System.Drawing.Point(85, 228);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(161, 32);
            this.descriptionlbl.TabIndex = 3;
            this.descriptionlbl.Text = "Description:";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(349, 228);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(817, 82);
            this.description.TabIndex = 4;
            // 
            // mintemplbl
            // 
            this.mintemplbl.AutoSize = true;
            this.mintemplbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintemplbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mintemplbl.Location = new System.Drawing.Point(707, 352);
            this.mintemplbl.Name = "mintemplbl";
            this.mintemplbl.Size = new System.Drawing.Size(229, 32);
            this.mintemplbl.TabIndex = 5;
            this.mintemplbl.Text = "Min Temperature:";
            this.mintemplbl.Click += new System.EventHandler(this.mintemplbl_Click);
            // 
            // minTemp
            // 
            this.minTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTemp.Location = new System.Drawing.Point(981, 355);
            this.minTemp.Name = "minTemp";
            this.minTemp.Size = new System.Drawing.Size(185, 30);
            this.minTemp.TabIndex = 6;
            // 
            // maxtemplbl
            // 
            this.maxtemplbl.AutoSize = true;
            this.maxtemplbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxtemplbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxtemplbl.Location = new System.Drawing.Point(80, 352);
            this.maxtemplbl.Name = "maxtemplbl";
            this.maxtemplbl.Size = new System.Drawing.Size(234, 32);
            this.maxtemplbl.TabIndex = 7;
            this.maxtemplbl.Text = "Max Temperature:";
            // 
            // maxTemp
            // 
            this.maxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTemp.Location = new System.Drawing.Point(349, 355);
            this.maxTemp.Name = "maxTemp";
            this.maxTemp.Size = new System.Drawing.Size(185, 30);
            this.maxTemp.TabIndex = 8;
            // 
            // Minairhumlbl
            // 
            this.Minairhumlbl.AutoSize = true;
            this.Minairhumlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minairhumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minairhumlbl.Location = new System.Drawing.Point(709, 450);
            this.Minairhumlbl.Name = "Minairhumlbl";
            this.Minairhumlbl.Size = new System.Drawing.Size(227, 32);
            this.Minairhumlbl.TabIndex = 9;
            this.Minairhumlbl.Text = "Min Air Humidity:";
            // 
            // minAir
            // 
            this.minAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minAir.Location = new System.Drawing.Point(981, 453);
            this.minAir.Name = "minAir";
            this.minAir.Size = new System.Drawing.Size(185, 30);
            this.minAir.TabIndex = 10;
            // 
            // maxairhumlbl
            // 
            this.maxairhumlbl.AutoSize = true;
            this.maxairhumlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxairhumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxairhumlbl.Location = new System.Drawing.Point(80, 450);
            this.maxairhumlbl.Name = "maxairhumlbl";
            this.maxairhumlbl.Size = new System.Drawing.Size(232, 32);
            this.maxairhumlbl.TabIndex = 11;
            this.maxairhumlbl.Text = "Max Air Humidity:";
            // 
            // maxAir
            // 
            this.maxAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAir.Location = new System.Drawing.Point(349, 453);
            this.maxAir.Name = "maxAir";
            this.maxAir.Size = new System.Drawing.Size(185, 30);
            this.maxAir.TabIndex = 12;
            // 
            // minsoilhumlbl
            // 
            this.minsoilhumlbl.AutoSize = true;
            this.minsoilhumlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minsoilhumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minsoilhumlbl.Location = new System.Drawing.Point(709, 560);
            this.minsoilhumlbl.Name = "minsoilhumlbl";
            this.minsoilhumlbl.Size = new System.Drawing.Size(236, 32);
            this.minsoilhumlbl.TabIndex = 13;
            this.minsoilhumlbl.Text = "Min Soil Humidity:";
            // 
            // minSoil
            // 
            this.minSoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minSoil.Location = new System.Drawing.Point(981, 563);
            this.minSoil.Name = "minSoil";
            this.minSoil.Size = new System.Drawing.Size(185, 30);
            this.minSoil.TabIndex = 14;
            this.minSoil.TextChanged += new System.EventHandler(this.minsoilhumtxt_TextChanged);
            // 
            // maxsoilhumlbl
            // 
            this.maxsoilhumlbl.AutoSize = true;
            this.maxsoilhumlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxsoilhumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxsoilhumlbl.Location = new System.Drawing.Point(80, 560);
            this.maxsoilhumlbl.Name = "maxsoilhumlbl";
            this.maxsoilhumlbl.Size = new System.Drawing.Size(241, 32);
            this.maxsoilhumlbl.TabIndex = 15;
            this.maxsoilhumlbl.Text = "Max Soil Humidity:";
            // 
            // maxSoil
            // 
            this.maxSoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxSoil.Location = new System.Drawing.Point(349, 563);
            this.maxSoil.Name = "maxSoil";
            this.maxSoil.Size = new System.Drawing.Size(185, 30);
            this.maxSoil.TabIndex = 16;
            // 
            // Submitbtn
            // 
            this.Submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(187)))), ((int)(((byte)(92)))));
            this.Submitbtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbtn.ForeColor = System.Drawing.Color.White;
            this.Submitbtn.Location = new System.Drawing.Point(1119, 710);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(168, 49);
            this.Submitbtn.TabIndex = 17;
            this.Submitbtn.Text = "Save";
            this.Submitbtn.UseVisualStyleBackColor = false;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // AddModalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1452, 814);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.maxSoil);
            this.Controls.Add(this.maxsoilhumlbl);
            this.Controls.Add(this.minSoil);
            this.Controls.Add(this.minsoilhumlbl);
            this.Controls.Add(this.maxAir);
            this.Controls.Add(this.maxairhumlbl);
            this.Controls.Add(this.minAir);
            this.Controls.Add(this.Minairhumlbl);
            this.Controls.Add(this.maxTemp);
            this.Controls.Add(this.maxtemplbl);
            this.Controls.Add(this.minTemp);
            this.Controls.Add(this.mintemplbl);
            this.Controls.Add(this.description);
            this.Controls.Add(this.descriptionlbl);
            this.Controls.Add(this.name);
            this.Controls.Add(this.modalityNames);
            this.Controls.Add(this.modalitytitle);
            this.Name = "AddModalityForm";
            this.Text = "AddModalityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modalitytitle;
        private System.Windows.Forms.Label modalityNames;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label descriptionlbl;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label mintemplbl;
        private System.Windows.Forms.TextBox minTemp;
        private System.Windows.Forms.Label maxtemplbl;
        private System.Windows.Forms.TextBox maxTemp;
        private System.Windows.Forms.Label Minairhumlbl;
        private System.Windows.Forms.TextBox minAir;
        private System.Windows.Forms.Label maxairhumlbl;
        private System.Windows.Forms.TextBox maxAir;
        private System.Windows.Forms.Label minsoilhumlbl;
        private System.Windows.Forms.TextBox minSoil;
        private System.Windows.Forms.Label maxsoilhumlbl;
        private System.Windows.Forms.TextBox maxSoil;
        private System.Windows.Forms.Button Submitbtn;
    }
}
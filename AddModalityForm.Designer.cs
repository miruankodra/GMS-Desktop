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
            this.mintemptxt = new System.Windows.Forms.TextBox();
            this.maxtemplbl = new System.Windows.Forms.Label();
            this.maxtemptxt = new System.Windows.Forms.TextBox();
            this.Minairhumlbl = new System.Windows.Forms.Label();
            this.minairhumtxt = new System.Windows.Forms.TextBox();
            this.maxairhumlbl = new System.Windows.Forms.Label();
            this.maxairhumtxt = new System.Windows.Forms.TextBox();
            this.minsoilhumlbl = new System.Windows.Forms.Label();
            this.minsoilhumtxt = new System.Windows.Forms.TextBox();
            this.maxsoilhumlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // modalitytextlbl
            // 
            this.modalitytextlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalitytextlbl.Location = new System.Drawing.Point(349, 157);
            this.modalitytextlbl.Name = "modalitytextlbl";
            this.modalitytextlbl.Size = new System.Drawing.Size(185, 30);
            this.modalitytextlbl.TabIndex = 2;
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionlbl.Location = new System.Drawing.Point(85, 278);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(161, 32);
            this.descriptionlbl.TabIndex = 3;
            this.descriptionlbl.Text = "Description:";
            // 
            // descriptiontextlbl
            // 
            this.descriptiontextlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontextlbl.Location = new System.Drawing.Point(349, 280);
            this.descriptiontextlbl.Name = "descriptiontextlbl";
            this.descriptiontextlbl.Size = new System.Drawing.Size(185, 30);
            this.descriptiontextlbl.TabIndex = 4;
            // 
            // mintemplbl
            // 
            this.mintemplbl.AutoSize = true;
            this.mintemplbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintemplbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mintemplbl.Location = new System.Drawing.Point(85, 383);
            this.mintemplbl.Name = "mintemplbl";
            this.mintemplbl.Size = new System.Drawing.Size(229, 32);
            this.mintemplbl.TabIndex = 5;
            this.mintemplbl.Text = "Min Temperature:";
            this.mintemplbl.Click += new System.EventHandler(this.mintemplbl_Click);
            // 
            // mintemptxt
            // 
            this.mintemptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintemptxt.Location = new System.Drawing.Point(349, 388);
            this.mintemptxt.Name = "mintemptxt";
            this.mintemptxt.Size = new System.Drawing.Size(185, 30);
            this.mintemptxt.TabIndex = 6;
            // 
            // maxtemplbl
            // 
            this.maxtemplbl.AutoSize = true;
            this.maxtemplbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxtemplbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxtemplbl.Location = new System.Drawing.Point(85, 484);
            this.maxtemplbl.Name = "maxtemplbl";
            this.maxtemplbl.Size = new System.Drawing.Size(234, 32);
            this.maxtemplbl.TabIndex = 7;
            this.maxtemplbl.Text = "Max Temperature:";
            // 
            // maxtemptxt
            // 
            this.maxtemptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxtemptxt.Location = new System.Drawing.Point(349, 487);
            this.maxtemptxt.Name = "maxtemptxt";
            this.maxtemptxt.Size = new System.Drawing.Size(185, 30);
            this.maxtemptxt.TabIndex = 8;
            // 
            // Minairhumlbl
            // 
            this.Minairhumlbl.AutoSize = true;
            this.Minairhumlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minairhumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minairhumlbl.Location = new System.Drawing.Point(809, 157);
            this.Minairhumlbl.Name = "Minairhumlbl";
            this.Minairhumlbl.Size = new System.Drawing.Size(227, 32);
            this.Minairhumlbl.TabIndex = 9;
            this.Minairhumlbl.Text = "Min Air Humidity:";
            // 
            // minairhumtxt
            // 
            this.minairhumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minairhumtxt.Location = new System.Drawing.Point(1102, 157);
            this.minairhumtxt.Name = "minairhumtxt";
            this.minairhumtxt.Size = new System.Drawing.Size(185, 30);
            this.minairhumtxt.TabIndex = 10;
            // 
            // maxairhumlbl
            // 
            this.maxairhumlbl.AutoSize = true;
            this.maxairhumlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxairhumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxairhumlbl.Location = new System.Drawing.Point(805, 278);
            this.maxairhumlbl.Name = "maxairhumlbl";
            this.maxairhumlbl.Size = new System.Drawing.Size(232, 32);
            this.maxairhumlbl.TabIndex = 11;
            this.maxairhumlbl.Text = "Max Air Humidity:";
            // 
            // maxairhumtxt
            // 
            this.maxairhumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxairhumtxt.Location = new System.Drawing.Point(1102, 276);
            this.maxairhumtxt.Name = "maxairhumtxt";
            this.maxairhumtxt.Size = new System.Drawing.Size(185, 30);
            this.maxairhumtxt.TabIndex = 12;
            // 
            // minsoilhumlbl
            // 
            this.minsoilhumlbl.AutoSize = true;
            this.minsoilhumlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minsoilhumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minsoilhumlbl.Location = new System.Drawing.Point(801, 385);
            this.minsoilhumlbl.Name = "minsoilhumlbl";
            this.minsoilhumlbl.Size = new System.Drawing.Size(236, 32);
            this.minsoilhumlbl.TabIndex = 13;
            this.minsoilhumlbl.Text = "Min Soil Humidity:";
            // 
            // minsoilhumtxt
            // 
            this.minsoilhumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minsoilhumtxt.Location = new System.Drawing.Point(1102, 381);
            this.minsoilhumtxt.Name = "minsoilhumtxt";
            this.minsoilhumtxt.Size = new System.Drawing.Size(185, 30);
            this.minsoilhumtxt.TabIndex = 14;
            this.minsoilhumtxt.TextChanged += new System.EventHandler(this.minsoilhumtxt_TextChanged);
            // 
            // maxsoilhumlbl
            // 
            this.maxsoilhumlbl.AutoSize = true;
            this.maxsoilhumlbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxsoilhumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxsoilhumlbl.Location = new System.Drawing.Point(797, 484);
            this.maxsoilhumlbl.Name = "maxsoilhumlbl";
            this.maxsoilhumlbl.Size = new System.Drawing.Size(241, 32);
            this.maxsoilhumlbl.TabIndex = 15;
            this.maxsoilhumlbl.Text = "Max Soil Humidity:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1102, 480);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 30);
            this.textBox1.TabIndex = 16;
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
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = false;
            // 
            // AddModalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1452, 814);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maxsoilhumlbl);
            this.Controls.Add(this.minsoilhumtxt);
            this.Controls.Add(this.minsoilhumlbl);
            this.Controls.Add(this.maxairhumtxt);
            this.Controls.Add(this.maxairhumlbl);
            this.Controls.Add(this.minairhumtxt);
            this.Controls.Add(this.Minairhumlbl);
            this.Controls.Add(this.maxtemptxt);
            this.Controls.Add(this.maxtemplbl);
            this.Controls.Add(this.mintemptxt);
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
        private System.Windows.Forms.TextBox mintemptxt;
        private System.Windows.Forms.Label maxtemplbl;
        private System.Windows.Forms.TextBox maxtemptxt;
        private System.Windows.Forms.Label Minairhumlbl;
        private System.Windows.Forms.TextBox minairhumtxt;
        private System.Windows.Forms.Label maxairhumlbl;
        private System.Windows.Forms.TextBox maxairhumtxt;
        private System.Windows.Forms.Label minsoilhumlbl;
        private System.Windows.Forms.TextBox minsoilhumtxt;
        private System.Windows.Forms.Label maxsoilhumlbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Submitbtn;
    }
}
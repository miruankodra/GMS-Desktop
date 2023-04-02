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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modalities));
            this.AddModBtn = new System.Windows.Forms.Button();
            this.AddLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modalityname = new System.Windows.Forms.Label();
            this.templabel = new System.Windows.Forms.Label();
            this.airhumiditylbl = new System.Windows.Forms.Label();
            this.soilhumiditylbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Templbl = new System.Windows.Forms.Label();
            this.Airlbl = new System.Windows.Forms.Label();
            this.Soillbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // AddModBtn
            // 
            this.AddModBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddModBtn.Location = new System.Drawing.Point(148, 132);
            this.AddModBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddModBtn.Name = "AddModBtn";
            this.AddModBtn.Size = new System.Drawing.Size(147, 135);
            this.AddModBtn.TabIndex = 0;
            this.AddModBtn.Text = "+\r\n";
            this.AddModBtn.UseVisualStyleBackColor = true;
            this.AddModBtn.Click += new System.EventHandler(this.AddModBtn_Click);
            // 
            // AddLbl
            // 
            this.AddLbl.AutoSize = true;
            this.AddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLbl.ForeColor = System.Drawing.Color.White;
            this.AddLbl.Location = new System.Drawing.Point(119, 288);
            this.AddLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLbl.Name = "AddLbl";
            this.AddLbl.Size = new System.Drawing.Size(182, 31);
            this.AddLbl.TabIndex = 1;
            this.AddLbl.Text = "Add Modality";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Pranvere",
            "Vere",
            "Vjeshte ",
            "Dimer",
            "Patate",
            "Domate",
            "Barishtore"});
            this.comboBox1.Location = new System.Drawing.Point(477, 181);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(776, 47);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(471, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose modality";
            // 
            // modalityname
            // 
            this.modalityname.AutoSize = true;
            this.modalityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalityname.ForeColor = System.Drawing.Color.Transparent;
            this.modalityname.Location = new System.Drawing.Point(172, 430);
            this.modalityname.Name = "modalityname";
            this.modalityname.Size = new System.Drawing.Size(147, 22);
            this.modalityname.TabIndex = 4;
            this.modalityname.Text = "Modality Name:";
            // 
            // templabel
            // 
            this.templabel.AutoSize = true;
            this.templabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templabel.ForeColor = System.Drawing.Color.Transparent;
            this.templabel.Location = new System.Drawing.Point(172, 486);
            this.templabel.Name = "templabel";
            this.templabel.Size = new System.Drawing.Size(130, 22);
            this.templabel.TabIndex = 5;
            this.templabel.Text = "Temperature:";
            // 
            // airhumiditylbl
            // 
            this.airhumiditylbl.AutoSize = true;
            this.airhumiditylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airhumiditylbl.ForeColor = System.Drawing.Color.Transparent;
            this.airhumiditylbl.Location = new System.Drawing.Point(172, 542);
            this.airhumiditylbl.Name = "airhumiditylbl";
            this.airhumiditylbl.Size = new System.Drawing.Size(124, 22);
            this.airhumiditylbl.TabIndex = 6;
            this.airhumiditylbl.Text = "Air Humidity:";
            // 
            // soilhumiditylbl
            // 
            this.soilhumiditylbl.AutoSize = true;
            this.soilhumiditylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soilhumiditylbl.ForeColor = System.Drawing.Color.Transparent;
            this.soilhumiditylbl.Location = new System.Drawing.Point(172, 592);
            this.soilhumiditylbl.Name = "soilhumiditylbl";
            this.soilhumiditylbl.Size = new System.Drawing.Size(133, 22);
            this.soilhumiditylbl.TabIndex = 7;
            this.soilhumiditylbl.Text = "Soil Humidity:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 416);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(125, 473);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(125, 527);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(125, 578);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.ForeColor = System.Drawing.Color.Transparent;
            this.Namelbl.Location = new System.Drawing.Point(381, 431);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(57, 20);
            this.Namelbl.TabIndex = 12;
            this.Namelbl.Text = "Name";
            // 
            // Templbl
            // 
            this.Templbl.AutoSize = true;
            this.Templbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Templbl.ForeColor = System.Drawing.Color.Transparent;
            this.Templbl.Location = new System.Drawing.Point(381, 487);
            this.Templbl.Name = "Templbl";
            this.Templbl.Size = new System.Drawing.Size(115, 20);
            this.Templbl.TabIndex = 13;
            this.Templbl.Text = "Temperature";
            // 
            // Airlbl
            // 
            this.Airlbl.AutoSize = true;
            this.Airlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airlbl.ForeColor = System.Drawing.Color.Transparent;
            this.Airlbl.Location = new System.Drawing.Point(381, 542);
            this.Airlbl.Name = "Airlbl";
            this.Airlbl.Size = new System.Drawing.Size(113, 20);
            this.Airlbl.TabIndex = 14;
            this.Airlbl.Text = "Air Humidity";
            // 
            // Soillbl
            // 
            this.Soillbl.AutoSize = true;
            this.Soillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soillbl.ForeColor = System.Drawing.Color.Transparent;
            this.Soillbl.Location = new System.Drawing.Point(381, 593);
            this.Soillbl.Name = "Soillbl";
            this.Soillbl.Size = new System.Drawing.Size(121, 20);
            this.Soillbl.TabIndex = 15;
            this.Soillbl.Text = "Soil Humidity";
            // 
            // Modalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1452, 814);
            this.Controls.Add(this.Soillbl);
            this.Controls.Add(this.Airlbl);
            this.Controls.Add(this.Templbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.soilhumiditylbl);
            this.Controls.Add(this.airhumiditylbl);
            this.Controls.Add(this.templabel);
            this.Controls.Add(this.modalityname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddLbl);
            this.Controls.Add(this.AddModBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Modalities";
            this.Text = "Modalities";
            this.Load += new System.EventHandler(this.Modalities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddModBtn;
        private System.Windows.Forms.Label AddLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modalityname;
        private System.Windows.Forms.Label templabel;
        private System.Windows.Forms.Label airhumiditylbl;
        private System.Windows.Forms.Label soilhumiditylbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Templbl;
        private System.Windows.Forms.Label Airlbl;
        private System.Windows.Forms.Label Soillbl;
    }
}
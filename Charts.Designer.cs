﻿namespace GMS
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charts));
            this.GrafikTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.GrafikLageshtie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrafikLageshtieDheu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GMSINFO = new System.Windows.Forms.Label();
            this.Ownerlbl = new System.Windows.Forms.Label();
            this.Arealbl = new System.Windows.Forms.Label();
            this.Locationlbl = new System.Windows.Forms.Label();
            this.Userpic = new System.Windows.Forms.PictureBox();
            this.Areapic = new System.Windows.Forms.PictureBox();
            this.Locationpic = new System.Windows.Forms.PictureBox();
            this.Ownername = new System.Windows.Forms.Label();
            this.Owner = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.pdfExp = new System.Windows.Forms.Button();
            this.lablm2 = new System.Windows.Forms.Label();
            this.customInstaller2 = new MySql.Data.MySqlClient.CustomInstaller();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtieDheu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Userpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Areapic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Locationpic)).BeginInit();
            this.SuspendLayout();
            // 
            // GrafikTemp
            // 
            this.GrafikTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.GrafikTemp.BorderSkin.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.GrafikTemp.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.GrafikTemp.Legends.Add(legend1);
            this.GrafikTemp.Location = new System.Drawing.Point(491, 10);
            this.GrafikTemp.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.GrafikTemp.Name = "GrafikTemp";
            this.GrafikTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            this.GrafikTemp.Series.Add(series1);
            this.GrafikTemp.Size = new System.Drawing.Size(660, 202);
            this.GrafikTemp.TabIndex = 0;
            this.GrafikTemp.Text = "Grafik Temperature";
            this.GrafikTemp.Click += new System.EventHandler(this.GrafikTemp_Click);
            // 
            // GrafikLageshtie
            // 
            this.GrafikLageshtie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            chartArea2.Name = "ChartArea1";
            this.GrafikLageshtie.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            legend2.BorderWidth = 10;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.GrafikLageshtie.Legends.Add(legend2);
            this.GrafikLageshtie.Location = new System.Drawing.Point(491, 219);
            this.GrafikLageshtie.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.GrafikLageshtie.Name = "GrafikLageshtie";
            this.GrafikLageshtie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Lageshtia e ajrit";
            this.GrafikLageshtie.Series.Add(series2);
            this.GrafikLageshtie.Size = new System.Drawing.Size(674, 202);
            this.GrafikLageshtie.TabIndex = 1;
            this.GrafikLageshtie.Text = "Grafik Lageshtie ajri/dheu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(184, 517);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(204, 10);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GrafikLageshtieDheu
            // 
            this.GrafikLageshtieDheu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.GrafikLageshtieDheu.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.GrafikLageshtieDheu.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.GrafikLageshtieDheu.Legends.Add(legend3);
            this.GrafikLageshtieDheu.Location = new System.Drawing.Point(491, 444);
            this.GrafikLageshtieDheu.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.GrafikLageshtieDheu.Name = "GrafikLageshtieDheu";
            this.GrafikLageshtieDheu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Lageshtia e dheut";
            this.GrafikLageshtieDheu.Series.Add(series3);
            this.GrafikLageshtieDheu.Size = new System.Drawing.Size(674, 202);
            this.GrafikLageshtieDheu.TabIndex = 3;
            this.GrafikLageshtieDheu.Text = "Grafik Lageshtie së Dheut";
            this.GrafikLageshtieDheu.Click += new System.EventHandler(this.GrafikLageshtieDheu_Click);
            // 
            // GMSINFO
            // 
            this.GMSINFO.AutoSize = true;
            this.GMSINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GMSINFO.ForeColor = System.Drawing.Color.White;
            this.GMSINFO.Location = new System.Drawing.Point(28, 90);
            this.GMSINFO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GMSINFO.Name = "GMSINFO";
            this.GMSINFO.Size = new System.Drawing.Size(328, 31);
            this.GMSINFO.TabIndex = 4;
            this.GMSINFO.Text = "Greenhouse Information";
            // 
            // Ownerlbl
            // 
            this.Ownerlbl.AutoSize = true;
            this.Ownerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ownerlbl.Location = new System.Drawing.Point(111, 183);
            this.Ownerlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ownerlbl.Name = "Ownerlbl";
            this.Ownerlbl.Size = new System.Drawing.Size(80, 25);
            this.Ownerlbl.TabIndex = 5;
            this.Ownerlbl.Text = "Owner:";
            // 
            // Arealbl
            // 
            this.Arealbl.AutoSize = true;
            this.Arealbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arealbl.Location = new System.Drawing.Point(111, 249);
            this.Arealbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Arealbl.Name = "Arealbl";
            this.Arealbl.Size = new System.Drawing.Size(63, 25);
            this.Arealbl.TabIndex = 6;
            this.Arealbl.Text = "Area:";
            // 
            // Locationlbl
            // 
            this.Locationlbl.AutoSize = true;
            this.Locationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locationlbl.Location = new System.Drawing.Point(111, 319);
            this.Locationlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Locationlbl.Name = "Locationlbl";
            this.Locationlbl.Size = new System.Drawing.Size(100, 25);
            this.Locationlbl.TabIndex = 7;
            this.Locationlbl.Text = "Location:";
            // 
            // Userpic
            // 
            this.Userpic.Image = ((System.Drawing.Image)(resources.GetObject("Userpic.Image")));
            this.Userpic.Location = new System.Drawing.Point(29, 163);
            this.Userpic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Userpic.Name = "Userpic";
            this.Userpic.Size = new System.Drawing.Size(64, 64);
            this.Userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Userpic.TabIndex = 8;
            this.Userpic.TabStop = false;
            // 
            // Areapic
            // 
            this.Areapic.Image = ((System.Drawing.Image)(resources.GetObject("Areapic.Image")));
            this.Areapic.Location = new System.Drawing.Point(29, 231);
            this.Areapic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Areapic.Name = "Areapic";
            this.Areapic.Size = new System.Drawing.Size(64, 64);
            this.Areapic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Areapic.TabIndex = 9;
            this.Areapic.TabStop = false;
            this.Areapic.Click += new System.EventHandler(this.Areapic_Click);
            // 
            // Locationpic
            // 
            this.Locationpic.Image = ((System.Drawing.Image)(resources.GetObject("Locationpic.Image")));
            this.Locationpic.Location = new System.Drawing.Point(30, 299);
            this.Locationpic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Locationpic.Name = "Locationpic";
            this.Locationpic.Size = new System.Drawing.Size(64, 64);
            this.Locationpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Locationpic.TabIndex = 10;
            this.Locationpic.TabStop = false;
            // 
            // Ownername
            // 
            this.Ownername.AutoSize = true;
            this.Ownername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ownername.Location = new System.Drawing.Point(162, 185);
            this.Ownername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ownername.Name = "Ownername";
            this.Ownername.Size = new System.Drawing.Size(0, 15);
            this.Ownername.TabIndex = 11;
            // 
            // Owner
            // 
            this.Owner.AutoSize = true;
            this.Owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owner.Location = new System.Drawing.Point(191, 185);
            this.Owner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(0, 25);
            this.Owner.TabIndex = 12;
            this.Owner.Click += new System.EventHandler(this.Owner_Click);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.Location = new System.Drawing.Point(111, 359);
            this.Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(0, 25);
            this.Location.TabIndex = 14;
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(178, 249);
            this.Area.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(0, 25);
            this.Area.TabIndex = 15;
            // 
            // pdfExp
            // 
            this.pdfExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(187)))), ((int)(((byte)(92)))));
            this.pdfExp.FlatAppearance.BorderSize = 0;
            this.pdfExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdfExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfExp.Location = new System.Drawing.Point(33, 443);
            this.pdfExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pdfExp.Name = "pdfExp";
            this.pdfExp.Size = new System.Drawing.Size(178, 41);
            this.pdfExp.TabIndex = 16;
            this.pdfExp.Text = "Export All To PDF";
            this.pdfExp.UseVisualStyleBackColor = false;
            this.pdfExp.Click += new System.EventHandler(this.pdfExp_Click);
            // 
            // lablm2
            // 
            this.lablm2.AutoSize = true;
            this.lablm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablm2.Location = new System.Drawing.Point(228, 249);
            this.lablm2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lablm2.Name = "lablm2";
            this.lablm2.Size = new System.Drawing.Size(41, 25);
            this.lablm2.TabIndex = 17;
            this.lablm2.Text = "m2";
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1089, 661);
            this.Controls.Add(this.lablm2);
            this.Controls.Add(this.pdfExp);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Owner);
            this.Controls.Add(this.Ownername);
            this.Controls.Add(this.Locationpic);
            this.Controls.Add(this.Areapic);
            this.Controls.Add(this.Userpic);
            this.Controls.Add(this.Locationlbl);
            this.Controls.Add(this.Arealbl);
            this.Controls.Add(this.Ownerlbl);
            this.Controls.Add(this.GMSINFO);
            this.Controls.Add(this.GrafikLageshtieDheu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrafikLageshtie);
            this.Controls.Add(this.GrafikTemp);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Charts";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtieDheu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Userpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Areapic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Locationpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikTemp;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikLageshtie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikLageshtieDheu;
        private System.Windows.Forms.Label GMSINFO;
        private System.Windows.Forms.Label Ownerlbl;
        private System.Windows.Forms.Label Arealbl;
        private System.Windows.Forms.Label Locationlbl;
        private System.Windows.Forms.PictureBox Userpic;
        private System.Windows.Forms.PictureBox Areapic;
        private System.Windows.Forms.PictureBox Locationpic;
        private System.Windows.Forms.Label Ownername;
        private System.Windows.Forms.Label Owner;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button pdfExp;
        private System.Windows.Forms.Label lablm2;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller2;
    }
}
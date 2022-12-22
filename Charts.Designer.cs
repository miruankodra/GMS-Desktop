namespace GMS
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
            this.GrafikTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.GrafikLageshtie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrafikLageshtieDheu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtieDheu)).BeginInit();
            this.SuspendLayout();
            // 
            // GrafikTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.GrafikTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GrafikTemp.Legends.Add(legend1);
            this.GrafikTemp.Location = new System.Drawing.Point(564, 14);
            this.GrafikTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrafikTemp.Name = "GrafikTemp";
            this.GrafikTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            this.GrafikTemp.Series.Add(series1);
            this.GrafikTemp.Size = new System.Drawing.Size(861, 223);
            this.GrafikTemp.TabIndex = 0;
            this.GrafikTemp.Text = "Grafik Temperature";
            this.GrafikTemp.Click += new System.EventHandler(this.GrafikTemp_Click);
            // 
            // GrafikLageshtie
            // 
            chartArea2.Name = "ChartArea1";
            this.GrafikLageshtie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GrafikLageshtie.Legends.Add(legend2);
            this.GrafikLageshtie.Location = new System.Drawing.Point(564, 271);
            this.GrafikLageshtie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrafikLageshtie.Name = "GrafikLageshtie";
            this.GrafikLageshtie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Lageshtia e ajrit";
            this.GrafikLageshtie.Series.Add(series2);
            this.GrafikLageshtie.Size = new System.Drawing.Size(873, 250);
            this.GrafikLageshtie.TabIndex = 1;
            this.GrafikLageshtie.Text = "Grafik Lageshtie ajri/dheu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 636);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(272, 12);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GrafikLageshtieDheu
            // 
            chartArea3.Name = "ChartArea1";
            this.GrafikLageshtieDheu.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.GrafikLageshtieDheu.Legends.Add(legend3);
            this.GrafikLageshtieDheu.Location = new System.Drawing.Point(564, 548);
            this.GrafikLageshtieDheu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrafikLageshtieDheu.Name = "GrafikLageshtieDheu";
            this.GrafikLageshtieDheu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Lageshtia e dheut";
            this.GrafikLageshtieDheu.Series.Add(series3);
            this.GrafikLageshtieDheu.Size = new System.Drawing.Size(873, 250);
            this.GrafikLageshtieDheu.TabIndex = 3;
            this.GrafikLageshtieDheu.Text = "Grafik Lageshtie së Dheut";
            this.GrafikLageshtieDheu.Click += new System.EventHandler(this.GrafikLageshtieDheu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1452, 814);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrafikLageshtieDheu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrafikLageshtie);
            this.Controls.Add(this.GrafikTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Charts";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtieDheu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikTemp;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikLageshtie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikLageshtieDheu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
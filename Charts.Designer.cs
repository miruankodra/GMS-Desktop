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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GrafikTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.GrafikLageshtie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Loadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrafikTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.GrafikTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GrafikTemp.Legends.Add(legend1);
            this.GrafikTemp.Location = new System.Drawing.Point(23, 12);
            this.GrafikTemp.Name = "GrafikTemp";
            this.GrafikTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            this.GrafikTemp.Series.Add(series1);
            this.GrafikTemp.Size = new System.Drawing.Size(493, 223);
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
            this.GrafikLageshtie.Location = new System.Drawing.Point(23, 264);
            this.GrafikLageshtie.Name = "GrafikLageshtie";
            this.GrafikLageshtie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Lageshtia e ajrit";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Lageshtia e dheut";
            this.GrafikLageshtie.Series.Add(series2);
            this.GrafikLageshtie.Series.Add(series3);
            this.GrafikLageshtie.Size = new System.Drawing.Size(493, 250);
            this.GrafikLageshtie.TabIndex = 1;
            this.GrafikLageshtie.Text = "Grafik Lageshtie ajri/dheu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(600, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(272, 291);
            this.dataGridView1.TabIndex = 2;
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(748, 447);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(124, 38);
            this.Loadbtn.TabIndex = 3;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(898, 548);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrafikLageshtie);
            this.Controls.Add(this.GrafikTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Charts";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikLageshtie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikTemp;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikLageshtie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Loadbtn;
    }
}
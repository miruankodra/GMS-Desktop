using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GMS
{
    public partial class Charts : Form
    {
        string gh_id;
        public Charts(string gh)
        {
            InitializeComponent();
            gh_id = gh;
        }

        static string Myconnectionstring = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
        MySqlConnection connection = new MySqlConnection(Myconnectionstring);
        private void Charts_Load(object sender, EventArgs e)
        {
            //Lidhja e butonit load me datagriedview
            try
            {
                string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
                string Query = "SELECT * FROM statistics WHERE greenhouse_id='" + gh_id + "'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(); sda.SelectCommand = cmd;
                DataTable dbtable = new DataTable();
                sda.Fill(dbtable);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbtable;
                dataGridView1.DataSource = bsource;
                sda.Update(dbtable);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Console.WriteLine(dataGridView1.Rows.Count);
            Console.WriteLine(dataGridView1.Rows[0].Cells[0].Value);
            Console.WriteLine(dataGridView1.Rows[0].Cells[1].Value);
            double x = 0;
            double y = 0;


            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                x = double.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                y = double.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                GrafikTemp.Series[0].Points.AddXY(x, y);

                GrafikLageshtie.Series[0].Points.AddXY(x, y);
            }

        }

      

        //public void Chart()
        //{
        //    connection.Open();
        //    try {
        //        MySqlCommand cmd = connection.CreateCommand();
        //        cmd.CommandText = "Select temp_avg, day from statistics where gh_id='" + gh_id + "'";
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (connection.State == ConnectionState.Open)
        //            connection.Close();
        //    }
        //}

        private void GrafikTemp_Click(object sender, EventArgs e)
        {

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Graphbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

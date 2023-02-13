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

namespace GMS
{
    public partial class AddModalityForm : Form
    {

        MySqlConnection con;
        static string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";

        public AddModalityForm()
        {
            InitializeComponent();
        }

        private void mintemplbl_Click(object sender, EventArgs e)
        {

        }

        private void minsoilhumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void modalitytitle_Click(object sender, EventArgs e)
        {

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            con.ConnectionString = conString;

         


            string query = "INSERT INTO modalities (name, description,max_temperature,min_temperature,max_air_humidity,min_air_humidity,max_soil_humidity,min_soil_humidity) VALUES('"+name.Text+"','"+description.Text+ "','"+maxTemp.Text+ "','"+minTemp+ "','"+maxAir.Text+ "','"+minAir.Text+ "','"+maxSoil.Text+"','"+minSoil.Text+"')";
            con.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modality saved! You can activate modality from the dropdown in the modality menu.");
                this.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                throw;
            }

            

        }
    }
}

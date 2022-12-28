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
    public partial class Modalities : Form
    {
        MySqlConnection con;
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
        public string gh_id;
        public Modalities(string gh_id)
        {
            InitializeComponent();
            this.gh_id = gh_id;
        }

        private void Modalities_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            con.ConnectionString = conString;


            string query = "SELECT name, description, temperature, air_humidity, soil_humidity, enabled FROM modalities WHERE greenhouse_id = '" + gh_id + "'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridViewModalities.DataSource = dt;

        }

        private void dataGridViewModalities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

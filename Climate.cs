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

namespace GMS
{
    public partial class Climate : Form
    {

        MySqlConnection con;
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
        public string gh;
        public string temp;
        public string air_hum;
        public string soil_hum;
        public Climate(string gh)
        {
            InitializeComponent();
            this.gh = gh;
        }

        private void AirHumidity_Click(object sender, EventArgs e)
        {

        }

        private void AirHumiditypercent_Click(object sender, EventArgs e)
        {

        }

        private void Climate_Load(object sender, EventArgs e)
        {

            con = new MySqlConnection();
            con.ConnectionString = conString;


            string query = "SELECT * FROM climates WHERE greenhouse_id = '" + gh + "'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                temp = row["temp"].ToString();
                air_hum = row["air_humid"].ToString(); 
                soil_hum = row["soil_humid"].ToString();
            }

            TempLbl.Text = temp;
            ahLbl.Text = air_hum;
            shLbl.Text = soil_hum;


        }

        private void TempParameters_Click(object sender, EventArgs e)
        {

        }
    }
}

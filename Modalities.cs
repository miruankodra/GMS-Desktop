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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace GMS
{
    public partial class Modalities : Form
    {

        MySqlConnection con;
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
        public string gh_id;
        private object mainPanel;
        private string modalityId;
        public string name;
        public string description;
        public string temp_min;
        public string temp_max;
        public string air_min;
        public string air_max;
        public string soil_min;
        public string soil_max;
       

        public Modalities(string gh_id, string modalityId)
        {
            InitializeComponent();
            this.gh_id = gh_id;
            this.modalityId= modalityId;
        }

        private void Modalities_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            con.ConnectionString = conString;


            string query = "SELECT * FROM modalities WHERE id = '" + modalityId + "'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                name = row["name"].ToString();
                description = row["description"].ToString();
                temp_max = row["max_temperature"].ToString();
                temp_min = row["min_temperature"].ToString();
                air_max = row["max_air_humidity"].ToString();
                air_min = row["min_air_humidity"].ToString();
                soil_max = row["max_soil_humidity"].ToString();
                soil_min = row["min_soil_humidity"].ToString();
            }
            Namelbl.Text = name;
            Templbl.Text = $"{temp_min} - {temp_max}";
            Airlbl.Text = $"{air_min} - {air_max}";
            Soillbl.Text = $"{soil_min} - {soil_max}";
        }

        private void dataGridViewModalities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void AddModBtn_Click(object sender, EventArgs e)
        {
            AddModalityForm openform = new AddModalityForm(gh_id);
            openform.Show();

          
        }
    }
}
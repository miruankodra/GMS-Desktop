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
            

        }

      

        public void Chart()
        {
            connection.Open();
            try {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select temp_avg, day from daily_stats where gh_id='" + gh_id + "'";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void GrafikTemp_Click(object sender, EventArgs e)
        {

        }
    }
}

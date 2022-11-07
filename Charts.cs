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
        public Charts()
        {
            InitializeComponent();
        }

        static string Myconnectionstring = "SERVER=127.0.0.1;PORT=3306;DATABASE=gms;UID=root;PASSWORD= ";
        MySqlConnection connection = new MySqlConnection(Myconnectionstring);
        private void Charts_Load(object sender, EventArgs e)
        {
            

        }

      

        public void Chart()
        {
            connection.Open();
            try {
                MySqlCommand cmd = connection.CreateCommand();
               // cmd.CommandText = "Select * from daily_statistic where gh_id='" + gh_id.Text.ToString() + "'";
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace GMS
{
    public partial class LoginForm : Form
    {
        MySqlConnection con;
        public string conString = "SERVER=127.0.0.1;PORT=3306;DATABASE=gms;UID=root;PASSWORD=";
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            try
            {
                con = new MySqlConnection();
                con.ConnectionString = conString;
                con.Open();
                MessageBox.Show("Connected!");
               // string query = $"SELECT * FROM GMS_USERS";
               // MySqlDataAdapter dt = new MySqlDataAdapter();
               // dt.SelectCommand = new MySqlCommand(query, con);

               // DataTable tab = new DataTable();
               // dt.Fill(tab);


               // dataGridView1.DataSource = tab;


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

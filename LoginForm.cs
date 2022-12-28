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
using System.Windows.Forms.DataVisualization.Charting;


namespace GMS
{
    public partial class LoginForm : Form
    {
        MySqlConnection con;
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
        public string usr_id;

        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please provide Username AND Password");
                return;
            }
            try
            {
                //Create SqlConnection
                con = new MySqlConnection();
                con.ConnectionString = conString;
                
                string query = "SELECT * FROM users WHERE username = '" + username.Text + "' AND password = '" + password.Text + "'";
       
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = new MySqlCommand(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                con.Close();

                if (dt.Rows.Count == 1)
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        usr_id = row["id"].ToString();
                    }


                    this.Hide();

                    Form Dashboard = new DashboardForm(usr_id);
                    Dashboard.ShowDialog();



                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }

        private void regLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm Signup = new RegisterForm();
            this.Hide();
            Signup.ShowDialog();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

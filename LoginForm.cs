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
                
                string query = "SELECT * FROM GMS_USERS WHERE username = '" + username.Text + "' AND passkey = '" + password.Text + "'";
       
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = new MySqlCommand(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                con.Close();

                if (dt.Rows.Count == 1)
                {


                    MessageBox.Show("Login Successful!");
                    this.Hide();

                    Form Dashboard = new Dashboard(username.Text);
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
            Signup.ShowDialog();
            this.Hide();
        }
    }
}

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
    public partial class RegisterForm : Form
    {
        MySqlConnection con;
        public string conString = "SERVER=127.0.0.1;PORT=3306;DATABASE=gms;UID=root;PASSWORD=";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TermsServices_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (newPass.Text == confirmPass.Text && agreement.Checked == true)
            {
                con = new MySqlConnection();
                con.ConnectionString = conString;
                con.Open();
                string phoneNumber = prefix.Text + phone.Text;
                string query = $"INSERT INTO `gms_users` (`firstname`, `lastname`, `email`, `username`, `passkey`, `phone`, `country`, `city`, `birthday`, `active`) VALUES('" + firstname.Text + "','" + lastname.Text + "','" + email.Text + "','" + newUsername.Text + "','" + newPass.Text + "','" + phoneNumber + "','" + country.Text + "','" + city.Text + "','" + Birthday.Text + "',0)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();

                string message = "Successfully Inserted";
                MessageBox.Show(message);


            }


            string messages = "Not added in database";
            MessageBox.Show(messages);


        }
    }
}


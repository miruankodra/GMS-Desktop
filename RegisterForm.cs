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
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
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
                string query = $"INSERT INTO `users` (`firstname`, `lastname`, `email`, `username`, `password`, `phone`, `country`, `city`, `active`) VALUES('" + firstname.Text + "','" + lastname.Text + "','" + email.Text + "','" + newUsername.Text + "','" + newPass.Text + "','" + phoneNumber + "','" + country.Text + "','" + city.Text + "',0)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();

                string message = "Successfully Inserted";
                MessageBox.Show(message);

               

            }


            string messages = "Fill all fields";
            MessageBox.Show(messages);


        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}


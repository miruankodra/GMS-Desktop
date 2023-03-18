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
    public partial class ResetPassword : Form
    {
        MySqlConnection con;
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";

        string email = ForgotPassword.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            string password = newpassword.Text;
            if (newpassword.Text == password)
            {

                string q = "update [users] set [password]='" + password + "'where email='" + email + "'";
                MySqlCommand cmd = new MySqlCommand(q, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Password successfully changed!");
            }

            else
            {
                MessageBox.Show("Your New Password doesn't match!");
            }
            

    
          
        }
    }
}

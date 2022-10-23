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

namespace GMS
{
    public partial class LoginForm : Form
    {
        public string conString = "Data Source=127.0.0.1;Initial Catalog=gms;Integrated Security=True;User ID=root;Password=";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            string query = "SELECT * FROM gms_users";

            
        }
    }
}

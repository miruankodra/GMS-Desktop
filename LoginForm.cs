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

       
    }
}

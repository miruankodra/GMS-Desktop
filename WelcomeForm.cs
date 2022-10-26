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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void loginFormCaller_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.ShowDialog();
            this.Hide();
        }

        private void signupCaller_Click(object sender, EventArgs e)
        {
            RegisterForm Signup = new RegisterForm();
            Signup.ShowDialog();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GMS_Click(object sender, EventArgs e)
        {

        }
    }
}

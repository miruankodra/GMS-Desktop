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
    public partial class DashboardForm : Form
    {
        MySqlConnection con;
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";

        string username;
        string id;
       public DashboardForm(string usr)
        {
          InitializeComponent();
          username = usr;
            
        }

        private void TopPanelDash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoardBtn_MouseHover(object sender, EventArgs e)
        {
          
        }

        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }
        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            con.ConnectionString = conString;


           string query = "SELECT gh_id * from greenhouses WHERE username = '" + username + "'";
           con.Open();
           MySqlDataAdapter da = new MySqlDataAdapter();
           da.SelectCommand = new MySqlCommand(query, con);

           DataTable dt = new DataTable();

            da.Fill(dt);
           // foreach(DataRow dr in dt.Rows)
            {
             //  id = dt.row["gh_id"];
            }

            loadform(new Charts());


            
        }

        private void ClimateBtn_Click(object sender, EventArgs e)
        {
            loadform(new Climate());
        }

        private void ControlPanelBtn_Click(object sender, EventArgs e)
        {
            loadform(new ControlPanel());
        }

        private void ModalitetBtn_Click(object sender, EventArgs e)
        {
            loadform(new Modalities());
        }
    }
}

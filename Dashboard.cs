using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GMS
{
    public partial class DashboardForm : Form
    {
        MySqlConnection con;
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";

        
        string user_id;
        string greenhouse_id;
        string modalityId;
        string gh_name;
        string area;
        string location;
       public DashboardForm(string greenhouse_id, string user_id)
        {
            InitializeComponent();
            this.greenhouse_id = greenhouse_id;
            this.user_id = user_id;
        }



        private void TopPanelDash_Paint(object sender, PaintEventArgs e)
        {

        }


      


        private void Dashboard_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            con.ConnectionString = conString;


            string query = "SELECT * from greenhouses WHERE id = '" + greenhouse_id + "'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                //greenhouse_id = row["id"].ToString();
                area = row["area"].ToString();
                location = row["location"].ToString();
                gh_name = row["name"].ToString();

            }
            gmsName.Text = gh_name;

            loadform(new Charts(greenhouse_id, user_id, area, location));
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
            loadform(new Charts(greenhouse_id, user_id, area, location));  
        }

        private void ClimateBtn_Click(object sender, EventArgs e)
        {
           
            loadform(new Climate(greenhouse_id));
        }

        private void ControlPanelBtn_Click(object sender, EventArgs e)
        {
            loadform(new ControlPanel());
        }

        private void ModalitetBtn_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            con.ConnectionString = conString;


            string modlaity_id_query = "SELECT modality_id FROM bots WHERE greenhouse_id = '" + greenhouse_id + "'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(modlaity_id_query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                modalityId = row["modality_id"].ToString();
            }

            loadform(new Modalities(greenhouse_id, modalityId));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gmsName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Botbtn_Click(object sender, EventArgs e)
        {
            loadform(new Form1());
        }

        private void Userprofilebtn_Click(object sender, EventArgs e)
        {
            loadform(new UserProfile(user_id));
        }

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void usermanagementbtn_Click(object sender, EventArgs e)
        {
            loadform(new UserManagement(greenhouse_id));
        }
    }
}

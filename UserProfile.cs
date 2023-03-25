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
    public partial class UserProfile : Form
    {
        MySqlConnection con;
        static string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
        public string userId;
        public UserProfile(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            string firstnameCol = "";
            string lastnameCol = "";
            string usernameCol = "";
            string emailCol = "";
            string phoneCol = "";
            string cityCol = "";
            string addressCol = "";
            string zipCol = "";


            con = new MySqlConnection();
            con.ConnectionString = conString;



            string query = "SELECT * FROM users WHERE id = '" + userId + "'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                firstnameCol = row["firstname"].ToString();
                lastnameCol = row["lastname"].ToString();
                usernameCol = row["username"].ToString();
                emailCol = row["email"].ToString();
                phoneCol = row["phone"].ToString();
                cityCol = row["city"].ToString();
                addressCol = row["address"].ToString();
                zipCol = row["zip"].ToString();
            }

            firstname.Text = firstnameCol;
            lastname.Text = lastnameCol;
            username.Text = usernameCol;
            email.Text = emailCol;
            phone.Text = phoneCol;
            city.Text = cityCol;  
            address.Text = addressCol;
            zip.Text = zipCol;


        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GMS
{
    public partial class UserManagement : Form
    {
        MySqlDataAdapter da;

        DataTable dt;
        MySqlCommandBuilder scb;
        MySqlConnection con;
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
        public string ghId;

        public int index { get; private set; }

        public UserManagement(string ghId)
        {
            InitializeComponent();
            this.ghId = ghId;
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            //con = new MySqlConnection();
            //con.ConnectionString = conString;
            //con.Open();
            //sda = new MySqlDataAdapter("@Select * FROM users", con);
            con = new MySqlConnection();
            con.ConnectionString = conString;

            string query = "SELECT * FROM users WHERE greenhouse_id = '"+ghId+"'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(query, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            con.ConnectionString = conString;

            string query = "SELECT * FROM users WHERE greenhouse_id = '" + ghId + "'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(query, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void searchtext_KeyDown(object sender, KeyEventArgs e)
        {
            con = new MySqlConnection();
            con.ConnectionString = conString;

            string query = "SELECT * FROM users WHERE greenhouse_id = '" + ghId + "'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(query, con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(index);
        }
    }
    }


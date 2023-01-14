using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Linq;

namespace GMS
{
    public partial class Charts : Form
    {
       


        MySqlConnection con;
        static string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";


        string id;
        string gh_id;
        string firstname;
        string lastname;
        string area;
        string location;

        public Charts(string gh, string uid, string area, string location)
        {

            InitializeComponent();
            gh_id = gh;
            id = uid;
            this.area = area;
            this.location = location;
        }

        MySqlConnection connection = new MySqlConnection(conString);
       

        private void Charts_Load(object sender, EventArgs e)
        {

            con = new MySqlConnection();
            con.ConnectionString = conString;


            string query = "SELECT firstname, lastname from users WHERE id = '" + id + "'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = new MySqlCommand(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);
           
            foreach (DataRow row in dt.Rows)
            {
                firstname = row["firstname"].ToString();
                lastname = row["lastname"].ToString();
            }
            Owner.Text = firstname + " " + lastname;
            Area.Text = area;
            Location.Text = location;


            //Lidhja e butonit load me datagriedview
            try
            {
                string Query = "SELECT * FROM statistics WHERE greenhouse_id='" + gh_id + "'";
                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(); sda.SelectCommand = cmd;
                DataTable dbtable = new DataTable();
                sda.Fill(dbtable);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbtable;
                dataGridView1.DataSource = bsource;
                sda.Update(dbtable);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Console.WriteLine(dataGridView1.Rows.Count);
            Console.WriteLine(dataGridView1.Rows[0].Cells[0].Value);
            Console.WriteLine(dataGridView1.Rows[0].Cells[1].Value);
            double x = 0;
            double y = 0;


            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                x = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                y = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
               
                GrafikTemp.Series[0].Points.AddXY(x, y);
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                x = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                y = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());



                GrafikLageshtie.Series[0].Points.AddXY(x, y);
             

            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                x = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                y = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());



                GrafikLageshtieDheu.Series[0].Points.AddXY(x, y);


            }
            //GrafikTemp.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Red;
            //Chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Red;
            GrafikTemp.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            GrafikLageshtie.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            GrafikLageshtieDheu.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            GrafikTemp.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            GrafikLageshtie.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            GrafikLageshtieDheu.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;



        }

      

        //public void Chart()
        //{
        //    connection.Open();
        //    try {
        //        MySqlCommand cmd = connection.CreateCommand();
        //        cmd.CommandText = "Select temp_avg, day from statistics where gh_id='" + gh_id + "'";
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (connection.State == ConnectionState.Open)
        //            connection.Close();
        //    }
        //}

        private void GrafikTemp_Click(object sender, EventArgs e)
        {

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Graphbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrafikLageshtieDheu_Click(object sender, EventArgs e)
        {

        }

        private void Owner_Click(object sender, EventArgs e)
        {
         
        }

       

        private void Areapic_Click(object sender, EventArgs e)
        {

        }

        private void pdfExp_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\user\\Desktop\\Diploma\\Mirigay.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("Miri gay");
            var bmp = new Bitmap(GrafikLageshtie.Width,GrafikLageshtie.Height);
            // doc.Add(GrafikLageshtie.DrawToBitmap(bmp, new Rectangle(0, 0, GrafikLageshtie.Width, GrafikLageshtie.Height)));
            //iTextSharp.text.Image img = new iTextSharp.text.Image(GrafikLageshtie.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, GrafikLageshtie.Width, GrafikLageshtie.Height)));
            doc.Add(p1);
            //doc.Add();
            doc.Close();
        }
    }
}


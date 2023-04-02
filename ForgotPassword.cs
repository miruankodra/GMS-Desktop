using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Google.Protobuf.WellKnownTypes;

namespace GMS
{
    public partial class ForgotPassword : Form
    {

        MySqlConnection con;
        public string conString = "SERVER=185.146.22.249;PORT=3306;DATABASE=gmsal_gms;UID=gmsal_gms;PASSWORD=gms123al456!!!";
        public string backendUri = "https://gms.al/api/v1";

        string randomcode;
        public static string to;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        static async Task<string> SendMail(string email, string endpoint)
        {
            var httpClient = new HttpClient();
            var jsonBody = "{\"email\": \"{email}\"}";
            var postData = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(endpoint, postData);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
                //Console.WriteLine(content);
            }
            else
            {
                MessageBox.Show($"Failed with status code {response.StatusCode}");
                return null;
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            //   string from, pass, messagebody;
            //  Random rand = new Random();
            //   randomcode = (rand.Next(999999)).ToString();
            //   MailMessage message = new MailMessage();
            //   to = (textBox1.Text).ToString();
            //   from = "gmsalbania@gmail.com";
            //  pass = "rupi12rupi";
            // messagebody = $"Your Reset Code is {randomcode}";
            // message.To.Add(to);
            // message.From = new MailAddress(from);
            // message.Body = messagebody;
            // message.Subject = "Password Reset Code ";
            // SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            // smtp.EnableSsl = true;
            // smtp.Port = 3306;
            // smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            // smtp.Credentials = new NetworkCredential(from, pass);
            // try
            // {
            //     smtp.Send(message);
            //     MessageBox.Show("Code successfully send!");
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message);

            //}




            // Set up the email message
            //MailMessage message = new MailMessage();
            //message.From = new MailAddress("support@gms.al");
            //message.To.Add("miruankodra@gmail.com");
            //message.Subject = "GMS";
            //message.Body = "Bac u kry!";

            //// Set up the SMTP client
            //SmtpClient smtpClient = new SmtpClient("gms.al", 465);
            //smtpClient.EnableSsl = true;
            //smtpClient.Credentials = new NetworkCredential("support@gms.al", "Y9x)R%MJXS,3");

            //// Send the email
            //smtpClient.Send(message);

            string endpoint = "/password/reset/request";
            string url = backendUri + endpoint;

            var content = await SendMail(email.Text, url);

            if (content != null)
            {
                var responseData = JsonConvert.DeserializeObject<ResponseData>(content);
                Console.WriteLine($"Name: {responseData}");
            }
            else
            {
                Console.WriteLine("Failed to get API response.");
            }



        }

        private void verify_Click(object sender, EventArgs e)
        {
            if (randomcode == (textBox2.Text).ToString())
            {
                to = textBox2.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }
    }
}

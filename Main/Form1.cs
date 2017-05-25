using Assignment3.Models;
using Assignment3.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorClient;
using System.Threading;

namespace Main
{
    public partial class Form1 : Form
    {
        public HttpClient client;
        public Form1()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60050/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();
        }


        
        private void login()
        {
            User user = new User();
            int id = Convert.ToInt32(textBox1.Text);
            
            try
            {
                HttpResponseMessage response = client.GetAsync("api/getUser/" + id).Result;
               // MessageBox.Show(response.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var userLoged = response.Content.ReadAsAsync<User>().Result;
                    user = userLoged;                   
                    Security secure = new Security();
                    if (secure.VerifyHash(textBox2.Text, user.password))
                    {

                        MessageBox.Show("Welcome");
                        if (user.tip.Equals("d"))
                        {
                            Form FormD = new DoctorClient.Form1();
                            FormD.Show();
                        }
                        else
                            if (user.tip.Equals("a"))
                        {
                            Form FormA = new SecretaryClient.FormS();
                            FormA.Show();
                            /*ThreadStart threadDelagate = new ThreadStart(DoctorClient.Program.getNotify);
                            Thread secThread = new Thread(threadDelagate);
                            secThread.Start();*/
                        }
                        else
                        {
                            Form FormS = new AdministratorClient.Form1();

                            // newDoctor.Start();
                            FormS.Show();
                        }
                       
                    }
                    else
                        MessageBox.Show("Wrong password");
                }
                else
                {
                    MessageBox.Show("sorry");
                }
            }
            catch (AggregateException exe)
            {
                //MessageBox.Show(exe.Message);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }
        private void enterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}

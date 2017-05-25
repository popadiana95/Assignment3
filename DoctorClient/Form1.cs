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

namespace DoctorClient
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

        private void view_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idPatient_tb.Text);
            try
            {
                HttpResponseMessage response = client.GetAsync("api/getHistory/"+id).Result;
                MessageBox.Show(response.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var schedules = response.Content.ReadAsAsync<IEnumerable<Schedule>>().Result;
                    dataGridViewHistory.DataSource = schedules;
                    MessageBox.Show("corect output");
                    MessageBox.Show(response.ToString());
                }
                else
                {
                    MessageBox.Show("sorry");
                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
            
        }
        public static void showMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}

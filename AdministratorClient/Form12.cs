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

namespace AdministratorClient
{
    public partial class Form1 : Form
    {
       
        public HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60050/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public void view_btnClick(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = client.GetAsync("api/patient").Result;
                if (response.IsSuccessStatusCode)
                {
                    var patients = response.Content.ReadAsAsync<IEnumerable<Patient>>().Result;
                    dataGridViewPatients.DataSource = patients;
                    MessageBox.Show(response.ToString());
                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }


        }
        public void viewS_btnClick(object sender, EventArgs e)
        {
               //HttpClient client = new HttpClient();
              //client.BaseAddress = new Uri("http://localhost:60050/");

              //int id = Convert.ToInt32(patientID_tb.Text);
              client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = client.GetAsync("api/schedule").Result;
                if (response.IsSuccessStatusCode)
                {
                    var scheduals = response.Content.ReadAsAsync<IEnumerable<Schedule>>().Result;
                    dataGridViewSchedules.DataSource = scheduals;

                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
            MessageBox.Show("Ai apasat");
           // dataGridViewSchedules.DataSource = ScheduleProvider.GetPatientSchadule(1234);
        }
        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                Patient patient = dataGridViewPatients.SelectedRows[0].DataBoundItem as Patient;
                if (patient != null)
                {

                    patientID_tb.Text = patient.idPatient.ToString();
                    pnc_tb.Text = patient.cnp;
                    name_tb.Text = patient.name;
                    birthDate_tb.Text = patient.birthDate.ToString();
                    address_tb.Text = patient.address;
                    
                }
            }
        }
        private void updatePatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.idPatient = Convert.ToInt32(patientID_tb.Text);
            patient.cnp = pnc_tb.Text;
            patient.birthDate = Convert.ToDateTime(birthDate_tb.Text);
            patient.address = address_tb.Text;
            patient.name = name_tb.Text;
            try
            {
                
                HttpResponseMessage response = client.PostAsJsonAsync("api/updatePatient", patient).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update realizat cu succes");
                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        private void addPatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.idPatient = Convert.ToInt32(patientID_tb.Text);
            patient.cnp = pnc_tb.Text;
            patient.birthDate = Convert.ToDateTime(birthDate_tb.Text);
            patient.address = address_tb.Text;
            patient.name = name_tb.Text;
            try
            {

                HttpResponseMessage response = client.PostAsJsonAsync("api/addPatient", patient).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update realizat cu succes");
                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

       
    }
}

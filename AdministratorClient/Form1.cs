using Assignment3.Models;
using Assignment3.Providers;
using DoctorClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministratorClient
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
        public int getDoctorID()
        {
            return Convert.ToInt32(this.idDoctorS_tb.Text);
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
                   // MessageBox.Show(response.ToString());
                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }


        }
        public void viewS_btnClick(object sender, EventArgs e)
        {
            MessageBox.Show("view");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = client.GetAsync("api/schedule").Result;
                //MessageBox.Show(response.ToString());
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
        private void dataGridViewSchedules_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSchedules.SelectedRows.Count > 0)
            {
                Schedule schedule = dataGridViewSchedules.SelectedRows[0].DataBoundItem as Schedule;
                if (schedule != null)
                {
                    idPatientS_tb.Text = schedule.idPatient.ToString();
                    idDoctorS_tb.Text = schedule.idDoctor.ToString();
                    scheduleDateS_tb.Text = schedule.scheduleDate.ToString();
                    scheduleCheck_tb.Text = schedule.checkin;
                    scheduleDesc_tb.Text = schedule.description;

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
                    MessageBox.Show("Update status: success");
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
                    MessageBox.Show("Insert status: success");
                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        private int checkDisponibibilty(int id, DateTime sdate)
        {
            int nr = 0;
            try
            {
                MessageBox.Show("incerc");
                HttpResponseMessage response = client.GetAsync("api/scheduleDoctorDaily/" + id).Result;
               // MessageBox.Show(response.ToString());
                var schedules = response.Content.ReadAsAsync<IEnumerable<Schedule>>().Result;
                List<Schedule> scheduleList = (List<Schedule>)schedules;
                for (int i = 0; i < scheduleList.Count(); i++)
                    if (scheduleList[i].scheduleDate == sdate)
                        nr++;
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }
            return nr;
        }
        private void addSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.idPatient = Convert.ToInt32(idPatientS_tb.Text);
            schedule.idDoctor = Convert.ToInt32(idDoctorS_tb.Text);
            schedule.scheduleDate = Convert.ToDateTime(scheduleDateS_tb.Text);
            schedule.description = "New";
            int n = checkDisponibibilty(schedule.idDoctor, schedule.scheduleDate);
            if (n >= 4)
                MessageBox.Show("This doctor is not disponible. Chose another date");
            else
            {
                try
                {
                    MessageBox.Show("incerc");
                    HttpResponseMessage response = client.PostAsJsonAsync("api/addSchedule", schedule).Result;
                    // MessageBox.Show("am terminat de incercat");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Insert status: success");
                    }
                    else
                    {
                        MessageBox.Show("Insert status: failed");
                    }
                }
                catch (AggregateException exe)
                {
                    MessageBox.Show(exe.Message);
                }
            }
           
        }
        private void updateSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.idPatient = Convert.ToInt32(idPatientS_tb.Text);
            schedule.idDoctor = Convert.ToInt32(idDoctorS_tb.Text);
            schedule.scheduleDate = Convert.ToDateTime(scheduleDateS_tb.Text);
            schedule.description = scheduleDesc_tb.Text;
            schedule.checkin = scheduleCheck_tb.Text;

            try
            {
               // MessageBox.Show("incerc");
                HttpResponseMessage response = client.PostAsJsonAsync("api/UpdateSchedule", schedule).Result;
               // MessageBox.Show("am terminat de incercat");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update status: success");
                    DoctorNotification dn = new DoctorNotification(schedule.idDoctor);
                    ThreadStart threadDelagate = new ThreadStart(dn.getNotify);
                    Thread secThread = new Thread(threadDelagate);
                    secThread.Start();
                }
                else
                {
                    MessageBox.Show("Update status: failed");
                }
            }
            catch (AggregateException exe)
            {
                MessageBox.Show(exe.Message);
            }

        }
    }
}

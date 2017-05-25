using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Assignment3.Models;

namespace DoctorClient
{
    public class DoctorNotification
    {
        public int idDoctor { get; set; }
        public HttpClient client;
        public DoctorNotification(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60050/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.idDoctor = id;
        }
        public void getNotify()
        {

            try
            {
                HttpResponseMessage response = client.GetAsync("api/scheduleDoctor/" + this.idDoctor).Result;

                if (response.IsSuccessStatusCode)
                {
                    var schedules = response.Content.ReadAsAsync<IEnumerable<Schedule>>().Result;
                    List<Schedule> schedulesList = (List<Schedule>)schedules;
                    if (schedulesList.Count() > 0)
                        Form1.showMessage("A ajuns pacientul" + schedulesList[0].idPatient);
                }

            }
            catch (AggregateException exe)
            {
                Form1.showMessage(exe.Message);
            }

        }
    }
}

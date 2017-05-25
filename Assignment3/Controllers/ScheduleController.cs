using Assignment3.Models;
using Assignment3.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment3.Controllers
{
    public class ScheduleController : ApiController
    {
        // GET api/values

          [HttpGet]
          [Route("api/getHistory/{id}")]
          public IEnumerable<Schedule> GetHistory(int id )
          {
              return ScheduleProvider.GetPatientSchadule(id);
          }

        [HttpGet]
        [Route("api/scheduleDoctor/{id}")]
        public IEnumerable<Schedule> GetSchedulesForDoctor(int id)
        {
            return ScheduleProvider.GetSchedulesForDoctor(id);
        }

        [HttpGet]
        [Route("api/scheduleDoctorDaily/{id}")]
        public IEnumerable<Schedule> GetSchedulesForDoctorDaily(int id)
        {
            return ScheduleProvider.GetSchedulesForDoctorDaily(id);
        }

        [HttpGet]
        [Route("api/schedule")]
        public IEnumerable<Schedule> Get()
        {
            return ScheduleProvider.GetSchedules();
        }
             
        [HttpPost]
        [Route("api/addSchedule")]
        public void AddPost([FromBody]Schedule value)
        {
            ScheduleProvider.AddSchedule(value);
        }

        [HttpPost]
        [Route("api/updateSchedule")]
        public void UpdatePost([FromBody]Schedule value)
        {
            ScheduleProvider.UpdateSchedule(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

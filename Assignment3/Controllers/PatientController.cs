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
    public class PatientController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("api/patient")]
        public IEnumerable<Patient> Get()

        {
            return PatientProvider.GetList();
        }

        [HttpGet]
        [Route("api/{id}/getPatient")]
        public User Get(int id)
        {
            return UserProvider.GetUser(id);
        }

        // POST api/values
        [HttpPost]
        [Route("api/updatePatient")]
        public void Post([FromBody]Patient value)
        {
            PatientProvider.UpdatePatient(value);
        }

        [HttpPost]
        [Route("api/addPatient")]
        public void AddPost([FromBody]Patient value)
        {
            PatientProvider.AddPatient(value);
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

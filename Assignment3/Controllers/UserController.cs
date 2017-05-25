using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment3.Models;
using Assignment3.Providers;

namespace Assignment3.Controllers
{
    public class UserController : ApiController
    {
        // GET api/values
        [HttpGet][Route("api/user")]
        public IEnumerable<User> Get()
        
        {
            return UserProvider.GetList();
        }

        [HttpGet]
        [Route("api/getUser/{id}")]
        public User Get(int id)
        {
            return UserProvider.GetUser(id);
        }

        // POST api/values
        [HttpPost]
        [Route("api/updateUser")]
        public void UpdatePost([FromBody]User value)
        {
            UserProvider.UpdateUser(value);
        }


        [HttpPost]
        [Route("api/addUser")]
        public void AddPost([FromBody]User value)
        {
            UserProvider.AddUser(value);
        }

        [HttpPost]
        [Route("api/deleteUser")]
        public void DeltePost([FromBody]User value)
        {
            UserProvider.DeleteUser(value);
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

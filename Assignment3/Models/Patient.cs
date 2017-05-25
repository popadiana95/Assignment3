using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Patient
    {
        public int idPatient { get; set; }
        public string cnp { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public string address {get; set;}
    }
}
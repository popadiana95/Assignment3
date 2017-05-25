using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Schedule
    {
        public int idPatient { get; set; }
        public int idDoctor { get; set; }
        public DateTime scheduleDate { get; set; }
        public string description { get; set; }
        public string checkin { get; set; }
    }
}
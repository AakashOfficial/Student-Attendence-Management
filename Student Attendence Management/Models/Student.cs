using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Attendence_Management.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        
        public string StudentName { get; set; }

        public string StudentClass { get; set; }

        public string StudentSection { get; set; }

        public int StudentMonitor { get; set; }

        public string StudentAddress { get; set; }

        public string StudentActive { get; set; }
    }
}
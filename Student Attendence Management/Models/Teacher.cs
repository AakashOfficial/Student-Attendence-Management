using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Attendence_Management.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }

        public string TeacherAddress { get; set; }

        public int TeacherExperience { get; set; }

        public int TeacherActive { get; set; }
    }
}
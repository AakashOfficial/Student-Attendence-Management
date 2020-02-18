using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Attendence_Management.Controllers
{
    public class AttendenceController : Controller
    {
        // GET: Attendence
        public ActionResult Index()
        {
            return View();
        }
    }
}
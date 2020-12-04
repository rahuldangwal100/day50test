using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplD50Test.Models;

namespace WebApplD50Test.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Display()
        {
            List<Student> Studentlist = new List<Student>
            {
                new Student{SId=1,SName="RAHUL",SDob="10/10/1998",SContact="567678767"},
                new Student{SId=2,SName="AMAN",SDob="04/11/1996",SContact="8756787678"},
                new Student{SId=3,SName="RONNY",SDob="12/07/1997",SContact="9876787675"},
                new Student{SId=4,SName="AKSHAY",SDob="11/08/1998",SContact="8756787678"},
                new Student{SId=5,SName="SAM",SDob="04/04/1999",SContact="2987987678"},


            };
            int X = Studentlist.Count;
            ViewBag.Total = X;
            return View(Studentlist);
        }
    }
}

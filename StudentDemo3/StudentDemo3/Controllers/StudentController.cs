using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentDemo3.Models;

namespace StudentDemo3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student stu = new Student();
            stu.id = 1;
            stu.name = "Teja";
            stu.phonenum = 12345;
            return View(stu);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsDemo.Models;

namespace ModelsDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetStudent();
            return View(data);
        }
        private Student GetStudent()
        {
            return new Student()
            {
                Id=1,
                Name="Vinay",
                Address="Bangalore"
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThanhThuan_Lab456.Models;

namespace ThanhThuan_Lab456.ViewModel
{
    public class CourseViewModel : Controller
    {
        public string Place { get; set; } 
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

        // GET: CourseViewModel
        public ActionResult Index()
        {
            return View();
        }
    }
}
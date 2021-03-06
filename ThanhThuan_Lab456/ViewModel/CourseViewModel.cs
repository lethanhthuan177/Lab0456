﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThanhThuan_Lab456.Models;
using ThanhThuan_Lab456.ViewModels;

namespace ThanhThuan_Lab456.ViewModel
{
    public class CourseViewModel : Controller
    {
        [Required]
        public string Place { get; set; }
        [Required]
        public string Date { get; set; }
        [validTime]
        [Required]
        public string Time { get; set; }
        [Required]
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
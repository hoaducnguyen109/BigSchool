using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBigSchool.Models;

namespace MyBigSchool.Content
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext();
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            return View();
        }
    }
}
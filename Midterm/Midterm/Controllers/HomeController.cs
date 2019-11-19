using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


// Author: Connor Merkley
// Desc: This website is intended to store a users digital media collection. The website is built off .NET framework using C#.

//This also a test using github

namespace Midterm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
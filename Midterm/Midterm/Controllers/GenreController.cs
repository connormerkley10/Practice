using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm.Controllers
{
    public class GenreController : Controller
    {
        public static List<Genre> lstGenres = new List<Genre>();

        // GET: Position
        public ActionResult ShowGenres()
        {
            return View(lstGenres);
        }

        [HttpGet]
        public ActionResult addGenre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGenre(Genre myGenre)
        {
            if (ModelState.IsValid)
            {
                lstGenres.Add(myGenre);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(myGenre);
            }
        }

        [HttpGet]
        public ActionResult EditGenre(string sCode)
        {
            Genre oGenre = lstGenres.Find(x => x.Genre_Code == sCode);

            return View(oGenre);
        }

        [HttpPost]
        public ActionResult EditGenre(Genre myGenre)
        {
            var obj = lstGenres.FirstOrDefault(x => x.Genre_Code == myGenre.Genre_Code);

            if (obj != null)
            {
                obj.Genre_Code = myGenre.Genre_Code;
                obj.Genre_Desc = myGenre.Genre_Desc;
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
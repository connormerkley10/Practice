using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm.Controllers
{
    public class MovieController : Controller
    {
        public static List<Movie_Info> lstMovies = new List<Movie_Info>();
        // GET: Players
        public ActionResult ShowMovies()
        {
            return View(lstMovies);
        }

        public ActionResult AddMovie()
        {
            ViewBag.Media = MediaController.lstMedia_Types;
            ViewBag.Genre = GenreController.lstGenres;

            return View();
        }

        [HttpPost]
        public ActionResult AddMovie(Movie_Info myMovie)
        {
            if (ModelState.IsValid)
            {     
                lstMovies.Add(myMovie);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(myMovie);
            }
        }

        [HttpGet]
        public ActionResult EditMovie(string sCode)
        {
            Movie_Info oMovie = lstMovies.Find(x => x.Movie_Code == sCode);
            ViewBag.Media = MediaController.lstMedia_Types;
            ViewBag.Genre = GenreController.lstGenres;
            return View(oMovie);
        }

        [HttpPost]
        public ActionResult EditMovie(Movie_Info myMovie)
        {
            var obj = lstMovies.FirstOrDefault(x => x.Movie_Code == myMovie.Movie_Code);

            if (obj != null)
            {
                obj.Movie_Code = myMovie.Movie_Code;
                obj.Movie_Title = myMovie.Movie_Title;
                obj.Genre_Code = myMovie.Genre_Code;
                obj.Media_Code = myMovie.Media_Code;
 
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
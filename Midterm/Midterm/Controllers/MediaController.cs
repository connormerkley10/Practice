using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm.Controllers
{
    public class MediaController : Controller
    {
        public static List<Media_Type> lstMedia_Types = new List<Media_Type>();

        // GET: Position
        public ActionResult ShowMedia()
        {
            return View(lstMedia_Types);
        }

        [HttpGet]
        public ActionResult AddMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMedia(Media_Type myMedia)
        {
            if (ModelState.IsValid)
            {
                lstMedia_Types.Add(myMedia);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(myMedia);
            }
        }

        [HttpGet]
        public ActionResult EditMedia(string sCode)
        {
            Media_Type oMedia = lstMedia_Types.Find(x => x.Media_Code == sCode);

            return View(oMedia);
        }

        [HttpPost]
        public ActionResult EditMedia(Media_Type myMedia)
        {
            var obj = lstMedia_Types.FirstOrDefault(x => x.Media_Code == myMedia.Media_Code);

            if (obj != null)
            {
                obj.Media_Code = myMedia.Media_Code;
                obj.Media_Desc = myMedia.Media_Desc;
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
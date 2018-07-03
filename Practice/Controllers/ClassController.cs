using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class

        public ActionResult Class()
        {
            Class _class = new Class();

            _class.classes = new List<Class>
            {
                new Class { Type = "Dragoon", Id = 1 },
                new Class { Type = "Monk", Id = 2 },
                new Class { Type = "Ninja", Id = 3 },
                new Class {Type = "Samurai", Id = 4 }
            };
            return View(_class);
        }

        public ActionResult LoadDPartialView()
        {

            return PartialView("_Dragoon");
        }

        public ActionResult LoadMPartialView()
        {

            return PartialView("_Monk");
        }

        public ActionResult LoadNPartialView()
        {

            return PartialView("_Ninja");
        }

        public ActionResult LoadSPartialView()
        {

            return PartialView("_Samurai");
        }

        public JsonResult ReloadClass(int id)
        {
            string test = "";
            var partial = LoadDPartialView() ;
            switch (id)
            {
                case 1:
                    partial = LoadDPartialView();
                   
                    break;
                case 2:
                    test = "Oh Boi";
                    break;
                case 3:
                    partial = LoadNPartialView();
                    break;
                case 4:
                    partial = LoadSPartialView();
                    break;
                default:
                    break;
            }
            return Json(partial);
        }

    }
}

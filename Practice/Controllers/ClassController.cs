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
                new Class { Type = "Dragoon", Id = 0 },
                new Class { Type = "Ninja", Id = 1 },
                new Class { Type = "White Mage", Id = 2 },
                new Class {Type = "FcknMonk", Id = 3 }
            };
            return View(_class);
        }

        public ActionResult LoadPartialView()
        {

            return PartialView("_Dragoon");
        }


    }
}

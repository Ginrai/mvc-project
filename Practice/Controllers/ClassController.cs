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


        public ActionResult ReloadClass(int id)
        {
          
            switch (id)
            {
                case 1:

                    return PartialView("_Dragoon");
                    
                case 2:
                    return PartialView("_Monk");
                  
                case 3:
                    return PartialView("_Ninja");

                   
                case 4:
                    return PartialView("_Samurai");

                    
                default:
                    return PartialView("_partial");
                    
            }
        }

    }
}

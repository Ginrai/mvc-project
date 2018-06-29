using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;


namespace Practice.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random() //ActionResult is a universal. This method returns a ViewResult type, but if we want to use more than one action result, we use ActionResult.
        {
            var movies = new Movie() { Name = "FFXIV -- Dragoon PVP" };

           

            // ViewData["Movie"] = movie;//passing view data to the Movie View
            //  ViewBag.Movie = movie; //Adds dynamic support, but is unstable.
      
            return View(movies); //Because of the command above, we don't have to pass the movie var. But, since ViewData and ViewBag are unstable (and ViewData is static), we will not use them and we should almost never use them.
            //return Content("Hello bitch!");
            // return HttpNotFound();
            // return new EmptyResult();
            // return new RedirectResult("www.fuckyou.com", false); //Used to let use know whether the redirect is permanent or not
            //return RedirectToAction("About", "Home", new { page = 1, sortBy = "name" });
        }
       // [Route("movie/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
         public ActionResult Edit(int movieId)
         {
             return Content("id=" + movieId); //Less functionality than defining the variable as "id" because that is what it is defined as in the RouteConfig.cs
         } 

        //Navigating to movies
         public ActionResult Index(int? pageIndex, string SortBy)
         {
             if (!pageIndex.HasValue)
             {
                 pageIndex = 1;
             }

             if (String.IsNullOrWhiteSpace(SortBy))
             {
                 SortBy = "Name";
             }

             return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, SortBy));
         }


        /* Alternatively:
         * public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        */
    }
}
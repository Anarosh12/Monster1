using System;
using Monster.Models;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace Monster.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Red Dawn !!"
                
            };
            return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("index", "Home", new { page = 1, sortBy = "name" });
        }

        // GET: Movies/Edit/1
        public ActionResult Edit(int movieId)
        {
            return Content("movieId=" +movieId );
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
   
}
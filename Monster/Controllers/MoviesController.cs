using Monster.Models;
using System.Web.Mvc;

namespace Monster.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie()
        //    {
        //        Name = "Red Dawn !!"

        //    };

        //    return View(movie);
        //    //return Content("Hello World");
        //    //return HttpNotFound();
        //    //return new EmptyResult();
        //    //return RedirectToAction("index", "Home", new { page = 1, sortBy = "name" });
        //}

        // View Data Dictinary
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Red Dawn !!"
            };

            ViewData["movie"]=movie;
            return View();
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("index", "Home", new { page = 1, sortBy = "name" });
        }

        // GET: Movies/Edit/1
        public ActionResult Edit(int movieId)
        {
            return Content("movieId=" + movieId);
        }

        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex={0} & sortBy={1}", pageIndex, sortBy));
        }


        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]

        // GET: Movies/released/year/month
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }



    }

}
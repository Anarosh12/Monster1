using System.Collections.Generic;
using Monster.Models;
using System.Web.Mvc;
using Monster.ViewModels;

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

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("index", "Home", new { page = 1, sortBy = "name" });
        }

        // View Data Dictionary
        //public ActionResult Random()
        ////{
        ////    var movie = new Movie()
        //    {
        //        Name = "Red Dawn !!"
        //    };

        //    return View();
        //    //return Content("Hello World");
        //    //return HttpNotFound();
        //    //return new EmptyResult();
        //    //return RedirectToAction("index", "Home", new { page = 1, sortBy = "name" });
        //}

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
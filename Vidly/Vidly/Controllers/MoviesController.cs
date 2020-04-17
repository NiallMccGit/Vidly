using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Movies()
        {
            var movie = new Movie() { Name = "Matrix", Genre = "Comedy" };

            var customers = new List<Customer>
            {
                new Customer{ Name = "Customer 1"},
                new Customer{ Name = "Customer 2"}
            };

            var viewModel = new MovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
  
            return View(viewModel);
        }
 

        [Route("movies/released/{year:regex(\\d{4}):range(1900, 2050)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}
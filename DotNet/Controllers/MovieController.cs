using DotNet.Models;
using DotNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNet.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

            // ViewData["Movie"] = movie; // not good
            // ViewBag.Movie = movie; // also not good
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer1" },
                new Customer { Name = "Customer2" }
            };
            var viewModel = new RandomViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        // movie/edit/1 or movie/edit?id=1
        // id = RouteConfig -> route definition id
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // optional pageIndex
        // movie?pageIndex=1&sortBy=ASD
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
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        // custom route
        // min, max, minlength, .... = attribute route constraints
        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Movies()
        {
            var movie = new Movie() { Name = "Shrek", Genre = "Comedy" };

            return View(movie);
        }
    }
}
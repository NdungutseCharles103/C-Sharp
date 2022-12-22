using System;
using System.Collections.Generic;
using System.Linq;
using System. Web;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

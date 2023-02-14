using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_ejake370.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ejake370.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieSubmissionContext _movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieSubmissionContext temp)
        {
            _logger = logger;
            _movieContext = temp;
        }
        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View("MovieSubmission");
        }
        [HttpPost]
        public IActionResult EnterMovie(Movie movie)
        {
            _movieContext.Add(movie);
            _movieContext.SaveChanges();
            return View("Confirmation", movie);
        }

        public IActionResult MyPodcasts ()
        {
            return View("MyPodcasts");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

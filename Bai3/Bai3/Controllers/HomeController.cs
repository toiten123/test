using Bai3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bai3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Action Index có tham số id với Inline Constraint là số nguyên
        [Route("Home/Index/{id:int}")]
        public IActionResult Index(int id)
        {
            return Content("I got " + id.ToString());
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

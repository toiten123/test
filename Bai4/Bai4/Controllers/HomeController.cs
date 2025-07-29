using Bai4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bai4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action Index() với tham số year và ràng buộc 4 chữ số
        [Route("Home/Index/{year:int:range(1000,9999)}")]
        public string Index(int year)
        {
            return "Year = " + year.ToString();
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

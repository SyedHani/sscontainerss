using Microsoft.AspNetCore.Mvc;
using scontainers.Models;
using System.Diagnostics;

namespace scontainers.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //logger = logger;
        //}

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            ViewData["abc"] = "SomeValue";
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

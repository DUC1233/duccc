using Microsoft.AspNetCore.Mvc;
using NW2.Models;
using System.Diagnostics;

namespace NW2.Controllers
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

        [Route("/Ve-chung-toi.html",Name ="About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/Dich-vu-.html", Name = "Services")]
        public IActionResult Services()
        {
            return View();
        }

        [Route("/Cac-loai-dong-vat-cua-chung-toi.html", Name ="Our Animals")]
        public IActionResult Animals()
        {
            return View();
        }

        [Route("/Gio-mo-cua.html", Name ="Visiting Hours")]

        public IActionResult Visiting()
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
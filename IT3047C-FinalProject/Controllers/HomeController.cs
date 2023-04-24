using IT3047C_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3047C_FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private FinalProjectContext data { get; set; }
        public HomeController(FinalProjectContext ctx) => data = ctx;
        public IActionResult Index()
        {
            ViewBag.Name = "temp";
            return View();
        }
        public IActionResult AboutChloe()
        {
            ViewBag.Name = "temp";
            return View("~/Views/AboutUs/AboutChloe.cshtml");
        }
        public IActionResult AboutDakota()
        {
            ViewBag.Name = "temp";
            return View("~/Views/AboutUs/AboutDakota.cshtml");
        }
        public IActionResult ChloesHobbies()
        {
            ViewBag.Name = "temp";
            return View("~/Views/Hobbies/ChloesHobbies.cshtml");
        }
        public IActionResult DakotasHobbies()
        {
            ViewBag.Name = "temp";
            return View("~/Views/Hobbies/DakotasHobbies.cshtml");
        }
        public IActionResult Recommendations()
        {
            ViewBag.Name = "temp";
            return View("~/Views/Hobbies/Recommendations.cshtml");
        }
        public IActionResult SharedHobbies()
        {
            ViewBag.Name = "temp";
            return View("~/Views/Hobbies/SharedHobbies.cshtml");
        }
    }
}

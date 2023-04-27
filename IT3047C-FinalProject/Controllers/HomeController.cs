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
            return View("~/Views/AboutChloe/AboutChloe.cshtml");
        }
        public IActionResult AboutDakota()
        {
            ViewBag.Name = "temp";
            return View("~/Views/AboutDakota/AboutDakota.cshtml");
        }
        public IActionResult ChloesHobbies()
        {
            ViewBag.Name = "temp";
            return View("~/Views/ChloeHobbies/ChloesHobbies.cshtml");
        }
        public IActionResult DakotasHobbies()
        {
            ViewBag.Name = "temp";
            return View("~/Views/DakotaHobbies/DakotasHobbies.cshtml");
        }
        public IActionResult Recommendations()
        {
            ViewBag.Name = "temp";
            return View("~/Views/RecHobbies/Recommendations.cshtml");
        }
        public IActionResult SharedHobbies()
        {
            ViewBag.Name = "temp";
            return View("~/Views/Hobbies/ViewStart.cshtml");
        }
    }
}

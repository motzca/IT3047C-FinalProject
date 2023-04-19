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
    }
}

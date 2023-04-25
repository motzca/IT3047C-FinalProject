using IT3047C_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3047C_FinalProject.Controllers
{
    public class DakotaHobbiesController : Controller
    {
        private Repository<Dakota> dakota { get; set; }

        public IActionResult Index()
        {

            var options = new QueryOptions<Dakota>
            {
                OrderBy = t => t.HobbyId
            };
            return View(dakota.List(options));
        }
    }
}

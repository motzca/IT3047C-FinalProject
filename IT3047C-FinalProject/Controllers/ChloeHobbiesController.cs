using Microsoft.AspNetCore.Mvc;
using IT3047C_FinalProject.Models;

namespace IT3047C_FinalProject.Controllers
{
    public class ChloeHobbiesController : Controller
    {
        private Repository<Chloe> chloe { get; set; }
        
        public IActionResult Index()
        {

            var options = new QueryOptions<Chloe>
            {
                OrderBy = t => t.HobbyId
            };
            return View(chloe.List(options));
        }
    }
}

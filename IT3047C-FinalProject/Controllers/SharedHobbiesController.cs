using IT3047C_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3047C_FinalProject.Controllers
{
    public class SharedHobbiesController : Controller
    {
        private Repository<Shared> sharedHobbies { get; set; }

        public IActionResult Index()
        {

            var options = new QueryOptions<Shared>
            {
                OrderBy = t => t.SharedHobbyId
            };
            return View(sharedHobbies.List(options));
        }
    }
}

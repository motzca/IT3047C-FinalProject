using IT3047C_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3047C_FinalProject.Controllers
{
    public class RecommendationController : Controller
    {
        private Repository<RecHobbies> recHobby { get; set;  }
        public RecommendationController(FinalProjectContext ctx) => new Repository<RecHobbies>(ctx);

        public ViewResult Index()
        {
            var options = new QueryOptions<RecHobbies>
            {
                OrderBy = t => t.Id
            };
            return View(recHobby.List(options));
        }
        [HttpGet]
        public ViewResult Add() => View();

        [HttpPost]
        public IActionResult Add(RecHobbies recHobbies)
        {
            if (ModelState.IsValid)
            {
                recHobby.Insert(recHobbies);
                recHobby.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(recHobbies);
            }
        }

        [HttpGet]
        public ViewResult Delete(int id) => View(recHobby.Get(id));

        [HttpPost]
        public RedirectToActionResult Delete(RecHobbies recHobbies)
        {
            recHobby.Delete(recHobbies);
            recHobby.Save();
            return RedirectToAction("Index");
        }

    }
}

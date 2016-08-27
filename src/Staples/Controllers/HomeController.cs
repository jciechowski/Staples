using Microsoft.AspNetCore.Mvc;
using Repository;
using Staples.Models;

namespace Staples.Controllers
{
    public class HomeController : Controller
    {
        private MapService _saveService;

        public HomeController(MapService saveService)
        {
            _saveService = saveService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Name", "Surname","Address","PhoneNumber")]Person person)
        {
            var logDto = _saveService.Map(person);
            return RedirectToAction("Index");
        }
    }
}

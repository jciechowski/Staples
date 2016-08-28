using Microsoft.AspNetCore.Mvc;
using Repository;
using Staples.Models;

namespace Staples.Controllers
{
    public class HomeController : Controller
    {
        private SaveService _saveService;

        public HomeController(SaveService saveService)
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
            _saveService.Save(person);
            return RedirectToAction("Index");
        }

        public void SaveToLog([Bind("Name", "Surname", "Address", "PhoneNumber")]Person person)
        {
            _saveService.Save(person);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Repository.Services;
using Staples.Models;

namespace Staples.Controllers
{
    public class HomeController : Controller
    {
        private readonly LogService _logService;

        public HomeController(LogService logService)
        {
            _logService = logService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Name", "Surname","Address","PhoneNumber")]Person person)
        {
            if(ModelState.IsValid)
                _logService.Log(person);
            return RedirectToAction("Index");
        }

        public void LogToXml([Bind("Name", "Surname", "Address", "PhoneNumber")]Person person)
        {
            _logService.LogToXml(person);
        }
    }
}

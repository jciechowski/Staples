using Microsoft.AspNetCore.Mvc;
using Staples.Models;

namespace Staples.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Name", "Surname","Address","PhoneNumber")]Person person)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

using Danciu_Radu_Lab1_BAMI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Danciu_Radu_Lab1_BAMI.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;

            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }

    }
}

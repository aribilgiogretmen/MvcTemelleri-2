using Microsoft.AspNetCore.Mvc;
using MvcTemelleri_2.Models;
using System.Diagnostics;
using System.Reflection;

namespace MvcTemelleri_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Person()
        {



            return View(new Person());
        }

        [HttpPost]
        public IActionResult Person(Person model)
        {

            if (ModelState.IsValid && !string.IsNullOrEmpty(model.FirstName))
            {
                model.LastName = "Alpak";
                return View("Person", model);

            }

            return View("Person", model);
        }

        public IActionResult Index()
        {
            
           
            
            return View(new Calc());
        }

        [HttpPost]
        public IActionResult Index(Calc model)
        {
            if (ModelState.IsValid)
            {
                model.Sum = model.Num1 + model.Num2;
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

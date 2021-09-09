using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestUno.Models;

namespace TestUno.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(); // Retorno una vista que se llama Index pero sin modelo!
        }
        public IActionResult Eduardo()
        {
            Alumno alumno = new Alumno()
            {
                Apellido = "Mass", Nombre = "Eduardo", Id = 1
            };

            return View(alumno); // Retorno una vista que se llama Eduardo pero sin modelo!
        }

        public IActionResult Profesor()
        {
            var modelo = new Profesor()
            {
                Apellido = "Mass",
                Nombre = "Eduardo",
                Id = 1
            };

            return View("Eduardo", modelo); // Retorno una vista que se llama Eduardo pero sin modelo!
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

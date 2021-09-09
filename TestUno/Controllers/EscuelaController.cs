using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestUno.Models;

namespace TestUno.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.ListaAlumnos = new List<Alumno>();
            escuela.ListaProfesores = new List<Profesor>();

            escuela.ListaAlumnos.Add(new Alumno() { Nombre = "Edu"});
            escuela.ListaAlumnos.Add(new Alumno() { Nombre = "Carlos" });
            escuela.ListaAlumnos.Add(new Alumno() { Nombre = "Sarlanga" });

            escuela.ListaProfesores.Add(new Profesor() { Nombre="Profe Edu"});
            escuela.ListaProfesores.Add(new Profesor() { Nombre = "Profe Carlos" });
            escuela.ListaProfesores.Add(new Profesor() { Nombre = "Profe Sarlanga" });

            return View(escuela);
        }
    }
}

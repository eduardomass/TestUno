using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestUno.Models;

namespace TestUno.Controllers
{
    public class AlumnoController : Controller
    {
        public static List<Alumno> ListaAlumnos = new List<Alumno>();
        // GET: AlumnoController
        public ActionResult Index()
        {
            return View(AlumnoController.ListaAlumnos);
        }

        // GET: AlumnoController/Details/5
        public ActionResult Details(int id)
        {
            bool existeId = AlumnoController.ListaAlumnos.Any(o=>o.Id == id);
            ViewBag.Mensaje = $"Usted busco el id {id} donde eixte es : {existeId.ToString()}";
            return View("Mensaje");
        }

        [HttpGet]
        // GET: AlumnoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlumnoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Alumno alumno)
        {
            try
            {
                AlumnoController.ListaAlumnos.Add(alumno);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlumnoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlumnoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

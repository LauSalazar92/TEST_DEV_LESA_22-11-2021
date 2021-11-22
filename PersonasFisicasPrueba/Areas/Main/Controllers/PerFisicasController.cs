using Microsoft.AspNetCore.Mvc;
using PersonasFisicasPrueba.Datos.Repository;
using PersonasFisicasPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PersonasFisicasPrueba.Areas.Main.Controllers
{
    [Area("Main")]
    public class PerFisicasController : Controller
    {
        private readonly IUnitOfWork unidadTrabajo;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public PerFisicasController(IUnitOfWork unit)
        {
            unidadTrabajo = unit;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(TbPersonasFisicas ins)
        {
            if (ModelState.IsValid)
            {
                ins.Activo = false;
                unidadTrabajo.PersonasFisicasR.Add(ins);
                unidadTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View("Create");
        }

        [HttpGet]
        public IActionResult GetAllAPI()
        {
            Thread.Sleep(1000);
            return Json(new { data = unidadTrabajo.PersonasFisicasR.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            TbPersonasFisicas personas = unidadTrabajo.PersonasFisicasR.Get(id);
            if (personas == null)
            {
                return Json(new { success = false, message = "El persona fisica no existe" });
            }
            unidadTrabajo.PersonasFisicasR.Remove(personas);
            unidadTrabajo.Save();
            return Json(new { success = true, message = "Persona eliminada correctamente" });
        }

        [HttpPost]
        public IActionResult Update(TbPersonasFisicas personas)
        {
            if (ModelState.IsValid)
            {
                unidadTrabajo.PersonasFisicasR.Update(personas);
                unidadTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View("Edit", personas);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            TbPersonasFisicas personas = unidadTrabajo.PersonasFisicasR.Get(id);
            if (personas == null)
            {
                return NotFound();
            }
            return View(personas);
        }

    }
}


using Lista7.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lista7.Controllers
{
    public class HomeController : Controller
    {

        private EstudianteEntities db = new EstudianteEntities();

        // GET: Home
        public ActionResult Crear()
        {
            var estudiante = new Estudiante();

            var items = new List<SelectListItem>
            {
                new SelectListItem {Text = "Masculino", Value = "Masculino"},
                new SelectListItem {Text = "Femenino", Value = "Femenino"},
            };

            ViewData["Genero"] = items;

            return View(estudiante);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "EstudianteId,EstudianteNombre,EstudianteGenero")] Estudiante stu)
        {
            if (ModelState.IsValid)
            {
               
                try
                {
                    db.Estudiante.Add(stu);
                    db.SaveChanges();
                }

                      catch (DbEntityValidationException e)
                       {
                           string errorMessage = "";
                           foreach (var eve in e.EntityValidationErrors)
                           {
                               errorMessage = string.Format("\nEntity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                   eve.Entry.Entity.GetType().Name, eve.Entry.State);
                               foreach (var ve in eve.ValidationErrors)
                               {
                                   errorMessage += string.Format("\n- Property: \"{0}\", Error: \"{1}\"",
                                       ve.PropertyName, ve.ErrorMessage);
                               }
                           }
                           throw new System.Exception(errorMessage);
                       } 
                    return RedirectToAction("Crear", "Home");
                
        

              
            }

            return View(stu);
        }
    }
}
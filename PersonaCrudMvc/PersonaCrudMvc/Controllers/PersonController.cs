using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonaCrudMvc.Models;

namespace PersonaCrudMvc.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            try
            {
                using (EntityFrameworkEntities db = new EntityFrameworkEntities())
                {
                    List<personita> lista = db.personita.Where(a => a.id > 1).ToList();
                    return View(lista);

                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        //crear o insertar


        [HttpPost]
        public ActionResult AgregarPersona(personita p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                using (EntityFrameworkEntities db = new EntityFrameworkEntities())
                {
                    db.personita.Add(p);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("error al agregar", ex);
                return View();



            }


        }


        [HttpGet]
        public ActionResult AgregarPersona()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdatePerona(personita busnue)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                using (EntityFrameworkEntities bd = new EntityFrameworkEntities())
                {
                    personita existe = bd.personita.Find(busnue.id);
                    
                    existe.nombre = busnue.nombre;
                    existe.apellido = busnue.apellido;
                    bd.SaveChanges();
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar a la persona", ex);
                return View();
            }
        }

        [HttpGet]
        public ActionResult UpdatePerona(int id)
        {
            try
            {
                using (EntityFrameworkEntities bd = new EntityFrameworkEntities())
                {
                    personita pers = bd.personita.Find(id);
                    return View(pers);

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar a la persona", ex);
                return View();
            }
        }



        public ActionResult DetallesPersona(int id)
        {
            try
            {
                using (EntityFrameworkEntities bd = new EntityFrameworkEntities())
                {
                    personita existe = bd.personita.Find(id);
                    return View(existe);

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al mostrar a la persona", ex);
                return View();
            }
        }

        public ActionResult EliminarPersona(int id)
        {
            try
            {
                using (EntityFrameworkEntities bd = new EntityFrameworkEntities())
                {
                    personita existe = bd.personita.Find(id);
                    bd.personita.Remove(existe);
                    bd.SaveChanges();
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al eliminar a la persona", ex);
                return View();
            }
        }






    }
}
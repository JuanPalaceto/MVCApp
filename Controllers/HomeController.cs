using MiSitioWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiSitioWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Si requieres servicios de desarollo de software o tienes preguntas no dudes en contactarme.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contacto contacto)
        {
            ContactoContext db = new ContactoContext();
            db.Contactos.Add(contacto);

            try
            {
                db.SaveChanges();
                ViewBag.Message = "Tu mensaje se ha guardado..";
            }
            catch (Exception e)
            {
                ViewBag.Message = "Error al guardar.";
            }

           return View();
        }

        [Authorize]
        public ActionResult Projects() {
            return View();
        }
    }
}
using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult MuestraPulques()
        {
            TempData["Nombres"] = "Mario Brothers";
            var pulquesVenta = new PulquesServices();
            var model = pulquesVenta.ObtenerPulques();
            return View(model);
        }

        public ActionResult Index()
        {
            //return Content("QUE ONDA QUE PEX :/>");
            var pulque = new Pulques()
            {
                Nombre = "Pulque JSON",
                Descripcion = "Frutos Rojos",
                Litros = 25,
                Caducidad = new DateTime(2023, 11, 5)
            };
            //return View();
            return Json(pulque, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Vista()
        {
            var pulque = new Pulques()
            {
                Nombre = "Pulque JSON",
                Descripcion = "Frutos Rojos",
                Litros = 25,
                Caducidad = new DateTime(2023, 11, 5)
            };
            ViewBag.pulques=pulque;
            return View();
            //return Redirect("https://google.com");
        }

        public RedirectToRouteResult Vista2()
        {
            return RedirectToAction("MuestraPulques");
        }

        public ActionResult Parametros()
        {
            ViewBag.saludo = "Hola mundo que pex";
            ViewBag.fecha = new DateTime(2023, 11, 2);
            ViewData["Nombre"]= "Ricardo";
            string nombre="";
            if (TempData.ContainsKey("nombre"))
            {
                nombre = TempData["Nombres"] as string;
            }
            ViewBag.nombreNuevo = nombre;
            return View();
        }


    }
}
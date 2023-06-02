using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult RegistrarPalabra()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarPalabra(Traductor tr)
        {
            var op = new RegistrarPalabraService();
            op.GuardarArhcivo(tr);
            //RegistrarPalabra();
            return View();
        }

        public ActionResult LeerPalabras()
        {
            var trad = new LeerServcie();
            var palabras = trad.LeerArchivoTraductor();
            Debug.WriteLine(palabras);
            ViewBag.palabras = palabras;

            return View("RegistrarPalabra");
        }

        public ActionResult traducir()
        {

            return View();
        }
        [HttpPost]
        public ActionResult traducir(TraductorRespuesta trR)
        {
            var modelTr = new TraductorRespuesta();
            var trad = new TraducirService();
            var palabra = trad.traducirPalabra(trR);
            ViewBag.palabraTraducida = palabra;


            return View();
        }
    }
}
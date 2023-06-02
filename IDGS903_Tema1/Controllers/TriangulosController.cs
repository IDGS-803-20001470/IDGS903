using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos

        public ActionResult CalcularTriangulo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcularTriangulo(Triangulos tri)
        {
            var triangulo = new CalcularTrianguloService();
           var respuesta= triangulo.calcularTriangulo(tri);
            
            ViewBag.respuestaCalculo = respuesta;


            return View();
        }



    }
}
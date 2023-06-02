using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Resultado(Distancia d)
        {
            d.calcularDistancia();
           ViewBag.Res = d.resultado;
            return View();
        }
    }
}
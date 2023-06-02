﻿using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class Tienda2Controller : Controller
    {
        // GET: Tienda
        public ActionResult MuestraPulques2()
        {
            var pulquesVenta = new PulquesServices();
            var model = pulquesVenta.ObtenerPulques();
            return View(model);
        }
    }
}
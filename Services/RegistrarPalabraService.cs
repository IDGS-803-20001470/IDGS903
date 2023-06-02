using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace IDGS903_Tema1.Services
{
    public class RegistrarPalabraService
    {
        public void GuardarArhcivo(Traductor tr)
    {
            var textEsp = tr.txtEspa;
            var textIng= tr.txtIng;
            var datos =  textEsp.ToUpper() + '=' + textIng.ToUpper() + Environment.NewLine;
            var ruta = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            File.AppendAllText(ruta, datos);

        }
    }
}
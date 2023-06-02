using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class LeerServcie
    {
        public Array LeerArchivo()
        {
            Array maesData = null;
            var ruta = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(ruta))
            {
                maesData=File.ReadAllLines(ruta);
            }
            return maesData;
        }

        public Array LeerArchivoTraductor()
        {
            Array traductorData = null;
            var ruta = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            if (File.Exists(ruta))
            {
                traductorData = File.ReadAllLines(ruta);
            }
            return traductorData;
        }


    }
}
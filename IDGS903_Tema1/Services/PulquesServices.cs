using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class PulquesServices
    {
        public List<Pulques> ObtenerPulques()
        {
            var pulque = new Pulques()
            {
                Nombre = "Pulque 1",
                Descripcion = "Frutos Rojos",
                Litros = 25,
                Caducidad = new DateTime(2023,11,5)
            };
            var pulque2 = new Pulques()
            {
                Nombre = "Pulque 2",
                Descripcion = "Mazapan",
                Litros = 5,
                Caducidad = new DateTime(2023, 10, 5)
            };
            var pulque3 = new Pulques()
            {
                Nombre = "Pulque 3",
                Descripcion = "Coco",
                Litros = 23,
                Caducidad = new DateTime(2023, 5, 5)
            };

            return new List<Pulques> { pulque, pulque2, pulque3 };
        }
    }
}
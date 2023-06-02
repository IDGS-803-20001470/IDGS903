using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Distancia
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }

        public double resultado { get; set; }

        public void calcularDistancia()
        {

            double diferenciaX = this.x2 - this.x1;
            double diferenciaY = this.y2 - this.y1;


            double distancia = Math.Sqrt(Math.Pow(diferenciaX, 2) + Math.Pow(diferenciaY, 2));
            this.resultado = distancia;

        }


    }

    
}
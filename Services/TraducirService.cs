using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class TraducirService
    {
        public string traducirPalabra(TraductorRespuesta trR)
        {
            var textPalabra = (trR.palabra).ToUpper();
            var opcion = trR.tipo;
            //Debug.WriteLine("Opcion " + opcion);
            string[] traductorData = null;
            var resultado = "";
            var ruta = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            if (File.Exists(ruta))
            {
                traductorData = File.ReadAllLines(ruta);
            }


            for(int i = 0; i < traductorData.Length; i++)
            {
                string palabra = traductorData[i];
                Debug.WriteLine("For posicion "+i+": "+palabra);
                string[] words = palabra.Split('=');
                if (textPalabra == words[1] || textPalabra== words[0])
                {
                    Debug.WriteLine("Si esta  : " + palabra + " = " + textPalabra);
                    
                    if (opcion == "esp")
                    {
                        Debug.WriteLine("Español " + textPalabra);
                        resultado = words[1];
                        Debug.WriteLine("Si es igual: " + textPalabra + " = " + resultado);
                        return resultado;
                    }
                    else if(opcion == "ing")
                    {
                        resultado = words[0];
                        Debug.WriteLine("Si es igual: " + textPalabra + " = " + resultado);
                        Debug.WriteLine("Ingles " + textPalabra);
                        //textPalabra=palabraTraducida.ToString();
                        return resultado;

                    }
                    else
                    {
                        Debug.WriteLine("No es igual o no hay: " + palabra.ToString() + " = " + textPalabra);
                        resultado = "No existe la palabra";

                    }

                }
                else
                {
                    Debug.WriteLine("No es igual o no hay: " + palabra.ToString() + " = " + textPalabra);
                    resultado = "No existe la palabra";

                }
               

            }
            Debug.WriteLine("El resultado es : " + resultado);

            return resultado;
          

        }
    }
}
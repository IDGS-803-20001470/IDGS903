using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class CalcularTrianguloService
    {
        public string calcularTriangulo(Triangulos tri)
        {
            string respuesta = "";

            double ladoAB = CalcularDistancia(tri.xA, tri.yA, tri.xB, tri.yB);
            double ladoBC = CalcularDistancia(tri.xB, tri.yB, tri.xC, tri.yC);
            double ladoCA = CalcularDistancia(tri.xC, tri.yC, tri.xA, tri.yA);

            Debug.WriteLine("Lado AB: " + ladoAB);
            Debug.WriteLine("Lado BC: " + ladoBC);
            Debug.WriteLine("Lado CA: " + ladoCA);
            double area=0.0;
            double bases;
            bool resp = EsTriangulo2(tri.xA, tri.yA, tri.xB, tri.yB, tri.xC, tri.yC);
            bool resp2 = EsTriangulo(ladoAB, ladoBC, ladoCA);

            Debug.WriteLine("Es triangulo 1: " + resp);
            Debug.WriteLine("Es triangulo 2: " + resp2);

            if (resp)
            {
                if (ladoAB == ladoBC && ladoBC == ladoCA)
                {
                    Debug.WriteLine("El triángulo es equilátero.");
                    double a = ladoAB / 2;
                    double c = Math.Pow(ladoAB,2) - Math.Pow(a, 2);
                    double h= Math.Sqrt(c);
                    double h2=  (Math.Sqrt(3) / 2) * ladoAB;
                    Debug.WriteLine("Haltura 1 "+h);
                    Debug.WriteLine("Haltura 2 " + h2);

                     area = (ladoAB * h) / 2;
                    Debug.WriteLine("El area es: " + area);
                    respuesta = "El triangulo es Equilatero con un area de: " + area + " u2"; 
                }
                else if (ladoAB != ladoBC && ladoBC != ladoCA && ladoAB != ladoCA)
                {
                    Debug.WriteLine("El triángulo es escaleno.");
                    double semiperimetro = (ladoAB + ladoBC + ladoCA) / 2;
                    area = Math.Sqrt(semiperimetro * (semiperimetro - ladoAB) * (semiperimetro - ladoBC) * (semiperimetro - ladoCA));
                    respuesta = "El triangulo es Escaleno con un area de: " + area + " u2";

                }
                else
                {
                    if(ladoAB == ladoBC)
                    {
                        bases = ladoCA;
                        double a = bases / 2;
                        double c = Math.Pow(ladoAB, 2) - Math.Pow(a, 2);
                        double h = Math.Sqrt(c);
                        area = (bases * h) / 2;

                    }
                    else if(ladoBC==ladoCA)
                    {
                        bases=ladoAB;
                        double a = bases / 2;
                        double c = Math.Pow(ladoBC, 2) - Math.Pow(a, 2);
                        double h = Math.Sqrt(c);
                        area = (bases * h) / 2;
                    }
                    else
                    {
                        bases = ladoBC;
                        double a = bases / 2;
                        double c = Math.Pow(ladoAB, 2) - Math.Pow(a, 2);
                        double h = Math.Sqrt(c);
                        area = (bases * h) / 2;
                    }
                    
                    respuesta = "El triangulo es Isósceles con un area de: " + area+ " u2";
                }
            }
            else
            {
                Debug.WriteLine("Las longitudes de los lados no forman un triángulo válido.");
                respuesta = "No es un triangulo";
                
            }
            return respuesta;
        }

        static double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return Math.Round(distancia);
        }
        static bool EsTriangulo(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2;
        }

        public bool EsTriangulo2(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Calcula las pendientes de las líneas formadas por los puntos
            double pendienteAB = (y2 - y1) / (x2 - x1);
            double pendienteAC = (y3 - y1) / (x3 - x1);

            // Comprueba si las pendientes son diferentes (no están alineados)
            if (pendienteAB != pendienteAC)
            {
                return true; // Los puntos forman un triángulo
            }
            else
            {
                return false; // Los puntos están alineados, no forman un triángulo
            }
        }


    }
}

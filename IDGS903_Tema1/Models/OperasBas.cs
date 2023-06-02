using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class OperasBas
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public float Resultado { get; set; }

        public void Sumar() { 
        this.Resultado = this.n1 + this.n2;
            
        }
        public void Restar()
        {
            this.Resultado = this.n1 - this.n2;
        }
        public void Multiplicar()
        {
            this.Resultado = this.n1 * this.n2;
        }
        public void Dividir()
        {
            this.Resultado = this.n1 / this.n2;
        }

        public void opcionOperacion(OperasBas op,string operacion)
        { 
            var model = new OperasBas();
            switch (operacion)
            {
                case "1":
                    op.Sumar();
                    break;
                case "2":
                    op.Restar();
                    break;
                case "3":
                    op.Multiplicar();
                    break;
                case "4":
                    op.Dividir();
                    break;
                default:
                    model.Resultado = 1;
                    break;

            }
        }

        /*
        public float Sumar()
        {
            return this.Resultado = this.Num1 + this.Num2;
        }
        public float Restar()
        {
            return this.Resultado = this.Num1 - this.Num2;

        }
        public float Multiplicar()
        {
            return this.Resultado = this.Num1 * this.Num2;
        }
        public float Dividir()
        {
            return this.Resultado = this.Num1 / this.Num2;
        }*/


    }
}
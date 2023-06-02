using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: nuevo
        public ActionResult Ventana(OperasBas op, string operacion)
        {

            var model = new OperasBas();
            model.opcionOperacion( op,operacion);
            
            /*switch (operacion)
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

            }*/
            
            model.Resultado = op.Resultado;



            return View(model);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejemploMVC.Models;

namespace ejemploMVC.Controllers
{
    public class PruebaController : Controller
    {
        //
        // GET: /Prueba/
        public ActionResult Index()
        {
            return View();
        }

        //POST: PRUEBA/INDEX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(calculo obCalculo)
        {
            //operaciones
            int opcion = obCalculo.opcion;
            int resultado = 0;

            switch (opcion)
            {
                case 1:
                        //suma
                        resultado = obCalculo.numero1 + obCalculo.numero2;
                        ViewBag.resultado = resultado;
                        break;
                case 2:
                        //resta
                        resultado = obCalculo.numero1 - obCalculo.numero2;
                        ViewBag.resultado = resultado;
                        break;
                case 3:
                        //Multiplicar
                        resultado = obCalculo.numero1 * obCalculo.numero2;
                        ViewBag.resultado = resultado;
                        break;
                case 4:
                        //Dividir
                        resultado = obCalculo.numero1 / obCalculo.numero2;
                        ViewBag.resultado = resultado;
                        break;
                case 0:
                        //Sin opcion
                        //resta
                        ViewBag.resultado = "No a seleccionado ninguna accion";
                        break;
            }
            
            return View(obCalculo);
        }
	}
}
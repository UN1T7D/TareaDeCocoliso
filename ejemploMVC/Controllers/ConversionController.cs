using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejemploMVC.Models;

namespace ejemploMVC.Controllers
{
    public class ConversionController : Controller
    {
        //
        // GET: /Conversion/
        public ActionResult Index()
        {
            return View();
        }

        //POST: PRUEBA/INDEX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(conversion obConversion)
        {
            //operaciones
            int opcion = obConversion.opcion;
            double resultado = 0.0;

            //1 Celsius = 274.15 Kelvin
            //1 Kelvin = -272.15 Celsius


            switch (opcion)
            {
                case 1:
                    //suma
                    resultado = obConversion.temperatura + (274.15-1);
                    ViewBag.resultado = resultado;
                    break;
                case 2:
                    //resta
                    resultado = obConversion.temperatura + (-272.15-1);
                    ViewBag.resultado = resultado;
                    break;
                case 0:
                    //Sin opcion
                    //resta
                    ViewBag.resultado = "No a seleccionado ninguna accion";
                    break;
            }

            return View(obConversion);
        }

        public ActionResult Peso(conversion obConversion)
        {
            //operaciones
            int opcion = obConversion.opcion;
            double resultado = 0.0;

            //1 lb = 0.453592 kg
            //1 kg = 2.2046 lb


            switch (opcion)
            {
                case 1:
                    //de kilos a libras
                    resultado = obConversion.peso * 2.2046;
                    ViewBag.resultado = resultado;
                    break;
                case 2:
                    //de libras a kilos
                    resultado = obConversion.peso * 0.453592;
                    ViewBag.resultado = resultado;
                    break;
                case 0:
          
                    ViewBag.resultado = "No a seleccionado ninguna accion";
                    break;
            }

            return View(obConversion);
        }

        public ActionResult Longitud(conversion obConversion)
        {
            //operaciones
            int opcion = obConversion.opcion;
            double resultado = 0.0;

            //1 m = 39.37007874 in
            //1 in = 0.0254 m


            switch (opcion)
            {
                case 1:
                    //de metros a pulgadas
                    resultado = obConversion.longitud * 39.37007874;
                    ViewBag.resultado = resultado;
                    break;
                case 2:
                    //de pulgadas a metros
                    resultado = obConversion.longitud * 0.0254;
                    ViewBag.resultado = resultado;
                    break;
                case 0:
                    ViewBag.resultado = "No a seleccionado ninguna accion";
                    break;
            }

            return View(obConversion);
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejemploMVC.Models;

namespace ejemploMVC.Controllers
{
    public class PromedioController : Controller
    {
        //
        // GET: /Promedio/
        public ActionResult Index()
        {
            return View();
        }

        //POST: PROMEDIO/INDEX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(promedio obPromedio)
        {
            //operaciones
            double promedio = 0.0;

            promedio = (obPromedio.nota1 + obPromedio.nota2 + obPromedio.nota3)/3;

            if (promedio == 10)
            {
                ViewBag.resultado = "Felicidades has sacado la nota maxima";
            }else
                if (promedio < 10 && promedio >= 7)
                {
                    ViewBag.resultado = "Aprobado";
                }else
                    if (promedio < 7 && promedio > 4)
                    {
                        ViewBag.resultado = "Aplazado";
                    }else
                        if (promedio <= 4)
                        {
                            ViewBag.resultado = "Debe de visitar al tutor";
                        }
                        else
                        {
                            ViewBag.resultado = "Tu promedio no es el indicado";
                        }

            

            return View(obPromedio);
        }
	}
}
using EmotionPlatziWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmotionPlatziWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.WelcomeMessage = "Hola Mundo";
            ViewBag.ValorEntero = 1;
            return View();
        }
        public ActionResult IndexAlt()
        {
            var modelo = new Home();
            modelo.WelcomeMsg = "hola mundo desde el modelo";
            return View(modelo);
        }
    }
}
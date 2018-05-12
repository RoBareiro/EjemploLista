using System.Collections.Generic;
using System.Web.Mvc;
using Practica1rocio.Models;

namespace Practica1rocio.Controllers
{
    public class PersonaController : Controller
    {

        private static List<Persona> personas = new List<Persona>;

        public ActionResult Index()
        {
            Persona laPersona = new Persona {
                Nombre = "Rocío",
                Apellido = "Bareiro",
                Edad = 27
            };
            return View();
        }
    }
}
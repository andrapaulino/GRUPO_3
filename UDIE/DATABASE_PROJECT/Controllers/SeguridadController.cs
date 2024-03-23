using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DATABASE_PROJECT.Controllers
{
    public class SeguridadController : Controller
    {
        // GET: Seguridad
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult AccederLogin(string usuario = "", string clave = "") 
        {
            return View(); //retornar al perfil correspondiente (Funcional, Técnico y Administrador)
        }
    }
}
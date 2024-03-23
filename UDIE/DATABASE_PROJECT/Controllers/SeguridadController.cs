using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

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
            return View("_UsuarioAdmin"); //retornar al perfil correspondiente (Funcional, Técnico y Administrador)
        }


        public ActionResult _UsuarioFuncional()
        {
            return View();
        }

        public ActionResult _UsuarioTecnico() 
        {
        
            return View();
        
        }
        public ActionResult _UsuarioAdmin()
        {
            return View();
        }
    }
}

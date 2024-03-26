using capaNEGOCIOS.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DATABASE_PROJECT.Controllers
{
    public class SeguridadController : Controller
    {

        public AccionSeguridad accionSeguridad = new AccionSeguridad();

        // GET: Seguridad
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult btnIniciarSesion(string usuario = "", string clave = "") 
        {
            string vista = string.Empty;
           if (accionSeguridad.AutheticationUser(usuario, clave))
            {

                vista = accionSeguridad.GetProfileUsers(usuario);
            
            }
            else
            {



            }


            return View("_UsuarioFuncional");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DATABASE_PROJECT.Controllers
{
    public class MantenimientoController : Controller
    {
        // GET: Mantenimiento
        public ActionResult Index()
        {

            VM_Operaciones oper = new VM_Operaciones();

            oper._Operaciones = mantenimientos.ListaOperacionSistema();

            return View(operaciones);
        }

        public ActionResult MantenimientoTablas() 
        
        {
            return View();
        
        }
    }
}
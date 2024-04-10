using capaNEGOCIOS.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DATABASE_PROJECT.Controllers
{
    public class MantenimientoController : Controller
    {

        public AccionesConsultas mantenimientos = new AccionesConsultas();

        // GET: Mantenimiento
        public ActionResult Index()
        {
           VM_Operaciones oper = new VM_Operaciones();

           oper._tblOperaciones = mantenimientos.ListaOperacionSistema();

            return View(oper);
        }

        public ActionResult MantenimientoTablas()
        {
            return View();
        }

    }

}



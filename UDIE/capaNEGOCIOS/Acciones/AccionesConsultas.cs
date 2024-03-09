using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capaDATOS.DataBase;


namespace capaNEGOCIOS.Acciones
{
    public class AccionesConsultas : AccionesBases
    {

        //metodos de listar
        public List<Alumnos> listAlumnos()
        {
            return dblibcontext.Alumnos.ToList();
        }

}

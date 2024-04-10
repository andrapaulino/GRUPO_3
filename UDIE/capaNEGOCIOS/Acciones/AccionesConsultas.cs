using System.Collections.Generic;
using System.Linq;
using capaDATOS.DataBase;


namespace capaNEGOCIOS.Acciones
{
    public class AccionesConsultas : AccionesBases
    {
        public List<mEstatus>ListarEstados()



        public List<TM_OperacionSistema>ListaOperacionSistema()
        {
            var lista = dblibcontext.TM_OperacionSistemas.ToList();
            return lista == null ? new List<TM_OperacionSistema>() : lista;
        }
        #region Listados Genericos

        //metodos de listar
        public List<Alumnos> listAlumnos()
        {
            return dblibcontext.Alumnos.ToList();
        }
        public List<AlumnosxRecursosAprendizaje> listAlumnosxRecursosAprendizaje()
        {
            return dblibcontext.AlumnosxRecursosAprendizaje.ToList();
        }
        public List<CalendarioAcademico> listCalendarioAcademico()
        {
            return dblibcontext.CalendarioAcademico.ToList();
        }
        public List<CalendarioAcademicoxExamen> listCalendarioAcademicoxExamen()
        {
            return dblibcontext.CalendarioAcademicoxExamen.ToList();
        }
        public List<CalendarioAcademicoxRecursosAprendizaje> CalendarioAcademicoxRecursosAprendizaje()
        {
            return dblibcontext.CalendarioAcademicoxRecursosAprendizaje.ToList();
        }
        public List<Comunicación> listComunicacion()
        {
            return dblibcontext.Comunicación.ToList();
        }
        public List<Cursos> listCursos()
        {
            return dblibcontext.Cursos.ToList();
        }
        public List<Examenes> listExamenes()
        {
            return dblibcontext.Examenes.ToList();
        }
        public List<Profesores> listProfesores()
        {
            return dblibcontext.Profesores.ToList();
        }

        public List<ProfesorxCurso> listProfesorxCurso()
        {
            return dblibcontext.ProfesorxCurso.ToList();
        }
        public List<RecursosAprendizaje> listRecursosAprendizaje()
        {
            return dblibcontext.RecursosAprendizaje.ToList();
        }
        public List<Tareas> listTareas()
        {
            return dblibcontext.Tareas.ToList();
        }
        #endregion

        #region Filtros relacionales 
        public List<Cursos> listCursos(string nombre)
        {
            return dblibcontext.Cursos.Where(x => x.Nombre == nombre).ToList();
        }
        public List<Profesores> listProfesores(string cedula)
        {
            return dblibcontext.Profesores.Where(x => x.Cédula == cedula).ToList();
        }
        public List<Alumnos> listAlumnos(string identificacion)
        {
            return dblibcontext.Alumnos.Where(x => x.Identificación == identificacion).ToList();
        }
        public List<Tareas> listTareas(int alumnoId)
        {
            return dblibcontext.Tareas.Where(x => x.AlumnoID == alumnoId).ToList();
        }

        #endregion

        public List<TM_OperacionSistema> ListaOperacionesSistema()
        {

            var lista = _DbEnlace.TM_OperacionSistemas.ToList();
            return lista == null ? new List<TM_OperacionSistema>() : lista;
        }

       


    }
}

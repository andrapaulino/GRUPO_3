using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDATOS.DataBase;


namespace capaNEGOCIOS.Acciones
{
    public class AccionSeguridad : AccionesBases
    {

        public int codUser = 0;


        public bool AutheticationUser(string usuario, string clave)

        {
            bool _access = false;

            try
            {
                var validate = dblibcontext.TM_Usuario
                    .FirstOrDefault(x => x.PasswordUser == clave & x.UserName == usuario);

                _access = (validate != null) ? true : false;


            }
            catch
            {
                return false;
            }

            return _access;
        }

        public string GetProfileUsers(string nomUsers)
        {
            string perfil = string.Empty;

            try
            {
                perfil = dblibcontext.vw_Usuarios.FirstOrDefault(x => x.nomUsuario == nomUsers).perfilUsuario;
            
            }
            catch
            {
                return string.Empty;

            }
            return perfil;
        
        
        }

        public List<TM_Usuario>GetUsers()
        {
            return dblibcontext.TM_Usuario.ToList();
        }
          
    }
}

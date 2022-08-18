using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class RolController
    {
        public static List<Rol> listaRol = new List<Rol>();

        public static void crearRoles()
        {
            listaRol.Add(new Rol()
            {
                _idRol = 1,
                _rol = "Administrador"
            });

            listaRol.Add(new Rol()
            {
                _idRol = 2,
                _rol = "Vendedor"
            });

        }

        public static List<Rol> lista()
        {
            return listaRol;
        }

        public static string buscarRol(int id)
        {

            foreach (Rol r in lista())
            {
                if (r._idRol.Equals(id))
                {
                    return r._rol;
                }
            }

            return null;
        }


    }
}
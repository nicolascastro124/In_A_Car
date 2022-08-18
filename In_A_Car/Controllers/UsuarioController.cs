using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class UsuarioController
    {
        public static List<Usuario> listaUsuario = new List<Usuario>();
        public static int a = 0;
        public UsuarioController()
        {
        }
        public static void adminIniciales()
        {
            if (a == 0)
            {
                crearUsuario("1", "Nicolas Castro", "nicolasc@gmail.com", "1234", 1);
                crearUsuario("2", "Jorge Alvarez", "jorgea@gmail.com", "1234", 1);
                crearUsuario("3", "Nicolas Jimenez", "nicolasj@gmail.com", "1234", 1);
                a = 1;
            }
        }
        public static string crearUsuario(string id, string nombre, string correo, string pass, int idrol)
        {
            listaUsuario.Add(new Usuario()
            {
                _id = id,
                _nombre = nombre,
                _email = correo,
                _contraseña = pass,
                _idRolFK = idrol
            });

            return "Usuario registrado con exito!";
        }

        public static List<Usuario> lista()
        {
            return listaUsuario;
        }
        public static Usuario buscarUsuario(string id)
        {

            foreach (Usuario u in listaUsuario)
            {
                if (u._id.Equals(id))
                {
                    return u;
                }
            }

            return null;
        }

        public static string buscarTipo(int u)
        {
            string t = RolController.buscarRol(u);
            if(t!= null)
            {
                return t;
            }

            return null;
        }











    }
}
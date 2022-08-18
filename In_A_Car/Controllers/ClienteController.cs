using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class ClienteController
    {
        public static List<Cliente> listaCliente = new List<Cliente>();


        public static string crearCliente(string id, string nombreCliente, string contraseña, string correo, string direccion, string numero)
        {

            listaCliente.Add(new Cliente()
            {
                _id = id,
                _nombre = nombreCliente,
                _contraseña = contraseña,
                _correo = correo,
                _direccion = direccion,
                _numero = numero


            });

            return "Registrado con éxito!";

        }

        public static Cliente buscarCliente(string id)
        {

            foreach (Cliente c in listaCliente)
            {
                if (c._id.Equals(id))
                {
                    return c;
                }
            }

            return null;
        }

        public static List<Cliente> lista()
        {
            return listaCliente;
        }








    }
}
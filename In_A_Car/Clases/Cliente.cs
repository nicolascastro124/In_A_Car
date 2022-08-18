using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class Cliente
    {
		private string id;
		private string nombre;
		private string direccion;
		private string numero;
		private string correo;
		private string contraseña;

		public Cliente()
		{

		}


		public string _contraseña
		{
			get { return contraseña; }
			set { contraseña = value; }
		}


		public string _correo
		{
			get { return correo; }
			set { correo = value; }
		}

		public string _numero
		{
			get { return numero; }
			set { numero = value; }
		}


		public string _direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}


		public string _nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}


		public string _id
		{
			get { return id; }
			set { id = value; }
		}


	}
}
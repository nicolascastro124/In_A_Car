using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class Proveedor
    {
		private string id;
		private string nombre;
		private string numero;
		private string direccion;

		public Proveedor()
		{

		}

		public string _direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}


		public string _numero
		{
			get { return numero; }
			set { numero = value; }
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
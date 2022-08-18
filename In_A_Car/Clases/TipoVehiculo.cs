using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class TipoVehiculo
    {
		private int id;
		private string tipo;

		public TipoVehiculo()
		{
		}

		public string _tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}


		public int _id
		{
			get { return id; }
			set { id = value; }
		}



	}
}
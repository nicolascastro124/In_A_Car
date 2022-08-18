using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class MarcaVehiculo
    {
		private int id;
		private string marca;

		public MarcaVehiculo()
		{

		}

		public string _marca
		{
			get { return marca; }
			set { marca = value; }
		}


		public int _id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
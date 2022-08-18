using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class Registro
    {
		private int id;
		private string fecha;
		private int cantidad;
		private int precio;
		private int idVehiculoFK;

		public Registro()
		{

		}

		public int _idVehiculoFK
		{
			get { return idVehiculoFK; }
			set { idVehiculoFK = value; }
		}


		public int _precio
		{
			get { return precio; }
			set { precio = value; }
		}



		public int _cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}


		public string _fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}


		public int _id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
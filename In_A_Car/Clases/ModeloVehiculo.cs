using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class ModeloVehiculo
    {
		private int id;
		private string modelo;
		private int idMarcaFK;

		public ModeloVehiculo()
		{
		}

		public int _idMarcaFK
		{
			get { return idMarcaFK; }
			set { idMarcaFK = value; }
		}


		public string _modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}


		public int _id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class Vehiculo
    {
		private int id;
		private int precio;
		private int idProvFK;
		private int idTipoFK;
		private int idModeloFK;

		public Vehiculo()
		{

		}

		public int _idModeloFK
		{
			get { return idModeloFK; }
			set { idModeloFK = value; }
		}


		public int _idTipoFK
		{
			get { return idTipoFK; }
			set { idTipoFK = value; }
		}


		public int _idProvFK
		{
			get { return idProvFK; }
			set { idProvFK = value; }
		}


		public int _precio
		{
			get { return precio; }
			set { precio = value; }
		}


		public int _id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
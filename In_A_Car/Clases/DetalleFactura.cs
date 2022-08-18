using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car.Clases
{
    public class DetalleFactura
    {

		private int id;
		private int cantidad;
		private int precioTotal;
		private string idFacturaFK;
		private string idVehFK;

		public DetalleFactura()
		{

		} 

		public string _idVehFK
		{
			get { return idVehFK; }
			set { idVehFK = value; }
		}


		public string _idFacturaFK
		{
			get { return idFacturaFK; }
			set { idFacturaFK = value; }
		}


		public int _precioTotal
		{
			get { return precioTotal; }
			set { precioTotal = value; }
		}


		public int _cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}


		public int _id
		{
			get { return id; }
			set { id = value; }
		}



	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car
{
    public class Usuario
    {
		private string id;
		private string nombre;
		private string email;
		private string contraseña;
		private int idRolFK;

		public Usuario()
		{

		}

		public int _idRolFK
		{
			get { return idRolFK; }
			set { idRolFK = value; }
		}


		public string _id
		{
			get { return id; }
			set { id = value; }
		}

		public string _contraseña
		{
			get { return contraseña; }
			set { contraseña = value; }
		}


		public string _email
		{
			get { return email; }
			set { email = value; }
		}


		public string _nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

	}
}
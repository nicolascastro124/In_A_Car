using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_A_Car.Clases
{
    public class Factura
    {
        int id;
        int nroFactura;
        string fecha;
        int totalFactura;
        string idUsuarioFK;
        string idClienteFK;

        public Factura()
        {

        }

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public int _nroFactura
        {
            get { return nroFactura; }
            set { nroFactura = value; }
        }
        public string _fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int _totalFactura
        {
            get { return totalFactura; }
            set { totalFactura = value; }
        }
        public string _ididUsuarioFK
        {
            get { return idUsuarioFK; }
            set { idUsuarioFK = value; }
        }
        public string _idClienteFK
        {
            get { return idClienteFK; }
            set { idClienteFK = value; }
        }









    }
}
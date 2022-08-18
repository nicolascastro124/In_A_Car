using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace In_A_Car
{
    public partial class listarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["LoginAdmin"]== null)
            {
                Response.Redirect("LoginAdmin.aspx");
            }
            GRD();
        }

        public void GRD()
        {
            var cl = from u in UsuarioController.lista()
                     select new
                     {
                         ID = u._id,
                         Nombre = u._nombre,
                         Correo = u._email,
                         Rol = UsuarioController.buscarTipo(u._idRolFK),
             
                     };
            grdLista.DataSource = cl.ToList();
            grdLista.DataBind();
        }

        protected void grdLista_SelectedIndexChanged(object sender, GridViewPageEventArgs e)
        {
            grdLista.PageIndex = e.NewPageIndex;
            grdLista.DataBind();
            GRD();
        }

        public string GRDBuscar(string rut)
        {
            Usuario us = UsuarioController.buscarUsuario(rut);
            if (us != null)
            {
                var cl = from u in UsuarioController.lista()
                         where rut == u._id
                         select new
                         {
                             ID = u._id,
                             Nombre = u._nombre,
                             Correo = u._email,
                             Rol = UsuarioController.buscarTipo(u._idRolFK),

                         };
                grdLista.DataSource = cl.ToList();
                grdLista.DataBind();
                return lbMensaje.Text = "";
            }

            return "Usuario no encontrado";
                
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string rut = txtBuscar.Text;

            lbMensaje.Text = GRDBuscar(rut);
        }
    }
}
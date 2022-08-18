using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace In_A_Car
{
    public partial class crearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarTipos();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           lbMensaje.Text = UsuarioController.crearUsuario(txtRut.Text, txtNombre.Text, txtCorreo.Text, txtPass.Text, int.Parse(ddlTipo.SelectedValue));
        }

        public void cargarTipos()
        {
            ddlTipo.DataSource = from r in RolController.lista()
                                 select new
                                 {
                                     TIPO = r._idRol,
                                     TIPO2 = r._rol
                                 };
            ddlTipo.DataValueField = "TIPO";
            ddlTipo.DataTextField = "TIPO2";
            ddlTipo.DataBind();
        }

        
            
            

    

    }
}
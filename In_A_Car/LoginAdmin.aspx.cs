using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace In_A_Car
{
    public partial class LoginAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
                UsuarioController.adminIniciales();

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            Usuario u = UsuarioController.buscarUsuario(txtId.Text);
            if (u != null)
            {
                if (u._contraseña.Equals(txtContraseña.Text))
                {
                    Session["LoginAdmin"] = u;
                    lbMensaje.Text = "¡Sesión iniciada con éxito!";
                    lbLogin.Text = "¡Bienvenido " + u._nombre + "!";
                    Response.Redirect("indexAdmin.aspx");
                }
                else
                {
                    lbMensaje.Text = "No se pudo iniciar sesión";
                }


            }
            else
            {
                lbMensaje.Text = "No se pudo iniciar sesión";
            }
        }
    }
}
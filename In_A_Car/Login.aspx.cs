using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace In_A_Car
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Cliente c = ClienteController.buscarCliente(txtId.Text);
            if (c != null)
            {
                if (c._contraseña.Equals(txtContraseña.Text))
                {
                    Session["Login"] = c;
                    lbMensaje.Text = "¡Sesión iniciada con éxito!";
                    lbLogin.Text = "¡Bienvenido " + c._nombre + "!";
                    Response.Redirect("indexS.aspx");
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

        protected void lnkReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroClientes.aspx");
        }

        protected void lnkLoginAdmib_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginAdmin.aspx");
        }
    }
}
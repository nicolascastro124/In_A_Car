using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace In_A_Car
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = ClienteController.crearCliente(txtId.Text, txtNombre.Text, txtContraseña.Text, txtCorreo.Text, txtDireccion.Text, txtNumero.Text);
        }

        protected void lnkReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
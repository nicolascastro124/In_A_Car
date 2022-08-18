using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace In_A_Car.MasterPages
{
    public partial class SesionIniciada : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cliente c = (Cliente)Session["Login"];
            lbNombre.Text = c._nombre;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace In_A_Car
{
    public partial class indexAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["LoginAdmin"] == null)
            {
                Response.Redirect("LoginAdmin.aspx");
            }
            RolController.crearRoles();
        }
    }
}
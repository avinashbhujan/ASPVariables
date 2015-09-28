using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVariables
{
    public partial class SessionResultsPage : System.Web.UI.Page
    {
		
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResults.Text = (string)(Session["FirstName"]);
        }
    }
}
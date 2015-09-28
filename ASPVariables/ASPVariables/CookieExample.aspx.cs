using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVariables
{
    public partial class CookieExample : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["userName"].Value = "avinash";
            Response.Cookies["userName"].Expires = DateTime.Now.AddDays(1);

            //HttpCookie aCookie = new HttpCookie("lastVisit");
            //aCookie.Value = DateTime.Now.ToString();
            //aCookie.Expires = DateTime.Now.AddDays(1);
            //Response.Cookies.Add(aCookie);
            //Response is for writing cookies back and Request is for reading cookies
        }

        protected void btnTestVariable_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResultsPage.aspx");
        }
    }
}
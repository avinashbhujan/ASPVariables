﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVariables
{
    public partial class CookiesResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userName"] != null)
            {
                lblResult.Text = Server.HtmlEncode(Request.Cookies["userName"].Value);
            }
        }
    }
}
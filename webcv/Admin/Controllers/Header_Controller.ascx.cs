﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webcv.Admin.Controllers
{
    public partial class Header_Controller : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] == null && Session["UserEmail"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}
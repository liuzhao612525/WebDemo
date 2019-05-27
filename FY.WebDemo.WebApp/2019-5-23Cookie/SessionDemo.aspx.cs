using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FY.WebDemo.WebApp._2019_5_23Cookie
{
    public partial class SessionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string name = Request.Form["name"];
                Session["username"] = name;
                Response.Redirect("Test.aspx");
            }
        }
    }
}
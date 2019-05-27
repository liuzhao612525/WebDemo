using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FY.WebDemo.WebApp._2019_5_23Cookie
{
    public partial class CookieDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["cp2"].Value = "laowang";
            Response.Cookies["cp2"].Path = "/2019-5-23";
            Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(7);

            HttpCookie cookie1 = new HttpCookie("cp3", "sss");
            cookie1.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(cookie1);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace FY.WebDemo.WebApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            int count = Convert.ToInt32(Application["count"]);
            count++;
            Application["count"] = count;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //捕获异常
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            int count = Convert.ToInt32(Application["count"]);
            count--;
            Application["count"] = count;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_24
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userName = context.Request["userName"];
            string pwd = context.Request["pwd"];
            BLL.UserInfoService userInfoService = new BLL.UserInfoService();
            Model.UserInfo userInfo = null;
            string msg = string.Empty;
            bool res = userInfoService.ValidateUserInfo(userName, pwd, out msg , out userInfo);
            if (res)
            {
                //context.Session["UserInfo"] = userInfo;
                context.Response.Write("ok:" + msg);
            }
            else
            {
                context.Response.Write("no:" + msg);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
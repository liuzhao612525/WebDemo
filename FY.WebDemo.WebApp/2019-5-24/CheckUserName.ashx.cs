using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_24
{
    /// <summary>
    /// CheckUserName 的摘要说明
    /// </summary>
    public class CheckUserName : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userName = context.Request["userName"];
            BLL.UserInfoService userInfoService = new BLL.UserInfoService();
            if (userInfoService.GetUserInfo(userName) != null)
            {
                context.Response.Write("用户已存在");

            }
            else
            {
                context.Response.Write("此用户可用");
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
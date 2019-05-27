using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_24
{
    /// <summary>
    /// DeleteUser 的摘要说明
    /// </summary>
    public class DeleteUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int Id = Convert.ToInt32(context.Request["Id"]);
            BLL.UserInfoService userInfoService = new BLL.UserInfoService();
            if (userInfoService.DeleteUserInfo(Id))
            {
                context.Response.Write("ok");
            }
            else
            {
                context.Response.Write("no");
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_23Webform
{
    /// <summary>
    /// Delete 的摘要说明
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id;
            if (int.TryParse(context.Request.QueryString["id"] ,out id))
            {
                BLL.UserInfoService userInfoService = new BLL.UserInfoService();
                if (userInfoService.DeleteUserInfo(id))
                {
                    context.Response.Redirect("UserInfoList.aspx");
                }
                else
                {
                    context.Response.Redirect("/Error.html");
                }
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
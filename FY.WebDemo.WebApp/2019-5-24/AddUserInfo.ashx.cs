using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_24
{
    /// <summary>
    /// AddUserInfo 的摘要说明
    /// </summary>
    public class AddUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            Model.UserInfo userInfo = new Model.UserInfo();
            userInfo.UserName = context.Request["txtName"];
            userInfo.Password = context.Request["txtPwd"];
            userInfo.Email = context.Request["txtEmail"];
            userInfo.RegTime = DateTime.Now;
            BLL.UserInfoService userInfoService = new BLL.UserInfoService();
            if (userInfoService.AddUserInfo(userInfo))
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
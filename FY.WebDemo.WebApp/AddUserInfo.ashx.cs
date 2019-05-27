using FY.WebDemo.BLL;
using FY.WebDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp
{
    /// <summary>
    /// AddUserInfo 的摘要说明
    /// </summary>
    public class AddUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userName = context.Request.Form["txtName"];
            string pwd = context.Request.Form["txtPwd"];
            string email = context.Request.Form["txtEmail"];

            UserInfo userInfo = new UserInfo();
            userInfo.UserName = userName;
            userInfo.Password = pwd;
            userInfo.Email = email;
            userInfo.RegTime = DateTime.Now;
            bool res = new UserInfoService().AddUserInfo(userInfo);
            
            if (res)
            {
                context.Response.Redirect("UserInfoList.ashx");
            }
            else
            {
                context.Response.Redirect("Error.html");
            }

            context.Response.Write("Hello World");
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
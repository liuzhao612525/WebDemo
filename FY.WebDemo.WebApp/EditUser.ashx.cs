using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FY.WebDemo.Model;
using FY.WebDemo.BLL;

namespace FY.WebDemo.WebApp
{
    /// <summary>
    /// EditUser 的摘要说明
    /// </summary>
    public class EditUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfoService userInfoService = new UserInfoService();
            int Id = int.Parse(context.Request.Form["txtId"]);
            
            UserInfo userInfo = userInfoService.GetUserInfo(Id);
            userInfo.Id = Id;
            userInfo.UserName = context.Request.Form["txtName"];
            userInfo.Password = context.Request.Form["txtPwd"];
            userInfo.Email = context.Request.Form["txtEmail"];
            bool res = userInfoService.EditUserInfo(userInfo);
            if (res)
            {
                context.Response.Redirect("UserInfoList.ashx");
            }
            else
            {
                context.Response.Redirect("Error.html");
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using FY.WebDemo.BLL;
using FY.WebDemo.Model;


namespace FY.WebDemo.WebApp
{
    /// <summary>
    /// ShowEditUser 的摘要说明
    /// </summary>
    public class ShowEditUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            int id;
            if (int.TryParse(context.Request.QueryString["id"] ,out id))
            {
                UserInfoService userInfoService = new UserInfoService();
                UserInfo userInfo = userInfoService.GetUserInfo(id);
                if (userInfo != null)
                {
                    string filePath = context.Request.MapPath("ShowEditUser.html");
                    string fileContent = File.ReadAllText(filePath);
                    fileContent = fileContent.Replace("$name", userInfo.UserName).Replace("$pwd", userInfo.Password).Replace("$email", userInfo.Email).Replace("$Id", userInfo.Id.ToString());
                    context.Response.Write(fileContent);
                }
            }
            else
            {
                context.Response.Write("参数错误");

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
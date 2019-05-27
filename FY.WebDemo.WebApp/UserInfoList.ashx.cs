using FY.WebDemo.BLL;
using FY.WebDemo.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace FY.WebDemo.WebApp
{
    /// <summary>
    /// UserInfoList 的摘要说明
    /// </summary>
    public class UserInfoList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            UserInfoService userInfoService = new UserInfoService();
            List<UserInfo> list = userInfoService.GetList();
            StringBuilder sb = new StringBuilder();
            foreach (UserInfo userInfo in list)
            {
                sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='ShowDetail.ashx?id={0}'>详情</a></td><td><a href='ShowEditUser.ashx?id={0}'>编辑</a></td><td><a href='DeleteUser.ashx?id={0}' class='delete'>删除</a></td></tr>", userInfo.Id, userInfo.UserName, userInfo.Password, userInfo.Email, userInfo.RegTime);
            }
            string filePath = context.Request.MapPath("UserInfoList.html");
            var fileContent = File.ReadAllText(filePath);
            fileContent = fileContent.Replace("@tbody", sb.ToString());
            context.Response.Write(fileContent);
            
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_24
{
    /// <summary>
    /// EditUserInfo 的摘要说明
    /// </summary>
    public class EditUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            Model.UserInfo userInfo = new Model.UserInfo();
            userInfo.Id = Convert.ToInt32(context.Request["txtEditUserId"]);
            userInfo.UserName = context.Request["txtEditUserName"];
            userInfo.Password = context.Request["txtEditUserPwd"];
            userInfo.Email = context.Request["txtEditUserEmail"];
            userInfo.RegTime = Convert.ToDateTime(context.Request["txtEditRegTime"]);
            BLL.UserInfoService userInfoService = new BLL.UserInfoService();
            if (userInfoService.EditUserInfo(userInfo))
            {
                context.Response.Write("ok");
            }
            else{
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
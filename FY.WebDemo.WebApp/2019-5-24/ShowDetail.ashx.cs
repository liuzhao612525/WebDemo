using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_24
{
    /// <summary>
    /// ShowDetail 的摘要说明
    /// </summary>
    public class ShowDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int Id = Convert.ToInt32(context.Request["Id"]);
            BLL.UserInfoService userInfoService = new BLL.UserInfoService();
            Model.UserInfo userInfo = userInfoService.GetUserInfo(Id);
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string contentStr = js.Serialize(userInfo);
            context.Response.Write(contentStr);
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
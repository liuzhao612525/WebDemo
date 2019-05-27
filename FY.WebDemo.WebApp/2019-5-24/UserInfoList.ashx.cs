using FY.WebDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_24
{
    /// <summary>
    /// UserInfoList 的摘要说明
    /// </summary>
    public class UserInfoList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            int pageIndex;
            if (!int.TryParse(context.Request["pageIndex"] ,out pageIndex))
            {
                pageIndex = 1;
            }
            int pageSize = 5;
            BLL.UserInfoService userInfoService = new BLL.UserInfoService();
            int pageCount = userInfoService.GetPageCount(pageSize);
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
            List<UserInfo> list = userInfoService.GetPageList(pageIndex ,pageSize);

            //获取页面条
            string pageBar = Common.PageBarHelper.GetPagaBar(pageIndex, pageSize);

            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string str = js.Serialize(new { ulist = list  , myPageBar = pageBar});
            context.Response.Write(str);
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
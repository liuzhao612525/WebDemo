using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FY.WebDemo.WebApp._2019_5_27
{
    public partial class CacheDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Cache["userInfoList"] == null)
            {
                BLL.UserInfoService userInfoService = new BLL.UserInfoService();
                List<Model.UserInfo> list = userInfoService.GetList();
                Cache["userInfoList"] = list;
                Cache.Insert("userInfoList", list, null, DateTime.Now.AddSeconds(5), TimeSpan.Zero,CacheItemPriority.Normal, RemoveCache);
                // Cache.Remove("userInfoList");
                Response.Write("来自数据库");
            }
            else
            {
                List<Model.UserInfo> list = (List<Model.UserInfo>)Cache["userInfoList"];
                Response.Write("来自缓存");
            }
        }
        protected void RemoveCache(string key ,object value,CacheItemRemovedReason reason)
        {
            if (reason == CacheItemRemovedReason.Expired)
            {
                //缓存移除的原因写道日记中
            }
        }
    }
}
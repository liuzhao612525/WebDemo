using FY.WebDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FY.WebDemo.Common;

namespace FY.WebDemo.WebApp._2019_5_23Cookie
{
    public partial class UserInfoList : CheckSession
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("欢迎" + ((UserInfo)Session["UserInfo"]).UserName + "登录本系统");
        }
    }
}
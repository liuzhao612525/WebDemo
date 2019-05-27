using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FY.WebDemo.Model;
using FY.WebDemo.BLL;

namespace FY.WebDemo.WebApp._2019_5_23Webform
{
    public partial class AddUserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                for (int i = 0; i < 100; i++)
                {
                    UserInfo userInfo = new UserInfo();
                    string name = Guid.NewGuid().ToString();
                    userInfo.UserName = name.Substring(0 ,5);
                    userInfo.Password = new Random().Next(10000 , 99999).ToString();
                    userInfo.Email = userInfo.UserName + "@126.com";
                    userInfo.RegTime = DateTime.Now;
                    UserInfoService userInfoService = new UserInfoService();
                    userInfoService.AddUserInfo(userInfo);
                }


                //UserInfo userInfo = new UserInfo();
                //userInfo.UserName = Request.Form["txtName"];
                //userInfo.Password = Request.Form["txtPwd"];
                //userInfo.Email = Request.Form["txtMail"];
                //userInfo.RegTime = DateTime.Now;
                //UserInfoService userInfoService = new UserInfoService();
                //if (userInfoService.AddUserInfo(userInfo))
                //{
                //    Response.Redirect("UserInfoList.aspx");
                //}else{
                //    Response.Redirect("/Error.html");
                //}
            }
        }
    }
}
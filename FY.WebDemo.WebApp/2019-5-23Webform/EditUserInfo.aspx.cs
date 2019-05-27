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
    public partial class EditUserInfo : System.Web.UI.Page
    {
        public UserInfo userInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowEditInfo();

            }
            else
            {
                UpdateUserInfo();
            }
        }
        protected void UpdateUserInfo()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Id = Convert.ToInt32(Request.Form["txtId"]);
            userInfo.UserName = Request.Form["txtName"];
            userInfo.Password = Request.Form["txtPwd"];
            userInfo.Email = Request.Form["txtMail"];
            userInfo.RegTime = Convert.ToDateTime(Request.Form["txtRegTime"]);
            BLL.UserInfoService userInfoService = new BLL.UserInfoService();
            if (userInfoService.EditUserInfo(userInfo))
            {
                Response.Redirect("UserInfoList.aspx");
            }
            else
            {
                Response.Redirect("/Error.html");
            }
        }

        protected void ShowEditInfo()
        {
            int id;
            if (int.TryParse(Request.QueryString["id"], out id))
            {
                BLL.UserInfoService userInfoService = new BLL.UserInfoService();
                UserInfo user = userInfoService.GetUserInfo(id);
                if (user != null)
                {
                    userInfo = user;
                }
                else
                {
                    Response.Redirect("/Error.html");
                }
            }
            else
            {
                Response.Redirect("/Error.html");
            }
        }
    }
    
}
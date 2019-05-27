using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FY.WebDemo.Model;
using FY.WebDemo.BLL;

namespace FY.WebDemo.WebApp._2019_5_23Cookie
{
    public partial class Login : System.Web.UI.Page
    {
        public string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (CheckValidateCode())
                {
                    CheckUserInfo();
                }
                else
                {
                    Msg = "验证码错误";
                }
            }
            else
            {
                if (Session["UserInfo"] != null)
                {
                    CheckCookieInfo();
                }
            }
        }

        protected void CheckUserInfo()
        {
            string name = Request.Form["txtName"];
            string pwd = Request.Form["txtPwd"];
            UserInfoService userInfoService = new UserInfoService();
            UserInfo userInfo = new UserInfo();
            string msg = string.Empty;
            bool isSuc= userInfoService.ValidateUserInfo(name ,pwd ,out msg ,out userInfo);
            if (isSuc)
            {
                Session["UserInfo"] = userInfo;
                Response.Redirect("UserInfoList.aspx");
            }
            else
            {
                Msg = msg;
                //Response.Redirect("/Error.html");
            }

        }
        protected bool CheckValidateCode()
        {
            bool isSuccess = false;
            if (Session["ValidateCode"] != null)
            {
                string txtCode = Request.Form["txtCode"];
                string sysCode = Session["ValidateCode"].ToString();
                if (sysCode.Equals(txtCode ,StringComparison.InvariantCultureIgnoreCase))
                {
                    isSuccess = true;
                    Session["ValidateCode"] = null;
                }
            }
            return isSuccess;
        }

        protected void CheckCookieInfo()
        {
            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                string name = Request.Cookies["cp1"].Value;
                string pwd = Request.Cookies["cp2"].Value;
                UserInfoService userInfoService = new UserInfoService();
                UserInfo userInfo = userInfoService.GetUserInfo(name);
                if (userInfo != null)
                {
                    if (pwd == userInfo.Password)
                    {
                        Session["UserInfo"] = userInfo;
                        Response.Redirect("UserInfoList.aspx");
                    }
                }

                Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
            }
        }
    }
}
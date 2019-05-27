using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FY.WebDemo.Model;
using FY.WebDemo.BLL;
using System.Text;

namespace FY.WebDemo.WebApp._2019_5_23Webform
{
    public partial class UserInfoList : System.Web.UI.Page
    {
        public string strHtml { get; set; }
        public List<UserInfo> userList { get; set; }
        /// <summary>
        /// 页面加载完自动触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfoService userInfoService = new UserInfoService();
            userList = userInfoService.GetList();

            //
            this.GridView1.DataSource = userList;
            this.GridView1.DataBind();
            //List<UserInfo> list= userInfoService.GetList();
            //StringBuilder sb = new StringBuilder();
            //foreach (UserInfo userInfo in list)
            //{
            //    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>", userInfo.Id, userInfo.UserName, userInfo.Password, userInfo.Email, userInfo.RegTime.ToShortDateString());
            //}
            //strHtml = sb.ToString();
        }
    }
}
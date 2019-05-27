using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FY.WebDemo.Common
{
   public class CheckSession:System.Web.UI.Page
    {
       //Init事件：aspx初始化时触发.
       public void Page_Init(object sender, EventArgs e)
       {
           if (Session["UserInfo"] == null)
           {
               Response.Redirect("Login.aspx");
           }
       }
    }
}

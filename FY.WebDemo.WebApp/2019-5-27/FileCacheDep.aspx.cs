using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FY.WebDemo.WebApp._2019_5_27
{
    public partial class FileCacheDep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = Request.MapPath("file.txt");
            if (Cache["fileContent"] == null)
            {
                CacheDependency cDep = new CacheDependency(filePath);
                string fileContent = File.ReadAllText(filePath);
                Cache.Insert("fileContent", fileContent, cDep);

                Response.Write("数据来自文件");
            }
            else
            {
                Response.Write("数据来自缓存" + Cache["fileContent"].ToString());
            }
        }
    }
}
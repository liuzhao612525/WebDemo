using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_23_file_upload
{
    /// <summary>
    /// ProcessFileUpload 的摘要说明
    /// </summary>
    public class ProcessFileUpload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            HttpPostedFile file = context.Request.Files[0];
            if (file.ContentLength>0)
            {
                string filename = Path.GetFileName(file.FileName);
                string fileExt = Path.GetExtension(filename);
                if (fileExt.ToLower() == ".jpg")
                {
                    string newfilename = Guid.NewGuid().ToString();
                    string dir = "/ImageUpload/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
                    if (!Directory.Exists(context.Request.MapPath(dir)))
                    {
                        Directory.CreateDirectory(context.Request.MapPath(dir));
                    }
                    string fullDir = dir + newfilename + fileExt;
                    file.SaveAs(context.Request.MapPath(fullDir));
                    context.Response.Write("<html><body><img src='" + fullDir + "'/></body></html>");

                }
                else
                {
                    context.Response.Write("只能上传图片文件");
                }
            }
            context.Response.Write("Hello World");
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
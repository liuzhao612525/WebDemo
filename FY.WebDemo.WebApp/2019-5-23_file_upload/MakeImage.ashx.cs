using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace FY.WebDemo.WebApp._2019_5_23_file_upload
{
    /// <summary>
    /// MakeImage 的摘要说明
    /// </summary>
    public class MakeImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //创建画布
            using (Bitmap map = new Bitmap(300, 400))
            {
                //给画布创建画笔
                using (Graphics g = Graphics.FromImage(map))
                {
                    g.Clear(Color.Green);
                    g.DrawString("这是一个水印", new Font("黑体", 14.0f, FontStyle.Bold), Brushes.Red, new PointF(150, 200));
                    string fileName = Guid.NewGuid().ToString();
                    map.Save(context.Request.MapPath("/ImageUpload/" + fileName + ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                    context.Response.Write("<html><body><img src='/ImageUpload/" + fileName + ".jpg'/></body></html>");
                    


                    //g.Clear(Color.Gray);
                    ////再画布上写字。

                    ////1:写的是什么字
                    ////2：字体的样式，字体大小等。
                    ////3:用什么颜色填充字体
                    ////4:在画布的什么位置写字
                    //g.DrawString("传智播客", new Font("黑体", 14.0f, FontStyle.Bold), Brushes.Red, new PointF(150, 200));

                    ////将画布保存成一张图片.
                    //string fileName = Guid.NewGuid().ToString();
                    ////将画布保存成一张图片，并且指定图片的类型
                    //map.Save(context.Request.MapPath("/ImageUpload/" + fileName + ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                    //context.Response.Write("<html><body><img src='/ImageUpload/" + fileName + ".jpg'/></body></html>");
                }
            }
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using FY.WebDemo.Common;

namespace FY.WebDemo.WebApp._2019_5_23Cookie
{
    /// <summary>
    /// ValidateCode 的摘要说明
    /// </summary>
    public class ValidateImageCode : IHttpHandler ,IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            ValidateCode validateCode = new ValidateCode();
            string code = validateCode.CreateValidateCode(4);
            context.Session["ValidateCode"] = code;
            validateCode.CreateValidateGraphic(code, context);
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
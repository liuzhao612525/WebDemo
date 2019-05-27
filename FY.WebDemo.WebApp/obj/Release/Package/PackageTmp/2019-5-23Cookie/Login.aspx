<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_23Cookie.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        window.onload = function () {
            var validatecode = document.getElementById("validatecode");
            validatecode.onclick = function () {
                document.getElementById("imgcode").src = "ValidateImageCode.ashx?id=" + new Date().getMilliseconds();
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<input type="text" name="txtName" value="" /><br />
            密码：<input type="password" name="txtPwd" value="" /><br />
            验证码：<input type="text" name="txtCode" value="" /><img src="ValidateImageCode.ashx" id="imgcode" /><a href="javascript:void(0)" id="validatecode">看不清</a><br />
            <input type="submit"  value="登录" /><span style="font-size:14px;color:red"><%=Msg %></span>
        </div>
    </form>
</body>
</html>

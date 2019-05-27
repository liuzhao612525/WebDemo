<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_24.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#msg").css("display", "none");

            $("#txtName").blur(function () {
                var userName = $(this).val();
                if (userName != "") {
                    $.post("CheckUserName.ashx", { "userName": userName }, function (data) {
                        $("#msg").css("display", "block");
                        $("#msg").text(data);
                    });
                } else {
                    alert("用户名不能为空");
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" name="txtName" value="" id="txtName" /><span style="font-size:14px;color:red;" id="msg"></span><br />
            <input type="text" name="txtPwd" value="" /><br />
            <input type="submit" name="submit" value="注册" />
        </div>
    </form>
</body>
</html>

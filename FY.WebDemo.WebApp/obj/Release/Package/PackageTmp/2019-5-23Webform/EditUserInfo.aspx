
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUserInfo.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_23Webform.EditUserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名:<input type="text" name="txtName" value="<%=userInfo.UserName %>""/><br/>
        密码:<input type="password" name="txtPwd" value="<%=userInfo.Password %>""/><br/>
        邮箱:<input type="text" name="txtMail" value="<%=userInfo.Email %>""/><br/>
            <input type="hidden" name="txtId" value="<%=userInfo.Id %>"" />
            <input type="hidden" name="txtRegTime" value="<%=userInfo.RegTime %>"" />
            <input type="submit" name="name" value="编辑用户" />
        </div>
    </form>
</body>
</html>

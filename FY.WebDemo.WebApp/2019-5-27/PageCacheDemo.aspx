<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageCacheDemo.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_27.PageCacheDemo" %>
<%@ OutputCache Duration="5" VaryByParam="*" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="ShowDetail.aspx?id=1314">用户详细信息</a>
            <a href="ShowDetail.aspx?id=1315">用户详细信息</a>
        </div>
    </form>
</body>
</html>

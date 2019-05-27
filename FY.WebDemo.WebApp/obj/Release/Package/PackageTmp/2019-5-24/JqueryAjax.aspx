<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JqueryAjax.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_24.JqueryAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btn").click(function () {
                $.get("GetDate.ashx", { "name": "lisi", "pwd": "123" }, function (data) {
                    alert(data);
                });
            });
            $("#btn").click(function () {
                $.post("GetDate.ashx", { "name": "lisi", "pwd": "123" }, function (data) {
                    alert(data);
                })
            });
            $("#btn").click(function () {
                $.ajax({
                    type: "post",
                    url: "GetDate.ashx",
                    data: "name=wangwu&pwd=1212",
                    success: function (msg) {
                        alert(msg);
                    }
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <input type="button" name="name" value="get获取数据"  id="btn"/>
        </div>
    </form>
</body>
</html>

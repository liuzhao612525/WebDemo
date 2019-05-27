<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxPostDemo.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_24.AjaxPostDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btn").click(function () {
                var xhr = XMLHttpRequest;
                xhr.open("post", "GetDate.ashx");
                xhr.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
                xhr.send("name=zhangsan&pwd=1123");
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == 4) {
                        if (xhr.state == 200) {
                            alert(xhr.responseText);
                        }
                    }
                }
            });

        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" name="name" value="获取数据" id="btn" />
        </div>
    </form>
</body>
</html>

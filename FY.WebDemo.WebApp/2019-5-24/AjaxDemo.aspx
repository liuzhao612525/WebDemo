<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxDemo.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_24.AjaxDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btn").click(function () {
                var xhr;
                if (XMLHttpRequest) {//表示用户使用的高版本IE，谷歌，狐火等浏览器
                    xhr = new XMLHttpRequest();
                } else {// 低IE
                   xhr=new ActiveXObject("Microsoft.XMLHTTP");
                }
                xhr.open("get", "GetDate.ashx?name=zhangsan&age=12", true);
                xhr.send();
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == 4) {
                        if (xhr.status == 200) {
                            alert(xhr.responseText);
                        }
                    }
                }
            });
        });

        //$(function () {
        //    $("#btn").click(function () {
        //        //开始通过AJAX向服务器发送请求.
        //        var xhr;
        //        if (XMLHttpRequest) {//表示用户使用的高版本IE，谷歌，狐火等浏览器
        //            xhr = new XMLHttpRequest();
        //        } else {// 低IE
        //           xhr=new ActiveXObject("Microsoft.XMLHTTP");
        //        }
        //        xhr.open("get", "GetDate.ashx?name=zhangsan&age=12", true);
        //        xhr.send();//开始发送
        //        //回调函数:当服务器将数据返回给浏览器后，自动调用该方法。
        //        xhr.onreadystatechange = function () {
        //            if (xhr.readyState == 4) {//表示服务端已经将数据完整返回，并且浏览器全部接受完毕。
        //                if (xhr.status == 200) {//判断响应状态码是否为200.

        //                    alert(xhr.responseText);

        //                }
        //            }
        //        }
        //    });
        //});
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" name="name" value="获取服务端时间" id="btn" />
        </div>
    </form>
</body>
</html>

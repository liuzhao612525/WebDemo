<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoList.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_23Webform.UserInfoList" %>

<!DOCTYPE html>
<%@ Import Namespace="FY.WebDemo.Model" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Css/tableStyle.css" rel="stylesheet" />
    <script type="text/javascript">
        window.onload = function () {
            var datas = document.getElementsByClassName("delete");
            var datalength = datas.length;
            for (var i = 0; i < datalength; i++) {
                datas[i].onclick = function () {
                    if (!confirm("确定删除？")) {
                        return false;
                    }
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="AddUserInfo.aspx">添加用户</a>
            <table>
                <tr>
                    <tr><th>编号</th><th>用户名</th><th>密码</th><th>邮箱</th><th>时间</th><th>详情</th><th>编辑</th><th>删除</th></tr>
                    <%--<% =strHtml %>--%>
                    <% foreach(UserInfo userInfo in userList){%>
                            <tr>
                                <td><%=userInfo.Id %></td>
                                <td><%=userInfo.UserName %></td>
                                <td><%=userInfo.Password %></td>
                                <td><%=userInfo.Email %></td>
                                <td><%=userInfo.RegTime %></td>
                                <td><a href="#">详情</a></td>
                                <td><a href="EditUserInfo.aspx?id=<%=userInfo.Id %>">编辑</a></td>
                                <td><a href="Delete.ashx?id=<%=userInfo.Id %>" class="delete">删除</a></td>
                            </tr>
                        <%} %>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>

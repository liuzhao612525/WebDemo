<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterDemo.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_27.RepeaterDemo" EnableViewState="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <%--<link href="../Css/tableStyle.css" rel="stylesheet" />--%>
    <style type="text/css">
        .auto-style1 {
            width: 456px;
        }
        .auto-style2 {
            width: 64px;
        }
        .auto-style3 {
            width: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr><th class="auto-style2">编号</th><th class="auto-style2">用户名</th><th class="auto-style2">密码</th><th class="auto-style2">邮箱</th><th class="auto-style2">时间</th><th class="auto-style3">详情</th><th class="auto-style3">编辑</th><th class="auto-style3">删除</th></tr>

                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("Id") %></td>
                            <td><%#Eval("UserName") %></td>
                            <td><%#Eval("Password") %></td>
                            <td><%#Eval("Email") %></td>
                            <td><%#Eval("RegTime") %></td>
                            <td>
                                <asp:Button ID="ButtonDetail" runat="server" Text="详情" />
                            </td>
                            <td>
                                <asp:Button ID="ButtonEdit" runat="server" Text="编辑" />
                            </td>
                            <td>
                                <asp:Button ID="ButtonDelete" runat="server" Text="删除" />
                            </td>

                        </tr>
                    </ItemTemplate>
                    <AlternatingItemTemplate>

                        <tr style="background-color:aqua">
                            <td><%#Eval("Id") %></td>
                            <td><%#Eval("UserName") %></td>
                            <td><%#Eval("Password") %></td>
                            <td><%#Eval("Email") %></td>
                            <td><%#Eval("RegTime") %></td>
                            <td>详情</td>
                            <td>编辑</td>
                            <td>删除</td>

                        </tr>
                    </AlternatingItemTemplate>

                    <SeparatorTemplate>
                        <tr>
                            <td colspan="8"></td>
                        </tr>
                    </SeparatorTemplate>

                    <FooterTemplate>
                        <tr>
                            <td colspan="8"></td>
                        </tr>
                    </FooterTemplate>

                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FY.WebDemo.WebApp._2019_5_27.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:label runat="server" text="Label"  AssociatedControlID="TextBox1">aaaa</asp:label>
            <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Email" >bbbb</asp:TextBox>
            hgfhfg

            </div>
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" text="fadfsf"/>
        </div>
        
        <div>
           男 <asp:RadioButton ID="RadioButton1" runat="server" GroupName="sex"/>
            女<asp:RadioButton ID="RadioButton2" runat="server" GroupName="sex" />
        </div>

        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="UserName" DataValueField="Id">
            <asp:ListItem Value="0">北京</asp:ListItem>
            <asp:ListItem Value="1">和恶</asp:ListItem>
            <asp:ListItem Value="2">ffsafdas</asp:ListItem>
        </asp:DropDownList>

            <asp:GridView ID="GridView1" runat="server" Width="656px" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                    <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                    <asp:BoundField DataField="RegTime" HeaderText="RegTime" SortExpression="RegTime" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <p>
            &nbsp;</p>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetList" TypeName="FY.WebDemo.BLL.UserInfoService"></asp:ObjectDataSource>

    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>

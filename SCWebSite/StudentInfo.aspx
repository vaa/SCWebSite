<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentInfo.aspx.cs" Inherits="StudentInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>学生个人信息管理</title>
    <style type="text/css">
        .auto-style1
        {
            width: 800px;
            height: 200px;
        }
        .auto-style2
        {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <a href="MainPage.aspx">主页</a>
    <div style="margin:0px auto; width:1076px">
    
        <table style="width:112%; height: 241px;">
            <tr>
                <td style="text-align:left">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="学生个人信息管理"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:center">
                    <asp:Label ID="Label1" runat="server" Text="查询："></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>按姓名查询</asp:ListItem>
                        <asp:ListItem>按学号查询</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtChaxun" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:Button ID="btnOK" runat="server" Text="查  询" OnClick="btnOK_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server"  style="margin-left: 48px" 
                        AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" 
                        DataKeyNames="Sno" GridLines="None" 
                        OnPageIndexChanging="GridView1_PageIndexChanging" 
                        OnRowCreated="GridView1_RowCreated" OnRowDeleting="GridView1_RowDeleting" 
                        OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="5" 
                        ForeColor="#333333" Width="1053px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Sno" HeaderText="学号" />
                            <asp:BoundField DataField="Sname" HeaderText="姓名" />
                            <asp:BoundField DataField="Ssex" HeaderText="性别" />
                            <asp:BoundField DataField="Sage" HeaderText="年龄" />
                            <asp:BoundField DataField="Sclass" HeaderText="班级" />
                            <asp:BoundField DataField="Sdepartment" HeaderText="学院" />
                            <asp:BoundField DataField="Sphone" HeaderText="手机号" />
                            <asp:BoundField DataField="Saddress" HeaderText="地址" />
                            <asp:BoundField DataField="Spassword" HeaderText="密码" />
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
            </tr>
            </table>
    
    </div>
    <p><b><a href="AddStudent.aspx">添加新学生</a></b></p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentGrade.aspx.cs" Inherits="StudentGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>学生成绩管理</title>
</head>
<body>
    <form id="form1" runat="server">
    <a href="MainPage.aspx">主页</a>
     <div style="margin:0px auto; width:890px">
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="微软雅黑" Text="学生成绩管理"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align:center">
                    <asp:Label ID="Label2" runat="server" Text="查询："></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>按学号查询</asp:ListItem>
                        <asp:ListItem>按班级查询</asp:ListItem>
                        <asp:ListItem>查询全部</asp:ListItem>
                    </asp:DropDownList>
&nbsp;<asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查  询" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5" Width="881px" DataKeyNames='Cno,Sno' OnPageIndexChanging="GridView1_PageIndexChanging1" OnRowCreated="GridView1_RowCreated" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Cno" HeaderText="课程号" />
                            <asp:BoundField DataField="Cname" HeaderText="课程名" />
                            <asp:BoundField DataField="Sclass" HeaderText="班级" />
                            <asp:BoundField DataField="Sno" HeaderText="学号" />
                            <asp:BoundField DataField="Sname" HeaderText="名字" />
                            <asp:BoundField DataField="Grade" HeaderText="成绩" />
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
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

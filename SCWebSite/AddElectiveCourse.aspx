<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddElectiveCourse.aspx.cs" Inherits="AddElectiveCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>已开设的课程详情</title>
    <style type="text/css">
        .auto-style1
        {
            height: 23px;
        }
        .style1
        {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <a href="MainPage.aspx">主页</a>
    <div style="margin:0px auto; width:807px">
    
        <table style="width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="微软雅黑" Font-Size="Medium" Text="已开设的课程详情"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" ForeColor="#333333" GridLines="None" Width="883px" 
                        AllowPaging="True" DataKeyNames='Cno,Tno' OnRowCreated="GridView1_RowCreated" 
                        PageSize="4" OnPageIndexChanging="GridView1_PageIndexChanging" 
                        OnRowDeleting="GridView1_RowDeleting">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Cno" HeaderText="课程编号" />
                            <asp:BoundField DataField="Cname" HeaderText="课程名称" />
                            <asp:BoundField DataField="Tno" HeaderText="老师编号" />
                            <asp:BoundField DataField="Tname" HeaderText="任课老师" />
                            <asp:BoundField DataField="time" HeaderText="上课时间" />
                            <asp:BoundField DataField="place" HeaderText="课程地点" />
                            <asp:BoundField DataField="Ccredit" HeaderText="课程学分" />
                            <asp:BoundField DataField="Ctype" HeaderText="课程归属" />
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
                <td colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="微软雅黑" Font-Size="Medium" Text="课程添加"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label2" runat="server" Text="课程编号："></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCno" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label3" runat="server" Text="教师编号："></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTno" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right" class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="上课时间："></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td style="text-align:right" class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Text="上课地点："></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPlace" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td style="text-align:right">
                    &nbsp;</td>
                <td style="text-align:right">
                    <asp:Button ID="btnOK" runat="server" Font-Names="微软雅黑" Text="确认添加" OnClick="btnOK_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right" class="style1">
                    </td>
                <td class="style1"></td>
                <td class="style1"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

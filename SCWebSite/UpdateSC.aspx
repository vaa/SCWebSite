<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateSC.aspx.cs" Inherits="UpdateSC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>学生成绩更新</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:0px auto; width:807px">
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="微软雅黑" Text="学生成绩更新"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label2" runat="server" Text="课程号："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCno" runat="server" BackColor="#FEB05A" ReadOnly="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label3" runat="server" Text="课程名："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCname" runat="server" BackColor="#FEB05A" ReadOnly="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label4" runat="server" Text="学号："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSno" runat="server" BackColor="#FEB05A" ReadOnly="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label5" runat="server" Text="成绩："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtGrade" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:center" colspan="3">
                    <asp:Button ID="btnUpdate" runat="server" Text="修改" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;
                    <asp:Button ID="btnCancel" runat="server" Text="返回" onclick="btnCancel_Click" />
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

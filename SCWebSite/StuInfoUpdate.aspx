<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StuInfoUpdate.aspx.cs" Inherits="StuInfoUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>学生信息修改</title>
    <style type="text/css">
        .style1
        {
            height: 22px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0px auto; width:807px">
    
        <table style="width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="学生信息修改"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right" class="style1">
                    <asp:Label ID="Label2" runat="server" Text="学号："></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtSno" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="style1"></td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label3" runat="server" Text="用户名："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label4" runat="server" Text="密码："></asp:Label>
                </td>
                <td >
                    <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label5" runat="server" Text="请再次输入密码："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPwdConfirm" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtPwdConfirm" ErrorMessage="CompareValidator" Font-Bold="True" Font-Size="Small" ForeColor="Red">*密码输入不一致！</asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label6" runat="server" Text="性别："></asp:Label>
                </td>
                <td>
                    <asp:RadioButton ID="rbMale" runat="server" Checked="True" GroupName="Sex" Text="男" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rbFemale" runat="server" Text="女" GroupName="Sex" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label7" runat="server" Text="年龄:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSage" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label8" runat="server" Text="班级:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlSclass" runat="server">
                        <asp:ListItem>软件1501</asp:ListItem>
                        <asp:ListItem>软件1502</asp:ListItem>
                        <asp:ListItem>通信1501</asp:ListItem>
                        <asp:ListItem>通信1502</asp:ListItem>
                        <asp:ListItem>计算机1501</asp:ListItem>
                        <asp:ListItem>计算机1502</asp:ListItem>
                        <asp:ListItem>电信1501</asp:ListItem>
                        <asp:ListItem>电信1502</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
                <tr>
                <td style="text-align:right" class="style2">
                    <asp:Label ID="Label9" runat="server" Text="学院:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="ddSdepartment" runat="server">
                        <asp:ListItem>计算机学院</asp:ListItem>
                        <asp:ListItem>艺术学院</asp:ListItem>
                        <asp:ListItem>京江学院</asp:ListItem>
                        <asp:ListItem>医学院</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label10" runat="server" Text="手机号:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSphone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label11" runat="server" Text="地址:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSaddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    &nbsp;</td>
                <td>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Font-Bold="True" Font-Size="Medium" Text="保  存" OnClick="btnSave_Click" />
                &nbsp;
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" OnClick="Button1_Click" Text="返  回" />
                </td>
                <td>&nbsp;</td>
            </tr>
            </table>
    <div>
    
    </div>
            </div>
    </form>
</body>
</html>
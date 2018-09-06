<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddStudent.aspx.cs" Inherits="AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加新学生</title>
    <style type="text/css">
        .auto-style2
        {
            height: 14px;
        }
        .auto-style3
        {
            height: 28px;
        }
        .auto-style4
        {
            width: 1120px;
            height: 227px;
        }
        .style1
        {
            height: 24px;
        }
        .style2
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <a href="javascript:history.go(-1)">返回</a> 
        <div style="margin:0px auto; width:1125px">
        <table style="width:100%;">
            <tr>
                <td colspan="2">
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="添加新学生" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label2" runat="server" Text="学号:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSno" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRSno" ErrorMessage="*学号不能为空！" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label3" runat="server" Text="姓名:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtRSname" ErrorMessage="*姓名不能为空！" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label4" runat="server" Text="密码:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSpwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label5" runat="server" Text="确认密码:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSpwdConfirm" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtRSpwd" ControlToValidate="txtRSpwdConfirm" ErrorMessage="*密码输入不一致!" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right" class="style1">
                    <asp:Label ID="Label6" runat="server" Text="性别:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:RadioButton ID="rdbMale" runat="server" Checked="True" Text="男" GroupName="Sex" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbFemale" runat="server" Text="女" GroupName="Sex" />
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label7" runat="server" Text="年龄:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSage" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="txtRSphone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label11" runat="server" Text="地址:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSaddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    &nbsp;</td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Button ID="btnRegister" runat="server" Text="添   加" OnClick="btnRegister_Click" Font-Bold="True" Font-Size="Medium" />
                </td>
            </tr>
        </table>
            </div>
    </form>
</body>
</html>
<%@ Page Language="C#" MasterPageFile="~/Homemas1.master" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div align=center>
<table>
<tr><td><asp:Label ID="lblUserName" runat="server" Text="UserName" Font-Bold="True" Font-Names="Palatino Linotype" Width="87px"></asp:Label></td>
<td><asp:TextBox ID="txtUserName" runat="server" Font-Bold="True" Font-Names="Palatino Linotype" Width="150px"></asp:TextBox></td>
<td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtUserName"></asp:RequiredFieldValidator></td></tr>
<tr><td><asp:Label ID="lblPassword" runat="server" Text="PassWord" Font-Bold="True" Font-Names="Palatino Linotype" Width="83px"></asp:Label></td>
<td><asp:TextBox ID="txtPassword" runat="server" Font-Bold="True" Font-Names="Palatino Linotype" TextMode="Password" Width="150px"></asp:TextBox></td>
<td> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtPassword"></asp:RequiredFieldValidator></td></tr>
<tr><td colspan="2" align="center"><asp:Button ID="btnSubmit" runat="Server" Text="Submit" Font-Bold="True" Font-Names="Palatino Linotype" Width="75px" OnClick="btnSubmit_Click" /></td></tr></table>
 <table>
    <tr>
    <td>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ownerreg.aspx">New User?</asp:HyperLink>
    </td>
    </tr>
    </table>
   </div>
</asp:Content>


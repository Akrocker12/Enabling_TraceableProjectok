<%@ Page Language="C#" MasterPageFile="~/Homemas1.master" AutoEventWireup="true" CodeFile="Dataowner.aspx.cs" Inherits="hodlogin" Title="Untitled Page" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div align=center>
    <asp:Label ID="Label1" runat="server" Text="Login" Font-Bold="True"></asp:Label>
    <br />
    <tr align=center>
    <td>
    <table cellpadding="2" cellspacing="3">
    <tr>
    <td class="style2">
        <span class="style1">User Name :</span>
    </td>
    <td>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td class="style2">
        <span class="style1">Password :</span>
    </td>
    <td>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    </td>
    </tr>
    </table>
    <table>
    <tr>
    <td>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="32px" 
            ImageUrl="~/images/login.jpg" Width="111px" onclick="ImageButton1_Click" />
    </td>
    <td>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="32px" 
            ImageUrl="~/burcancel.jpg" Width="111px" onclick="ImageButton2_Click" />
    </td>
    </tr>
    </table>
    
    </td>
    </tr>
    <table>
    <tr>
    <td>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ownerreg.aspx">New User?</asp:HyperLink>
    </td>
    </tr>
    </table>
    </div>
</asp:Content>


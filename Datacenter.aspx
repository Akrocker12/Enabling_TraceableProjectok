﻿<%@ Page Language="C#" MasterPageFile="~/Homemas1.master" AutoEventWireup="true" CodeFile="Datacenter.aspx.cs" Inherits="studentlogin" Title="Untitled Page" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div align=center>
    <br />
    <asp:Label ID="Label1" runat="server" Text="KGC Login" Font-Bold="True"></asp:Label>
    <br />
    <tr align=center>
    <td>
    <table cellpadding="2" cellspacing="4">
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
            ImageUrl="~/burcancel.jpg" Width="111px" />
    </td>
    </tr>
    </table>
     <table>
    <tr>
    <td>
        
    </td>
 
    </tr>
    </table>
    </td>
    </tr>
    </div>
</asp:Content>


<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" EnableEventValidation="false" CodeFile="Viewpage.aspx.cs" Inherits="Viewpage" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
  <table>
 <tr>
 <td>
     <asp:Label ID="Label10" runat="server" Text="File Request" Font-Bold="True" 
         ForeColor="Red"></asp:Label>
 </td>
 </tr>
  </table>
 <table cellpadding="5" cellspacing="5">
 <tr>
 <td>
     <asp:Label ID="Label3" runat="server" Text="File ID"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
 </td>
 </tr>
 <tr>
 <td>
     <asp:Label ID="Label5" runat="server" Text="File Name"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
 </td>
 </tr>
 <tr>
 <td>
     <asp:Label ID="Label2" runat="server" Text="Data Owner"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
 </td>
 </tr>
 </table>
 
 
 <table>
 <tr>
 <td>
     <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
 </td>
 </tr>
 </table>
 
 


</div>

</asp:Content>


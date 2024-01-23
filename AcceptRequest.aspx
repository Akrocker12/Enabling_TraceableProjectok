<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AcceptRequest.aspx.cs" Inherits="AcceptRequest" Title="Untitled Page" %>
<%@ Register assembly="DatePicker" namespace="DatePicker" tagprefix="SQ" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script src="Javascript/prototype.js" type="text/javascript"></script>
    <script src="Javascript/calendarview.js" type="text/javascript"></script>
    <link href="Javascript/calendarview.css" rel="stylesheet" type="text/css" />
    <div align=center>
 <div align=center>
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
  <table>
 <tr>
 <td>
     <asp:Label ID="Label10" runat="server" Text="Accept Request" Font-Bold="True" 
         ForeColor="Red"></asp:Label>
 </td>
 </tr>
  </table>
 <table cellpadding="6" cellspacing="6">
 <tr>
 <td>
     <asp:Label ID="Label3" runat="server" Text="Sno"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
 </td>
 </tr>
 <tr>
 <td>
     <asp:Label ID="Label5" runat="server" Text="File id" style="text-align: right"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
 </td>
 </tr>
 <tr>
 <td>
     <asp:Label ID="Label2" runat="server" Text="File Name"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
 </td>
 </tr>
 <tr>
 <td>
     <asp:Label ID="Label4" runat="server" Text="Data Owner"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
 </td>
 </tr>
 <tr>
 <td>
     <asp:Label ID="Label6" runat="server" Text="User Name"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
 </td>
 </tr>
  <tr>
 <td>
     <asp:Label ID="Label7" runat="server" Text="Reqeust Date"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
 </td>
 </tr>
  <tr>
 <td>
     <asp:Label ID="Label8" runat="server" Text="Status"></asp:Label>
 </td>
 <td>
     <asp:DropDownList ID="DropDownList1" runat="server" Width="126px">
         <asp:ListItem>Request</asp:ListItem>
         <asp:ListItem>Accepted</asp:ListItem>
     </asp:DropDownList>
 </td>
 </tr>
 <tr>
 <td>
     <asp:Label ID="Label9" runat="server" Text="Accessing Date"></asp:Label>
 </td>
 <td>
     <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
   <ajaxtoolkit:calendarextender ID="defaultCalendarExtender" runat="server" Format="MM-dd-yyyy" 
                    TargetControlID="TextBox7" />
     <asp:ScriptManager ID="ScriptManager1" runat="server">
     </asp:ScriptManager>
    
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
    </div>
</asp:Content>


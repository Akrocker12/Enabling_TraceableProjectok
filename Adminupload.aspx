<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Adminupload.aspx.cs" Inherits="Adminupload" Title="Untitled Page" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
   
<div align=center>
 <asp:Label ID="Label1" runat="server" Text="Upload Your Data" Font-Bold="True" 
        Font-Italic="True" ForeColor="#FF6600"></asp:Label>
        <br />

<center>

</center>
</td>
<td>
<table cellpadding="2" cellspacing="10">
<tr>
<td class="style1">
    <b>File Name :
</b>
</td>
<td style="text-align: left">
    <asp:FileUpload ID="FileUpload1" runat="server" Font-Bold="True" 
        Width="207px" />
</td>
</tr>
<tr>
<td class="style1">
    <b>Keyword :
</b>
</td>
<td style="text-align: left">
    <asp:TextBox ID="TextBox2" runat="server" Width="180px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="style2">
    Description :
</td>
<td style="text-align: left">
    <asp:TextBox ID="TextBox3" runat="server" Width="181px" Height="47px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="style4">
    <span class="style3">Content :</span>
</td>
<td style="text-align: left">
    <asp:TextBox ID="TextBox1" runat="server" Height="102px" TextMode="MultiLine" 
        Enabled="False" Width="267px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="style4">
    <span class="style5">File Key :</span>
</td>
<td style="text-align: left">
    <asp:TextBox ID="TextBox4" runat="server" Width="181px" Enabled="False"></asp:TextBox>
    &nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Text="Key" 
        onclick="Button4_Click" />
</td>

</tr>
</table>
<center>
<table>
<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Upload" Font-Bold="True" 
        onclick="Button1_Click" />
</td>
<td>
    <asp:Button ID="Button2" runat="server" Text="Cancel" Font-Bold="True" 
        Width="61px" onclick="Button2_Click" />
</td>
</tr>
</table>
</center>
</td>
</tr>
</table>
<table cellpadding="4" cellspacing="8">
<tr>
<td>
 <table>
 <tr>
 <td>
     &nbsp;</td>
 </tr>
 </table>   
</td>
<td>
<table>
 <tr>
 <td>
     <asp:GridView ID="GridView2" runat="server" BackColor="#990033" CellPadding="4" 
         ForeColor="#333333" GridLines="None" onrowdeleting="GridView2_RowDeleting">
         <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
         <Columns>
             <asp:CommandField ShowDeleteButton="True" />
         </Columns>
         <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
         <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
         <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <AlternatingRowStyle BackColor="White" />
     </asp:GridView>
 </td>
 </tr>
 </table>   
</td>
</tr>
</table>
</div>
</asp:Content>


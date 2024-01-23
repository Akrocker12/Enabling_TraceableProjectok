<%@ Page Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="blockuser.aspx.cs" Inherits="blockuser" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Block User Details"></asp:Label>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:GridView ID="GridView1" runat="server" CellPadding="3" BackColor="#DEBA84" 
         BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</td>
</tr>
</table>
</div>
</asp:Content>


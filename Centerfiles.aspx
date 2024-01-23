<%@ Page Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="Centerfiles.aspx.cs" Inherits="Centerfiles" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="File Details"></asp:Label>
</td>
</tr>
</table>
<table>
<tr>
<td colspan="10">

</td>
<td>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
</td>
</tr>
</table>
</div>
</asp:Content>


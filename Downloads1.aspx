<%@ Page Language="C#" MasterPageFile="~/Server.master" AutoEventWireup="true" CodeFile="Downloads1.aspx.cs" Inherits="Downloads1" Title="Untitled Page" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>

<table cellpadding="5" cellspacing="10">
<tr>
<td>
<table cellpadding="5" cellspacing="10" style="width: 120px">
<tr>
<td style="text-align: right">
    &nbsp;</td>
</tr>
<tr>
<td style="text-align: right">
    &nbsp;</td>
</tr>
<tr>
<td style="text-align: right">
    
    &nbsp;</td>
</tr>
</table>


</td>

<td>
<table>
<tr>
<td>

    <asp:Panel ID="Panel1" runat="server" ScrollBars="Both">
        <asp:GridView ID="GridView1" runat="server" Height="206px" Width="688px" 
            CellPadding="4" ForeColor="#333333" GridLines="None" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </asp:Panel>
     
    
</td>
</tr>
</table>
</td>
</tr>

</table>
</div>
</asp:Content>


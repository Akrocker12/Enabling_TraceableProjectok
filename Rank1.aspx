<%@ Page Language="C#" MasterPageFile="~/Server.master" AutoEventWireup="true" CodeFile="Rank1.aspx.cs" Inherits="Rank1" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div align=center>
<br />
    <span class="style1">File Download Rank</span>
<br />
<br />
<br />
<br />
<table>
<tr>
<td>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" Width="427px" AllowPaging="True" 
        onpageindexchanging="GridView1_PageIndexChanging">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
</td>
</tr>

</table>


</div>
</asp:Content>


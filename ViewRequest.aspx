<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ViewRequest.aspx.cs" Inherits="ViewRequest" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
<br />
    <span class="style1">File Request Details</span>
<br />
<br />
<br />
<table>
<tr>

<td>
    <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label>
</td>
<td>


<table>
<tr>
<td>
    <asp:Panel ID="Panel1" runat="server" Height="400px" ScrollBars="Both" 
        Width="800px">
        <asp:GridView ID="GridView1" runat="server" BackColor="White" 
            BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            onselectedindexchanging="GridView1_SelectedIndexChanging">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
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


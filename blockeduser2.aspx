<%@ Page Language="C#" MasterPageFile="~/Server.master" AutoEventWireup="true" CodeFile="blockeduser2.aspx.cs" Inherits="blockeduser2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
<table>
<tr>
<td>

    <asp:Label ID="Label6" runat="server" Text="Dataowner Details" 
        Font-Bold="True" Font-Size="Large"></asp:Label>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Width="820px">
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" BorderColor="#660066" 
            BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
            PageSize="8" onrowediting="GridView2_RowEditing" Width="818px" 
        onpageindexchanging="GridView2_PageIndexChanging" BackColor="White" 
            ForeColor="Black" GridLines="Vertical" 
            onselectedindexchanged="GridView2_SelectedIndexChanged">
            <FooterStyle BackColor="#CCCCCC" HorizontalAlign="Left" />
            <Columns>
                <asp:TemplateField HeaderText="username" SortExpression="username">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server"  Text='<%# Eval("username") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="logtime" SortExpression="logtime">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("logtime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="mode" SortExpression="mode">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("mode") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ipaddr" SortExpression="Ipaddr">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Ipaddr") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#660066" ForeColor="White" />
            <AlternatingRowStyle BackColor="#CCCCCC" BorderColor="#CC3300" 
                BorderStyle="Double" BorderWidth="2px" />
        </asp:GridView>
    </asp:Panel>
</td>
</tr>
</table>
<table>
<tr>
<td>
 <asp:Label ID="Label8" runat="server" ForeColor="Blue" 
            Text="Updated Successfully...!!!" Visible="False"></asp:Label>
       
</td>
<td>
 <asp:Button ID="Btnupdate" runat="server" Text="Update" 
            onclick="Btnupdate_Click" />
</td>
<td>

<asp:Label ID="Label9" runat="server" Visible="False"></asp:Label>
</td>
</tr>
</table>
</div>
</asp:Content>


<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Downloads.aspx.cs" Inherits="Downloads" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align=center>
      <b>&nbsp;&nbsp;&nbsp; &nbsp; 
        <asp:Label ID="Label1" runat="server" ForeColor="#660033"></asp:Label></b> 
        &nbsp;&nbsp;&nbsp;&nbsp;  
<br />
    <span class="style1">Your Request File</span>
<br />
<br />
<br />
 <table cellpadding="5" cellspacing="5">
   
   
    <tr>
   <td>
       <b>
           </b>
   </td>
   <td>
       <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
   </td>
   <td>
       
   </td>
   </tr>
    <tr>
   <td>
       <b>
           <asp:Label ID="Label3" runat="server" Text="File Key" Visible="False"></asp:Label></b>
   </td>
   <td>
       <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
   </td>
   <td>
       <asp:Button ID="Button1" runat="server" Text="Download" Font-Bold="True" 
           onclick="Button1_Click" Visible="False" Width="88px" />
   </td>
   </tr>
   </table>
   <table>
   <tr>
   <td>
       <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
   </td>
   </tr>
   </table>
<br /><br />
<table>
<tr>
<td>
    <asp:GridView ID="GridView1" runat="server" 
           CellPadding="4" ForeColor="#333333" GridLines="None" Height="373px" 
           onrowcommand="GridView1_RowCommand" onrowdatabound="GridView1_RowDataBound" 
           onselectedindexchanged="GridView1_SelectedIndexChanged" Width="327px" 
           onselectedindexchanging="GridView1_SelectedIndexChanging" 
           AllowPaging="True" onpageindexchanging="GridView1_PageIndexChanging" 
           PageSize="20" onrowediting="GridView1_RowEditing">
           <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
           <RowStyle BackColor="#EFF3FB" />
           <Columns>
               <asp:TemplateField ShowHeader="False">
                   <EditItemTemplate>
                       <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" 
                           CommandName="Update" Text="Update"></asp:LinkButton>
                       &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                           CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                           CommandName="Edit" Text="Select"></asp:LinkButton>
                   </ItemTemplate>
               </asp:TemplateField>
           </Columns>
           <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
           <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
           <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
           <EditRowStyle BackColor="#2461BF" />
           <AlternatingRowStyle BackColor="White" />
       </asp:GridView>
</td>
</tr>

</table>
<br />



</div>
</asp:Content>


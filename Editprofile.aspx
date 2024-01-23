<%@ Page Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="Editprofile.aspx.cs" Inherits="Editprofile" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
       
 
 <br />
 
<div align=center>
<b>Wecome&nbsp;&nbsp;&nbsp; :&nbsp; 
        <asp:Label ID="Label1" runat="server" ForeColor="#660033"></asp:Label></b> 
&nbsp;&nbsp;&nbsp; &nbsp; 
      
       
        <br />
        <br />
<br />
<br />
<span class="style2"><b>Update Your profile</b></span>
<br />
<table cellpadding="1" cellspacing="10">

<tr>
<td class="style1">
    <b>Full Name :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server" Width="197px"></asp:TextBox>
</td>
</tr>

<tr>
<td class="style1">
    <b>User Name :</b>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" Width="197px" Enabled="False"></asp:TextBox>
</td>
</tr>

<tr>
<td class="style1">
    <b>passpassword :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server" Width="197px"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Enter Your Pwd" 
        ControlToValidate="TextBox3" Font-Bold="True"></asp:RequiredFieldValidator>
</td>
</tr>

<tr>
<td class="style1">
    <b>Address :

</td>
<td>
    <asp:TextBox ID="TextBox4" runat="server" Height="68px" TextMode="MultiLine" 
        Width="197px"></asp:TextBox>
</td>
</tr>

<tr>
<td class="style1">
    <b>Mobile :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox5" runat="server" Height="22px" Width="197px"></asp:TextBox>
</td>
</tr>

<tr>
<td class="style1">
    <b>Email Id :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox6" runat="server" Width="197px"></asp:TextBox>
</td>
</tr>


</table>

<table cellpadding="2" cellspacing="10">
<tr>
<td>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="38px" 
        ImageUrl="~/images/update.jpg" Width="117px" 
        onclick="ImageButton1_Click" />
</td>
<td>
    <asp:ImageButton ID="ImageButton2" runat="server" Height="38px" 
        ImageUrl="~/burcancel.jpg" Width="117px" onclick="ImageButton2_Click" />
</td>
</tr>

</table>
<br />
<br />

</div>
</asp:Content>


<%@ Page Language="C#" MasterPageFile="~/Homemas1.master" AutoEventWireup="true" CodeFile="Ownerreg.aspx.cs" Inherits="Ownerreg" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <script type="text/javascript">
var r={'special':/[\W\a-zA-Z]/g}
function valid(o,w)
{
  o.value = o.value.replace(r[w],'');
}

var r1={'special':/[\W\0-9]/g}
function valid1(o,w)
{
  o.value = o.value.replace(r1[w],'');
}
</script> 
<div align=center>
<br />
 <span class="style2">Register Your Details</span>
 <br />
<table cellpadding="1" cellspacing="10">

<tr>
<td class="style1">
    <b>User Name :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox1" runat="server" Width="197px"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="*" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
</td>
</tr>

<tr>
<td class="style1">
    <b>Full Name :</b>
</td>
<td>
    <asp:TextBox ID="TextBox2" runat="server" Width="197px"  onkeyup="valid1(this,'special')"></asp:TextBox>
</td>
</tr>

<tr>
<td class="style1">
    <b>password :
</b>
</td>
<td>
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="197px" ></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ErrorMessage="*" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
</td>
</tr>

<tr>
<td class="style1">
    <b>Address :
</b>
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
    <asp:TextBox ID="TextBox5" runat="server" Height="22px" Width="197px" MaxLength="10" onkeyup="valid(this,'special')"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ErrorMessage="*" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
        
        <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "TextBox5" ID="RegularExpressionValidator3" ValidationExpression = "^[\s\S]{10,10}$" runat="server" ErrorMessage="Minimum 10 Numeric required."></asp:RegularExpressionValidator>
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
<td>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="Enter Valid Email" ControlToValidate="TextBox6" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="*" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
</td>
</tr>


</table>

<table cellpadding="2" cellspacing="10">
<tr>
<td>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="38px" 
        ImageUrl="~/bureg.jpg" Width="117px" onclick="ImageButton1_Click" />
</td>
<td>
    <asp:ImageButton ID="ImageButton2" runat="server" Height="38px" 
        ImageUrl="~/burcancel.jpg" Width="117px" />
</td>
</tr>

</table>
<br />
<br />

</div>

</asp:Content>


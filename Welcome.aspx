<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" Title="Untitled Page" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-color: lightblue">
    <form id="form1" runat="server">
    <div align=center>
    <table><tr><td colspan="4">
        
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/CloudComputing_header.jpg" /></td></tr>
        <tr><td align="center"><asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Pristina" Font-Size="X-Large" Font-Underline="True" ForeColor="#000040" NavigateUrl="~/SignIn.aspx">HOME</asp:HyperLink></td>
         <td align="center"><asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Pristina" Font-Size="X-Large" Font-Underline="True" ForeColor="#000040" NavigateUrl="~/SignIn.aspx">Edit Profile</asp:HyperLink></td>          
           <td align="center"><asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Pristina" Font-Size="X-Large" Font-Underline="True" ForeColor="#000040" NavigateUrl="~/SignIn.aspx">Download</asp:HyperLink></td>
            <td align="center"><asp:HyperLink ID="HyperLink5" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Pristina" Font-Size="X-Large" Font-Underline="True" ForeColor="#000040" NavigateUrl="~/SignIn.aspx">SignOut</asp:HyperLink></td></tr>
    <tr align="center"><td colspan="5">
        <br />
        <br />
        <br />
        <table><tr><td style="width: 110px">
    <br />
    <br />
    <asp:Label ID="lblWelcome" runat="Server" Text="WelCome" Font-Bold="True" Font-Italic="True" Font-Names="Palatino Linotype" Font-Size="X-Large"></asp:Label></td><td>
    <br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="lblUser" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Palatino Linotype" Font-Size="X-Large"></asp:Label></td></tr></table>
        </td></tr></table>
    </div>
    </form>
</body>
</html>


using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class serverlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        if (TextBox1.Text == "server" && TextBox2.Text == "server")
        {
            Response.Redirect("serverhome.aspx");
        }
        else
        {
            Response.Write("<script>alert('Username password Error. pls Try Again Later')</script>");
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }
}

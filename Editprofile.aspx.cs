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
using System.Data.SqlClient;
public partial class Editprofile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["User"].ToString();
       

      

        if (!Page.IsPostBack)
        {
            con.Open();
            cmd = new SqlCommand("select * from Register where uname='" + Label1.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox1.Text = dr[0].ToString();
                TextBox2.Text = dr[1].ToString();
                TextBox3.Text = dr[2].ToString();
                TextBox4.Text = dr[3].ToString();
                TextBox5.Text = dr[4].ToString();
                TextBox6.Text = dr[5].ToString();

            }
            else
            {
                Response.Write("<script>alert('Session Error')</script>");
            }
            con.Close();
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        
            con.Open();
            cmd = new SqlCommand("update Register set Fname='" + TextBox1.Text + "',pwd='" + TextBox3.Text + "',Addr='" + TextBox4.Text + "',Mob='" + TextBox5.Text + "',Emailid='" + TextBox6.Text + "' where uname='" + TextBox2.Text + "'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Redirect("UserHome.aspx");

           
       
      
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }
}

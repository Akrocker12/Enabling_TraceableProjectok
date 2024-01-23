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
public partial class Viewpage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da;
    DataSet ds;
    SqlDataReader dr;
    string uname,sdate,status;
    protected void Page_Load(object sender, EventArgs e)
    {
        status = "Request";
        sdate = System.DateTime.Now.ToString();
        Label1.Text = Session["bid"].ToString();
        uname = Session["User"].ToString();
    


        con.Open();
        cmd = new SqlCommand("select Fileid,Filename,Dataowner from Fileupload where Fileid='" + Label1.Text + "'", con);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            TextBox1.Text = dr[0].ToString();
            TextBox2.Text = dr[1].ToString();
            TextBox3.Text = dr[2].ToString();
         
            
        }
        else
        {
            
            con.Close();
        }
        dr.Close();
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (con.State == System.Data.ConnectionState.Closed)
            con.Open();
        cmd = new SqlCommand("insert into Requs values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + uname + "','" + sdate + "','" + status + "')", con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Request successfully Send')</script>");
        con.Close();
     

       
    }
}

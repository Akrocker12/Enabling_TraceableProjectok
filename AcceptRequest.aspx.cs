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
public partial class AcceptRequest : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da;
    DataSet ds;
    SqlDataReader dr;
    string uname, sdate, status;
    string mob1;
    protected void Page_Load(object sender, EventArgs e)
    {
        //
        //status = "Request";
        //sdate = System.DateTime.Now.ToString();
        Label1.Text = Session["bid"].ToString();
        uname = Session["User"].ToString();



        con.Open();
        cmd = new SqlCommand("select * from Requs where Sno=" + Label1.Text + "", con);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            TextBox1.Text = dr[0].ToString();
            TextBox2.Text = dr[1].ToString();
            TextBox3.Text = dr[2].ToString();
            TextBox4.Text = dr[3].ToString();
            TextBox5.Text = dr[4].ToString();
            TextBox6.Text = dr[5].ToString();
            //DropDownList1.Text = dr[5].ToString();
            
        }
        else
        {

            con.Close();
        }
        dr.Close();

       // if (con.State == ConnectionState.Closed)
       // {
       //     con.Open();
       // }
       // cmd = new SqlCommand("select Mob from Register where uname=" + uname + "", con);
       // dr = cmd.ExecuteReader();
       // if (dr.Read())
       // {

       //mob1 = dr[0].ToString();
          

       // }
       // else
       // {

       //     con.Close();
       // }
       // dr.Close();

  
        //

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand("Update Requs set Status='"+ DropDownList1.Text +"' where Sno=" + TextBox1.Text + "", con);
        cmd.ExecuteNonQuery();
        con.Close();
       
        

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand("insert into AcceptRequs values(" + TextBox1.Text + "," + TextBox2.Text + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList1.Text + "','"+ TextBox7.Text +"')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("ViewRequest.aspx");
    }
}

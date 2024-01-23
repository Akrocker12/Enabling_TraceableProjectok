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
public partial class ViewRequest : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    string a;
    protected void Page_Load(object sender, EventArgs e)
    {

        bindgrid();
    }

    private void bindgrid()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand("select * from Requs where Dataowner='" + Session["User"].ToString() + "'", con);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }



    protected void Btnupdate_Click(object sender, EventArgs e)
    {

        //CheckBox chk;
        //foreach (GridViewRow rowItem in GridView2.Rows)
        //{
        //    chk = (CheckBox)(rowItem.Cells[1].FindControl("CheckBox1"));
        //    // chk.checked will access the checkbox state value (on button click event) 
        //    if (chk.Checked = true)
        //    {
        //        a = chk.Text.ToString();
        //    }
        //    else
        //    {
        //        Response.Write("<script>'Select Only One Row At a Time to Update Statues.'</Script>");
        //    }
        //}
        //if (con.State == ConnectionState.Closed)
        //{
        //    con.Open();
        //}
        //cmd = new SqlCommand("Update Requs set Status='Accepted' where Sno='" + a + "'", con);
        //cmd.ExecuteNonQuery();
        //con.Close();
        //bindgrid();
        //Label8.Visible = true;
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
       
    }
    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
      
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        if (con.State == System.Data.ConnectionState.Closed)
            con.Open();
        int ij = Convert.ToInt32(GridView1.Rows[e.NewSelectedIndex].Cells[1].Text);
        //Label lbl = new Label();
        //lbl.Text = ((Label)DataList1.Items[e.Item.ItemIndex].FindControl("Label1")).Text;
        Session["bid"] = ij;
        Response.Redirect("AcceptRequest.aspx");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
}

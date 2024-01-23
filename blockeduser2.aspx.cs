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
public partial class blockeduser2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd;
    SqlDataReader dr;
    string a;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) bindgrid();
    }
    protected void Btnupdate_Click(object sender, EventArgs e)
    {
        CheckBox chk;
        foreach (GridViewRow rowItem in GridView2.Rows)
        {
            chk = (CheckBox)(rowItem.Cells[1].FindControl("CheckBox1"));
            // chk.checked will access the checkbox state value (on button click event) 
            if (chk.Checked == true)
            {
                a = chk.Text.ToString();
            }
            else
            {
                Response.Write("<script>'Select Only One Row At a Time to Update Statues.'</Script>");
            }
        }
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand("Delete from  block where username='" + a + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        bindgrid();
        Label8.Visible = true;
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataBind();
    }
    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView2.EditIndex = e.NewEditIndex;
        bindgrid();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void bindgrid()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand("select * from block", con);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView2.DataSource = ds;
        GridView2.DataBind();
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }


}

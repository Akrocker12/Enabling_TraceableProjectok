using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
//using com.aswinanand.www;
using System.Net;
public partial class SignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
 {
     //string IPAdd = string.Empty;
     //IPAdd = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
     //if (string.IsNullOrEmpty(IPAdd))
     //    IPAdd = Request.ServerVariables["REMOTE_ADDR"];
     //txtUserName.Text = IPAdd;
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd;
    static int count = 0;

    private bool YourValidationFunction(string UserName, string Password)
    {

        bool boolReturnValue = false;

        String SQLQuery = "SELECT Uname, Pwd FROM Ownerreg";
        SqlCommand command = new SqlCommand(SQLQuery, con);
        SqlDataReader Dr;
        con.Close();
        con.Open();
        Dr = command.ExecuteReader();
        while (Dr.Read())
        {
            if ((UserName == Dr["Uname"].ToString()) & (Password == (Dr["Pwd"].ToString())))
            {
                boolReturnValue = true;
            }
            //Dr.Close();
            //return boolReturnValue;
        }
        Dr.Close();
        return boolReturnValue;
    }

    public string dec(string strings)
    {
        int qbit = 1;


        ArrayList x = new ArrayList();
        ArrayList v1 = new ArrayList();
        string ss = strings;
        string orginal = "";
        String[] result = ss.Split('#');
        for (int x1 = 0; x1 < result.Length; x1++)
            v1.Add(result[x1]);
        string str = v1[0].ToString();
        orginal = orginal + str;
        int y = Int32.Parse(str);
        x.Add(y);
        int vsize = v1.Count;
        for (int i = 1; i < vsize - 1; i++)
        {
            int n = Convert.ToInt32(str);
            str = v1[i].ToString();
            int n1 = Convert.ToInt32(str);
            int fx = n1 - n * qbit;
            orginal = orginal + fx;
            x.Add(fx);
        }
        string text = "";
        for (int i = 0; i < x.Count; i++)
        {
            int no1 = Convert.ToInt32(x[i]);
            int a = Convert.ToInt32(no1);
            char data = Convert.ToChar(a);
            text += data;
        }
        strings = text;
        return strings;

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //
        con.Close();
        con.Open();
       SqlCommand cmd5 = new SqlCommand("select * from Ownerreg where uname='" + txtUserName.Text + "' and Status='Accepted'", con);

        SqlDataReader dr5 = cmd5.ExecuteReader();
        if (dr5.Read())
        {
          
            dr5.Close();

            if (YourValidationFunction(txtUserName.Text, txtPassword.Text))
            {
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("select * from block where username='" + txtUserName.Text + "'", con);
                SqlDataReader d = com.ExecuteReader();
                if (d.Read())
                {
                    Response.Write("<script>alert('Your Account Temporarily blocked. contact Administrator!! Thank you')</script>");
                    return;
                }
                d.Close();

                Session["User"] = txtUserName.Text;
                //e.Authenticated = true;
                SqlCommand cmd = new SqlCommand("insert into logdetails values('" + txtUserName.Text + "','" + Dns.GetHostName().ToString() + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                //Response.Redirect("UsersHome.aspx");
                Response.Redirect("Adminhome.aspx");
            }
            else
            {
                con.Close();

                SqlCommand cmd = new SqlCommand("select * from Ownerreg where Uname='" + txtUserName.Text + "'", con);
                con.Open();
                SqlDataReader drr = cmd.ExecuteReader();
                if (drr.Read())
                {
                    //e.Authenticated = false;
                    count++;
                    drr.Close();
                    SqlCommand cmd1 = new SqlCommand("select * from logdetails where username='" + txtUserName.Text + "' and hostname='" + Dns.GetHostName().ToString() + "'", con);
                    SqlDataReader dr;
                    dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        if (count >= 3 & count < 5)
                        {
                            con.Close();
                            con.Open();
                            dr.Close();
                            SqlCommand com = new SqlCommand("select * from block where username='" + txtUserName.Text + "'", con);
                            SqlDataReader d = com.ExecuteReader();
                            if (d.Read())
                            {
                                Response.Write("<script>alert('Server Busy. Try some time. Thank you')</script>");
                                return;
                            }
                            d.Close();
                            count = 0;
                            Session["User"] = txtUserName.Text;
                            SqlCommand cmd12 = new SqlCommand("insert into block values('" + txtUserName.Text + "','" + System.DateTime.Now.ToString() + "','blocked','" + Dns.GetHostName().ToString() + "')", con);
                            cmd12.ExecuteNonQuery();
                            con.Close();

                            Server.Transfer("Welcome.aspx");
                        }
                    }
                    if (count >= 5)
                    {
                        con.Close();
                        con.Open();
                        SqlCommand com = new SqlCommand("select * from block where username='" + txtUserName.Text + "'", con);
                        SqlDataReader d = com.ExecuteReader();
                        if (d.Read())
                        {
                            Response.Write("<script>alert('Server Busy. Try some time. Thank you')</script>");
                            return;
                        }

                        d.Close();
                        count = 0;
                        Session["User"] = txtUserName;
                        SqlCommand cmd12 = new SqlCommand("insert into block values('" + txtUserName.Text + "','" + System.DateTime.Now.ToString() + "','blocked')", con);
                        cmd12.ExecuteNonQuery();
                        con.Close();
                        Server.Transfer("Welcome.aspx");
                    }
                }
                else
                {
                }
                con.Close();
            }
        }

        else
        {

            Response.Write("<script>alert('Account Not Activated!! ')</script>");
        }  

        //
        
     
    }
}

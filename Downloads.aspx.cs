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
using System.IO;
using System.Text;
using System.Net;

public partial class Downloads : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    DataTable dt = new DataTable();
    SqlDataAdapter da = new SqlDataAdapter();
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

        Label1.Text= Session["User"].ToString();

        
        bindgrid();
    }
    int iclickrow;   
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
              

      
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       //



        if (con.State == System.Data.ConnectionState.Closed)
            con.Open();
        cmd = new SqlCommand("Select Filename from Fileupload where Fkey='" + TextBox3.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            string str = dr[0].ToString();

            string filePath = Server.MapPath("~/Upload");
            string _DownloadableProductFileName = str;

            System.IO.FileInfo FileName = new System.IO.FileInfo(filePath + "\\" + _DownloadableProductFileName);
            FileStream myFile = new FileStream(filePath + "\\" + _DownloadableProductFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //Reads file as binary values
            BinaryReader _BinaryReader = new BinaryReader(myFile);


            long startBytes = 0;
            string lastUpdateTiemStamp = File.GetLastWriteTimeUtc(filePath).ToString("r");
            string _EncodedData = HttpUtility.UrlEncode(_DownloadableProductFileName, Encoding.UTF8) + lastUpdateTiemStamp;

            Response.Clear();
            Response.Buffer = false;
            Response.AddHeader("Accept-Ranges", "bytes");
            Response.AppendHeader("ETag", "\"" + _EncodedData + "\"");
            Response.AppendHeader("Last-Modified", lastUpdateTiemStamp);
            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName.Name);
            Response.AddHeader("Content-Length", (FileName.Length - startBytes).ToString());
            Response.AddHeader("Connection", "Keep-Alive");
            Response.ContentEncoding = Encoding.UTF8;

            //Send data
            _BinaryReader.BaseStream.Seek(startBytes, SeekOrigin.Begin);

            //Dividing the data in 1024 bytes package
            int maxCount = (int)Math.Ceiling((FileName.Length - startBytes + 0.0) / 1024);

            //Download in block of 1024 bytes
            int i;
            for (i = 0; i < maxCount && Response.IsClientConnected; i++)
            {
                Response.BinaryWrite(_BinaryReader.ReadBytes(1024));
                Response.Flush();
            }

            //

            dr.Close();
            int a = 1;
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Rank where Fname='" + str + "' ", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                dr1.Close();
                cmd = new SqlCommand("update Rank set Downloads=Downloads +" + a + " where Fname='" + str + "'", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

            }
            else
            {
                dr1.Close();
                cmd = new SqlCommand("insert into Rank values('" + str + "'," + a + ")", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

            }


            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            SqlCommand cmd3 = new SqlCommand("insert into Downloads values('" + Label1.Text + "','" + str + "','" + System.DateTime.Now + "')", con);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();
            con.Close();
        }


        else
        { 
        
            if (int.TryParse(Label2.Text, out count))
            {
                Label2.Text = (++count).ToString();
            }
            if (Convert.ToInt16(Label2.Text) == 3)
            {
                con.Close();
                con.Open();

                SqlCommand cmd1 = new SqlCommand("select Emailid from Ownerreg where Uname='" + Session["User"].ToString() + "' ", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string a = dt.Rows[0]["Emailid"].ToString();
                   // string result = apicall("http://smsc.vinuxnetwork.com/httpapi/send?username=ascentztech@gmail.com&password=miracle&sender_id=PROMOTIONAL&route=P&phonenumber=" + a + "&message=For The Wrong Transaction. Your Cloud Account Has been Blocked.Contact Administrator,  Mr/Ms:" + Label1.Text + " ");
                    string c = "Your account blocked";
                    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                    //Create a mail id in gmail or u can use ur mail id password here to send mail
                    System.Net.NetworkCredential cred = new System.Net.NetworkCredential("testmailalert20@gmail.com", "qwghdvduxumxjidk");

                    mail.To.Add(a);
                    mail.Subject = "Your Account Blocked";
                    mail.From = new System.Net.Mail.MailAddress("testmailalert20@gmail.com");
                    mail.IsBodyHtml = true; // Aceptamos HTML
                    mail.Body = "For The Wrong Transaction ... Your Account Has been Blocked... Contact Administrator.. Thank you..";
                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");


                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = cred; //asignamos la credencial
                    smtp.Send(mail);

                }

                SqlCommand cmd12 = new SqlCommand("insert into block values('" + Session["User"].ToString() + "','" + System.DateTime.Now.ToString() + "','blocked','" + Dns.GetHostName().ToString() + "')", con);
                cmd12.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Home.aspx");
            }

        
        }

        Label1.Text = Session["User"].ToString();




                //
    }

    public string apicall(string url)
    {
        HttpWebRequest httpreq = (HttpWebRequest)WebRequest.Create(url);

        try
        {
            HttpWebResponse httpres = (HttpWebResponse)httpreq.GetResponse();
            StreamReader sr = new StreamReader(httpres.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();
            return results;
        }
        catch
        {
            return "0";
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //

        iclickrow = GridView1.SelectedIndex;

        Label3.Visible = true;
        TextBox3.Visible = true;
        Button1.Visible = true;

      

        if (con.State == System.Data.ConnectionState.Closed)
            con.Open();
        int ij = Convert.ToInt32(GridView1.Rows[e.NewEditIndex].Cells[3].Text);
        //  string str = lbl.Text;
        cmd = new SqlCommand("Select Filename,Fkey from Fileupload where Fileid=" + ij + "", con);
        SqlDataReader dr1 = cmd.ExecuteReader();
        if (dr1.Read())
        {
            Label6.Text = dr1[0].ToString();
            string fkey = dr1[1].ToString();


            dr1.Close();
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            cmd = new SqlCommand("Select Emailid from Ownerreg where uname='" + Label1.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    string mob = dr[0].ToString();
                   // string result = apicall("http://smsc.vinuxnetwork.com/httpapi/send?username=ascentztech@gmail.com&password=miracle&sender_id=PROMOTIONAL&route=P&phonenumber=" + mob + "&message=File Key:" + fkey + " ");

                    // string mob = dr[1].ToString();
                    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                    System.Net.NetworkCredential cred = new System.Net.NetworkCredential("testmailalert20@gmail.com", "qwghdvduxumxjidk");
                    string em = mob;
                    mail.To.Add(em);
                    mail.Subject = "File key";

                    mail.From = new System.Net.Mail.MailAddress("testmailalert20@gmail.com");
                    mail.IsBodyHtml = true; // Aceptamos HTML

                    mail.Body = "File key '" + fkey + "' !!!";
                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");


                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = cred; //asignamos la credencial
                    smtp.Send(mail);


                }
                con.Close();
                dr.Close();
            }
            catch
            { }
        }

        //
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //

        //if (con.State == System.Data.ConnectionState.Closed)
        //    con.Open();
        //cmd = new SqlCommand("Select Userkey from Ownerreg where Uname='" + Label1.Text + "' and Userkey='" + TextBox1.Text + "'", con);
        //SqlDataReader dr = cmd.ExecuteReader();
        //if (dr.Read())
        //{
        //    string str = dr[0].ToString();

        //    Label3.Visible = true;
        //    TextBox3.Visible = true;
        //    Button1.Visible = true;
        //}

        //else
        //{
        //    Response.Write("<script>alert('Key Not Match')</script>");
        
        //}





        //
    }


    private void bindgrid()
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
                        
                 SqlCommand cmd1 = new SqlCommand("select * from AcceptRequs where uname=  '" + Label1.Text + "' and Status='Accepted'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                GridView1.DataSource = ds1.Tables[0];
                GridView1.DataBind();
                con.Close();
        }
        catch
        { 
        }


        }
        
    
}

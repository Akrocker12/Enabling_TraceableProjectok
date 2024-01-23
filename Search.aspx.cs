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
public partial class Search : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {


        Label1.Text = Session["User"].ToString();
        
        //con.Open();
        //cmd=new SqlCommand("Select Fname from Rank where Downloads=(Select max(Downloads) from Rank)",con);
        //SqlDataReader dr = cmd.ExecuteReader();
        //while (dr.Read())
        //{
        //    Label4.Text = dr[0].ToString();

        //}
        //con.Close();
        //dr.Close();

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        //string t1, t2,res;
        //t1 = TextBox1.Text;
        //t2 = TextBox2.Text;
        //res = t1 + t2;
       

            con.Close();
          //  cmd = new SqlCommand("select Fileid,filename,uptime from Fileupload where Keyword like '%" + TextBox1.Text + "%' ORDER BY desc ", con);
           // cmd = new SqlCommand("select a.Fileid,a.filename,a.uptime from Fileupload a left join Rank b on a.filename=b.Fname where Keyword like '%" + TextBox1.Text + "%' ORDER BY b.Downloads desc", con);
            cmd = new SqlCommand("select a.Fileid,a.filename,a.uptime from Fileupload a left join Rank b on a.filename=b.Fname where Keyword like '%" + TextBox1.Text + "%' OR Keyword LIKE '%" + TextBox2.Text + "%'  ORDER BY b.Downloads desc", con);
        con.Open();
             SqlDataReader dr1 = cmd.ExecuteReader();
             if (dr1.Read())
             {
                 dr1.Close();
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataSet ds = new DataSet();
                 da.Fill(ds);
                 //DataList1.DataSource = ds;
                 //DataList1.DataBind();
                 GridView1.DataSource = ds.Tables[0];
                 GridView1.DataBind();
                 if (GridView1.Rows.Count > -1) GridView1.SelectedIndex = 0;
                 con.Close();
                 
             }
             else
             {
                 Response.Write("<script>alert('Result Not Found')</script>");
             
             }
             dr1.Close();
        

      
        
    }
    protected void lnkBut_Click(object sender, EventArgs e)
    {
        //string filePath = Server.MapPath("~/Data");
        ////string _DownloadableProductFileName = lbl1.Text+".txt";
        //string _DownloadableProductFileName = lnkBut;

        //System.IO.FileInfo FileName = new System.IO.FileInfo(filePath + "\\" + _DownloadableProductFileName);
        //FileStream myFile = new FileStream(filePath + "\\" + _DownloadableProductFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
       

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
       
    }
    int iclickrow;


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        string ij = GridView1.SelectedRow.Cells[0].Text;
        
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string str = e.CommandName.ToString();
        var str1 = e.CommandArgument;
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            LinkButton l = new LinkButton();
            l = (LinkButton)(e.Row.FindControl("More"));

            //l.Attributes.Add("onclick", "javascript:return " & _
            //     "confirm('Are you sure you want to Reserve this seat?')");


        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        GridView1_SelectedIndexChanged(sender, e);





    }
    //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
        

    //}

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        ////iclickrow = GridView1.SelectedIndex;

        //Label3.Visible = true;
        //TextBox3.Visible = true;
        //Button1.Visible = true;

        //if (con.State == System.Data.ConnectionState.Closed)
        //    con.Open();
        //string str = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text;
        //cmd = new SqlCommand("Select Filename,Fkey from Fileupload where Fileid=" + str + ")", con);
        //SqlDataReader dr1 = cmd.ExecuteReader();
        //while (dr1.Read())
        //{
        //    Label6.Text = dr1[0].ToString();
        //    string fkey = dr1[1].ToString();



        //    if (con.State == System.Data.ConnectionState.Closed)
        //        con.Open();
        //    cmd = new SqlCommand("Select Emailid from Register where uname='" + Label1.Text + "')", con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        string email = dr[0].ToString();
        //        System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
        //        System.Net.NetworkCredential cred = new System.Net.NetworkCredential("ascentzpica@gmail.com", "preventing");
        //        string em = email;
        //        mail.To.Add(em);
        //        mail.Subject = "File key";

        //        mail.From = new System.Net.Mail.MailAddress("ascentzpica@gmail.com");
        //        mail.IsBodyHtml = true; // Aceptamos HTML

        //        mail.Body = "File key '" + fkey + "' !!!";
        //        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");


        //        smtp.UseDefaultCredentials = false;
        //        smtp.EnableSsl = true;
        //        smtp.Credentials = cred; //asignamos la credencial
        //        smtp.Send(mail);


        //    }
        //    con.Close();
        //    dr.Close();
        //}

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        // Label lbl;
        //lbl = (Label)GridView1.Rows[GridView1.SelectedIndex].FindControl("Label2");
        //lbl.Visible = true;
        //iclickrow = GridView1.SelectedIndex;


        //con.Open();
        ////try
        ////{
        //Label str = (Label)GridView1.Rows[iclickrow].FindControl("Label1");

        ////cmd = new SqlCommand("Select Filename from Fileupload where Filename=" + str + "", con);
        ////cmd.ExecuteNonQuery();
        ////con.Close();

        //


         if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            cmd = new SqlCommand("Select Filename from Fileupload where Fkey='" + TextBox3.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string str = dr[0].ToString();

                string filePath = Server.MapPath("~/Data");
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



                //
                //}
                //catch (Exception ex)
                //{

                //}




                //

            }
           // Response.Redirect("Search.aspx");
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //iclickrow = GridView1.SelectedIndex;

      //  Label3.Visible = true;
      //  TextBox3.Visible = true;
      //  Button1.Visible = true;

      //  if (con.State == System.Data.ConnectionState.Closed)
      //      con.Open();
      //  int ij = Convert.ToInt32(GridView1.Rows[e.NewEditIndex].Cells[1].Text);
      ////  string str = lbl.Text;
      //  cmd = new SqlCommand("Select Filename,Fkey from Fileupload where Fileid=" + ij + "", con);
      //  SqlDataReader dr1 = cmd.ExecuteReader();
      //  if (dr1.Read())
      //  {
      //      Label6.Text = dr1[0].ToString();
      //      string fkey = dr1[1].ToString();


      //      dr1.Close();
      //      if (con.State == System.Data.ConnectionState.Closed)
      //          con.Open();
      //      cmd = new SqlCommand("Select Emailid from Register where uname='" + Label1.Text + "'", con);
      //      SqlDataReader dr = cmd.ExecuteReader();
      //      if (dr.Read())
      //      {
      //          string email = dr[0].ToString();
      //          System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
      //          System.Net.NetworkCredential cred = new System.Net.NetworkCredential("ascentzpica@gmail.com", "ieeeprojects");
      //          string em = email;
      //          mail.To.Add(em);
      //          mail.Subject = "File key";

      //          mail.From = new System.Net.Mail.MailAddress("ascentzpica@gmail.com");
      //          mail.IsBodyHtml = true; // Aceptamos HTML

      //          mail.Body = "File key '" + fkey + "' !!!";
      //          System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");


      //          smtp.UseDefaultCredentials = false;
      //          smtp.EnableSsl = true;
      //          smtp.Credentials = cred; //asignamos la credencial
      //          smtp.Send(mail);


      //      }
      //      con.Close();
      //      dr.Close();
       // }

        if (con.State == System.Data.ConnectionState.Closed)
          con.Open();
      int ij = Convert.ToInt32(GridView1.Rows[e.NewEditIndex].Cells[1].Text);
        //Label lbl = new Label();
        //lbl.Text = ((Label)DataList1.Items[e.Item.ItemIndex].FindControl("Label1")).Text;
      Session["bid"] = ij;
        Response.Redirect("Viewpage.aspx");
        //

        //if (con.State == System.Data.ConnectionState.Closed)
        //        con.Open();
        //    cmd = new SqlCommand("Select Enfname from Fileupload where Fileid=" + Label1.Text + "", con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        string dest = Server.MapPath("Encrypt\\" + FileUpload1.FileName.ToString());
        //        FileUpload1.SaveAs(dest);
        //    }
        //
    }
}

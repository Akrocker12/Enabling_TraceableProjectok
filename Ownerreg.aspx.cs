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
public partial class Ownerreg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Random r = new Random();
        int rnd = r.Next(2000000);
        string rnd1 = Convert.ToString(rnd);

        con.Open();
        cmd = new SqlCommand("select Uname from Ownerreg where Uname='" + TextBox1.Text + "'", con);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Response.Write("<script>alert('The user Details are Already Exist')</script>");
            cmd.Dispose();
            dr.Close();
        }
        else
        {
            try
            {
                dr.Close();
                string status = "Registered";
                cmd = new SqlCommand("insert into Ownerreg values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + status + "','" + rnd1 + "')", con);
                cmd.ExecuteNonQuery();


                cmd.Dispose();

                //string email = TextBox6.Text;
                ////   string mob = dr[1].ToString();
                //System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                //System.Net.NetworkCredential cred = new System.Net.NetworkCredential("packtemp1@gmail.com", "packtemp1234");
                //string em = email;
                //mail.To.Add(em);
                //mail.Subject = "User key";

                //mail.From = new System.Net.Mail.MailAddress("packtemp1@gmail.com");
                //mail.IsBodyHtml = true; // Aceptamos HTML

                //mail.Body = "User key '" + rnd1 + "' !!!";
                //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");


                //smtp.UseDefaultCredentials = false;
                //smtp.EnableSsl = true;
                //smtp.Credentials = cred; //asignamos la credencial
                //smtp.Send(mail);


               // Response.Redirect("SignIn.aspx");

                Response.Write("<script>alert('Registered Successfullly')</script>");

            }
            catch
            {


            }

        }
        con.Close();

    }
}

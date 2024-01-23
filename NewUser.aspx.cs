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
public partial class NewUser : System.Web.UI.Page
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
        cmd = new SqlCommand("select uname from Register where uname='" + TextBox2.Text + "'", con);
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
                Response.Write("<script>alert('User Key Sent Your Mail Id')</script>");
                cmd = new SqlCommand("insert into Register values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','"+ rnd1 +"')", con);
                cmd.ExecuteNonQuery();
               
                cmd.Dispose();


               
                    //string email = TextBox6.Text;
                    //System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                    //System.Net.NetworkCredential cred = new System.Net.NetworkCredential("ascentzpica@gmail.com", "preventing");
                    //string em = email;
                    //mail.To.Add(em);
                    //mail.Subject = "User Key";

                    //mail.From = new System.Net.Mail.MailAddress("ascentzpica@gmail.com");
                    //mail.IsBodyHtml = true; // Aceptamos HTML

                    //mail.Body = "User key '" + rnd1 + "' !!!";
                    //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");


                    //smtp.UseDefaultCredentials = false;
                    //smtp.EnableSsl = true;
                    //smtp.Credentials = cred; //asignamos la credencial
                    //smtp.Send(mail);


                    Response.Redirect("Userlogin.aspx");
               
           }
            catch
            {


            }

        }
        con.Close();
    }
}

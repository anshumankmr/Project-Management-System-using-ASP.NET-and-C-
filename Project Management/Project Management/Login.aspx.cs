using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Management
{
    public partial class Login : System.Web.UI.Page
    {
        private string connectionstring = WebConfigurationManager.ConnectionStrings["Project"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Session.Abandon();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE UserName = @username AND Password =  @password", connection);
            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader myreader;
            try
            {
                  {
                    connection.Open();
                    myreader = cmd.ExecuteReader();
                    myreader.Read();
                    if (myreader != null)
                    {
                        Label2.Text = "Welcome " + myreader["name"] + "! " + "Redirecting You To " + myreader["Type"] + "'s Page";
                        Session["Name"] = myreader["name"];
                        Session["UserName"] = myreader["UserName"];
                       // Response.Redirect(myreader["Type"].ToString() + ".aspx");
                    }
                    else
                    {
                        Label2.Text = "Oops!! The Password You Entered Was Incorrect";
                        Thread.Sleep(2000);
                       // Page.Response.Redirect(Page.Request.Url.ToString(), true);
                    }
                }
            }
            catch(Exception)
            {
       
                Label2.Text = "Oops!! Random Error. Reloading in 1...";
                Thread.Sleep(200000);
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
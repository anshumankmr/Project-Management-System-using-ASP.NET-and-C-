using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace Project_Management
{
    public partial class Login : System.Web.UI.Page
    {
        private string connectionstring = WebConfigurationManager.ConnectionStrings["Project"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Label3.Text = Session.SessionID.ToString();
            }
            else if (IsPostBack)
            {
                
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
                    HttpCookie cookie = new HttpCookie("info");
                    cookie["UserName"] = myreader["UserName"].ToString();
                    cookie["Name"] = myreader["Name"].ToString();
                    cookie["ProjectID"] = myreader["ProjectId"].ToString();
                    cookie.Expires = DateTime.Now.AddDays(1);
                    if (myreader != null)
                    {
                        Label2.Text = myreader["Type"].ToString();
                        if (myreader["Type"].ToString().StartsWith("A") )
                        {
                            Response.Cookies.Add(cookie);
                            Response.Redirect("Admin.aspx?name=Anshuman");
                        }  
                        else
                        {
                            Response.Cookies.Add(cookie);
                            Response.Redirect("Developer.aspx");
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record    Inserted Successfully')", true);

                        Label2.Text = "Oops!! The Password You Entered Was Incorrect";
                        
                        //Page.Response.Redirect(Page.Request.Url.ToString(), true);
                    }
                }
            }
            catch(Exception)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' Inserted Successfully')", true);

                Label2.Text = "Oops!! Random Error. Reloading in 1...";
                //Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
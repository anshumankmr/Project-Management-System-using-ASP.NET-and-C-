using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Management
{
    public partial class Comment : System.Web.UI.Page
    {
        private string connectionstring = WebConfigurationManager.ConnectionStrings["Project"].ConnectionString;
        private string usrname;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            
            string command = "INSERT  INTO Comment (Text,UserName,ProjectId) VALUES (@cmt , @usrname , @pid )";
            usrname = Request.QueryString["UserName"];
            Label3.Text = usrname;
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.Parameters.AddWithValue("@cmt",TextBox1.Text);
            cmd.Parameters.AddWithValue("@pid", TextBox2.Text);
            cmd.Parameters.AddWithValue("@usrname", usrname);
            try 
            {
              connection.Open();
              int read = cmd.ExecuteNonQuery();
                    if (read <= 0)
                    {
                        Label3.Text = "Random Error"; 
                    }
                
            }
            catch( Exception ex)
            {
                Label3.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
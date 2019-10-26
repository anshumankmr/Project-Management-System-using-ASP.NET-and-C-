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
    public partial class AddProject : System.Web.UI.Page
    {
        private string connectionstring = WebConfigurationManager.ConnectionStrings["Project"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        //ASSUMING THE CONTROLS HAVE BEEN VALIDATED NOTE THAT COMMENTS IS NULL
        protected void EnterButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string command = "INSERT  INTO Project (Title,Duration,Client,Status) VALUES (@title , @duration , @client , @status )";
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.Parameters.AddWithValue("@title", TextBox1.Text);
            cmd.Parameters.AddWithValue("@duration", TextBox3.Text);
            cmd.Parameters.AddWithValue("@client", TextBox2.Text);
            cmd.Parameters.AddWithValue("@status", TextBox4.Text);
          
            try
            {
               connection.Open();
               int rows = cmd.ExecuteNonQuery();
               if (rows != 0 )
               {
                StatusLabel.Text = "Insertion Was Sucessful";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
               }
               else
               {
                 StatusLabel.Text = "Insertion Was Unsucessful";
                 ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Not Inserted')", true);
                 Page.Response.Redirect(Page.Request.Url.ToString(), true);
                }
               
            }
            catch (Exception ex)
            {
                Label2.Text = ex.Message;
               // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + ex.Message + "')", true);
            }
            finally
            {
                connection.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
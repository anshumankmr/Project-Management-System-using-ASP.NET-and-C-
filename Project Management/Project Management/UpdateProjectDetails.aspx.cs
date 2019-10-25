using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Management
{
    public partial class UpdateProjectDetails : System.Web.UI.Page
    {
        private string connectionstring = WebConfigurationManager.ConnectionStrings["Project"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ServerValidate(object sender, ServerValidateEventArgs args)
        {
            args.IsValid = TextBox1.Text.Trim().Length > 0 || TextBox2.Text.Trim().Length > 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                string query;
                SqlConnection con = new SqlConnection(connectionstring);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter;
                if (TextBox1.Text.Length != 0)
                {
                    query = TextBox1.Text;

                    SqlCommand cmd = new SqlCommand("SELECT * FROM  Project WHERE Title = @title", con);
                    cmd.Parameters.AddWithValue("@title", query);
                    adapter = new SqlDataAdapter(cmd);


                }
                else
                {
                    query = TextBox2.Text;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM  Project WHERE ProjectID = @id", con);
                    cmd.Parameters.AddWithValue("@id", query);
                    adapter = new SqlDataAdapter(cmd);
                }
                adapter.Fill(ds, "Project");
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }

        }
    }
}
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
        private string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RadioButtonList1.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                Button2.Visible = false;
                RadioButtonList1.Items.Add("Yes");
                RadioButtonList1.Items.Add("No");
            }
        }
        protected void ServerValidate(object sender, ServerValidateEventArgs args)
        {
            if (TextBox1.Text.Length > 0 && TextBox2.Text.Length > 0)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true ;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
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
                if (ds.Tables["Project"].Rows.Count > 0 )
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Search Successful')", true);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    Label3.Visible = true;
                    RadioButtonList1.Visible = true;
                    id = ds.Tables["Project"].Rows[0]["ProjectId"].ToString();


                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Search Unsuccessful')", true);
                }
               
            }

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                Label4.Visible = true;
                Label5.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                Button2.Visible = true;
            }
            else
            {
                Response.Redirect("Admin.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string command = @"UPDATE Project 
               SET Status = @status
                   Duration = @duration
               WHERE ProjectId = @id";
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.Parameters.AddWithValue("@duration", TextBox3.Text);
            cmd.Parameters.AddWithValue("@status", TextBox4.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            
        }
    }
}
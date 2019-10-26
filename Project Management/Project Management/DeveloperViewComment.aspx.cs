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
    public partial class DeveloperViewComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            string selectSQL = "SELECT * FROM Comment WHERE ProjectId = @pid";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            try
            {
                Label1.Text = "Welcome " +Session["Name"] + " User Name : " + Session["UserName"] + " Project ID" + Session["ProjectId"];
                cmd.Parameters.AddWithValue("@pid", Request.QueryString["ProjectId"]);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // Fill the DataSet.
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Comment");
                // Perform the binding.
                GridView1.DataSource = ds;
                GridView1.DataBind();







            }
            catch(Exception )
            {
                
                HttpCookie cookie = Request.Cookies["info"];
                string name = cookie["Name"];
                string username = cookie["UserName"];
                string pid = cookie["ProjectId"];
                Label1.Text = "Welcome " + name + " User Name : " + username + " Project ID" + pid;
                SqlCommand cmd1 = new SqlCommand(selectSQL, con);
                cmd1.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                // Fill the DataSet.
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1, "Comment");
                // Perform the binding.
                GridView1.DataSource = ds1;
                GridView1.DataBind();
            }
        }
    }
}
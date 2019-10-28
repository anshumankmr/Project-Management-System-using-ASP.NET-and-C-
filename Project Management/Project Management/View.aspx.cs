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
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["info"];
                string name = cookie["Name"];
                string username = cookie["UserName"];
                string pid = cookie["ProjectId"];
                string connectionString =
WebConfigurationManager.ConnectionStrings["Project"].ConnectionString;
                string selectSQL = "SELECT * FROM Project WHERE ProjectID = " + pid;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // Fill the DataSet.
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Project");
                // Perform the binding.
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
    }
}
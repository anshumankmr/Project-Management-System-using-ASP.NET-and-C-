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
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            string connectionString =
WebConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            string selectSQL = "SELECT * FROM Project WHERE Client = " + TextBox1.Text;
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
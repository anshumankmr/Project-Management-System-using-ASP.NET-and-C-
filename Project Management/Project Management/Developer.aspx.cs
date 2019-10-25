using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Management
{
    public partial class Developer : System.Web.UI.Page
    {
        private string name, username;

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Comment.aspx?=Name"+name+"&UserName="+username);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["Information"];
                name = cookie["Name"];
                username = cookie["UserName"];
                Label1.Text = "Welcome " + name ;
            }
        }

    }
}
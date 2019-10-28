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
       private string name, username,pid;
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Comment.aspx?UserName="+username);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["info"];
            Response.Cookies.Add(cookie);
            Response.Redirect("View.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            {
                HttpCookie cookie = Request.Cookies["info"];
                name = cookie["Name"];
                username = cookie["UserName"];
                pid = cookie["ProjectId"];
                Response.Cookies.Add(cookie);
            }
            
            Response.Redirect("DeveloperViewComment.aspx") ;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie  = Request.Cookies["info"];
                name = cookie["Name"];
                username = cookie["UserName"];
                pid = cookie["ProjectId"];
                Label1.Text = "Welcome " + name ;
            }
        }

    }
}
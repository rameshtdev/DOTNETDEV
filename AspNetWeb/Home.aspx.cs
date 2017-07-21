using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWeb
{
    public partial class Home : System.Web.UI.Page
    {
        bool isAuthenticated = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.TextMode = TextBoxMode.Password;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var username = TextBox1.Text;
            var pwd = TextBox2.Text;

            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(pwd))
            {
                //go to DB
                isAuthenticated = true;
            }
            else
            {
                isAuthenticated = false;
            }

            if (!isAuthenticated)
            {
                Label3.Visible = true;
            }
            else
            {
                Label3.Visible = false;
                //Server.Transfer("/Welcome.aspx");
                 Response.Redirect("/Welcome.aspx?employeeid=1&dept=eng");
                //Response.Redirect("http://www.google.com");
                //Response.Write("<script>window.close();window.open('http://www.google.com');</script>");
            }
        }

        protected void link1_Click(object sender, EventArgs e)
        {
            TextBox2.TextMode = TextBoxMode.SingleLine;

        }
    }
}
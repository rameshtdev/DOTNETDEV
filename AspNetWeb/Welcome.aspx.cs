using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWeb
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string employeeid = Request.QueryString["employeeid"].ToString();
            //string Dept = Request.QueryString["Dept"].ToString();
            string text = Convert.ToString(Request.Form["TextBox1"]);
            //Response.Write(string.Format("Welcome to Marlabs: EmpId{0}, Dept {1}, textBox {2}", employeeid, Dept,text));
            Response.Write(string.Format("Welcome to Marlabs: "));
        }
    }
}
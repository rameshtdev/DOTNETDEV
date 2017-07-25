using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWeb
{
    public partial class SelfAssessment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string[] country = { "USA", "Canada", "Mexico", "Brazil" };
                foreach(var c in country)
                {
                    ddlCountry.Items.Add(new ListItem(c));
                }                
            }
            else
            {
                string FirstName = txtFirstName.Text;
                string LastName = txtLastName.Text;
                string Email = txtEmail.Text;
                string HireDate = txtHireDate.Text;
                int Gender = Convert.ToInt32(rbtnGenderList.SelectedValue);
                string country = ddlCountry.SelectedValue;
                //string tech = chkTech.SelectedValue;
                string qualification = lstQualification.SelectedValue;
            }
        }
    }
}
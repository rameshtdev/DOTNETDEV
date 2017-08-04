using AspNetWeb.DataAccess;
using AspNetWeb.Models;
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
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                string[] country = { "USA", "Canada", "Mexico", "Brazil" };
                foreach(var c in country)
                {
                    ddlCountry.Items.Add(new ListItem(c));
                }                
            }
            BindDataGrid();
        }
        private void BindDataGrid()
        {
            var AssessmentList = (new AssessmentData()).GetAssessmentsTable();
            GridView1.DataSource = AssessmentList;
            GridView1.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string tech = string.Empty;
            string qual = string.Empty;

            foreach (ListItem item in chkTech.Items)
            {
                if(item.Selected)
                {
                    tech+=item.Text+"|";
                }
            }
            foreach (ListItem item in lstQualification.Items)
            {
                if (item.Selected)
                {
                    qual += item.Text + "|";
                }
            }

            var inputModel = new Assessment1() {
                firstname = txtFirstName.Text,
                lastname =txtLastName.Text,
                email = txtEmail.Text,
                hiredate = Convert.ToDateTime(txtHireDate.Text),
                gender = Convert.ToInt32(rbtnGenderList.SelectedValue),
                country = ddlCountry.SelectedValue,
                technologies = tech,
                qualification = qual
            };

            var data = new DataAccess.AssessmentData();
            //data.SaveAssessment(inputModel);
            data.SaveAssessmentEF(inputModel);
            BindDataGrid();
            
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;
            var AssessmentList = (new AssessmentData()).GetAssessmentsTable();
            GridView1.DataSource = AssessmentList;
            GridView1.DataBind();

        }
    }
}
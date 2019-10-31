using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlacementProjV1
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["StudentName"] == null))
            {
                Button1.Visible = true;
                Response.Redirect("StudentHomePage.aspx");
                // Label1.Text = "Welcome " + Session["StudentName"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentsCompanyList.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentUploadResume.aspx");

        }

       
    }
}
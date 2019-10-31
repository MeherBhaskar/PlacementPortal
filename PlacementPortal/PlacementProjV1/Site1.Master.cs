using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlacementProjV1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Visible = false;
            if(!(Session["StudentName"] == null))
            {
                Button1.Visible = true;
                Label1.Text = "Welcome "+Session["StudentName"].ToString();
            }

            if (!(Session["CompanyName"] == null))
            {
                Button1.Visible = true;
                Label1.Text = "Welcome " + Session["CompanyName"].ToString();
            }

            if(!(Session["GroupID"] == null))
            {
                Button1.Visible = true;
                Label1.Text = "Welcome "+Session["GroupID"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (!(Session["StudentName"] == null))
            {
                Session.Clear();
                Response.Redirect("HomePage.aspx");
            }

            if (!(Session["CompanyName"] == null))
            {
                Session.Clear();
                Response.Redirect("HomePage.aspx");
            }
            
            if (!(Session["GroupID"] == null))
            {
                Session.Clear();
                Response.Redirect("HomePage.aspx");
            
            
            }
        }
    }
}
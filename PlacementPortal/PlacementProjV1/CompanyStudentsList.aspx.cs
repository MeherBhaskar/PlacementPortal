using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlacementProjV1
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["CompanyName"] == null))
            {
                //Button1.Visible = true;
                string CompanyUID = Session["Company_UID"].ToString();

                string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                string sql = "SELECT * FROM CompanyRegistrations WHERE Comapany_UID = @Comapany_UID";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Comapany_UID", CompanyUID);
                connection.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);

                gv.DataSource = dt;
                this.DataBind();
            }
            else
            {
                Response.Redirect("CompanyHomePage.aspx");
            }

            

        }
        public void gv_SelectedIndexChanged(Object sender, EventArgs e)
        {
            GridViewRow row = gv.Rows[gv.SelectedIndex];
            //label1.Text = Session["StudentRegNo"].ToString() + "Selected Row : " + ((Label)gvSortingPaging.Rows[gvSortingPaging.SelectedIndex].Cells[0].FindControl("Label3")).Text;
            string regNo = ((Label)gv.Rows[gv.SelectedIndex].Cells[0].FindControl("Label3")).Text;
            string url = "CompanyStudentResume.aspx?";
            url += "RegNo=" + Server.UrlEncode(regNo);
            Response.Redirect(url);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminViewGroups.aspx");
        }
    }

}

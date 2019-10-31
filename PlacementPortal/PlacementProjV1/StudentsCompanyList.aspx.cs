using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlacementProjV1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["StudentName"] == null))
            {
                //Button1.Visible = true;
                Response.Redirect("StudentHomePage.aspx");
                // Label1.Text = "Welcome " + Session["StudentName"].ToString();
            }
        }
        
        //gv_SelectedIndexChanged

        public void gv_SelectedIndexChanged(Object sender, EventArgs e)
        {
            GridViewRow row = gvSortingPaging.Rows[gvSortingPaging.SelectedIndex];
            label1.Text = Session["StudentRegNo"].ToString() + "Selected Row : "+ ((Label)gvSortingPaging.Rows[gvSortingPaging.SelectedIndex].Cells[0].FindControl("Label3")).Text;
            
            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            string insertSQL = "";
            insertSQL += "INSERT INTO CompanyRegistrations (";
            insertSQL += "Comapany_UID, RegNo )";
            insertSQL += "VALUES ( ";
            insertSQL += "@Comapany_UID, @RegNo);";
            
            SqlCommand cmd = new SqlCommand(insertSQL, con);

            int added = 0;
            
            cmd.Parameters.AddWithValue("@Comapany_UID", ((Label)gvSortingPaging.Rows[gvSortingPaging.SelectedIndex].Cells[0].FindControl("Label3")).Text);
            cmd.Parameters.AddWithValue("@RegNo", Session["StudentRegNo"].ToString());
            try
            {
                con.Open();
                added = cmd.ExecuteNonQuery();
                label1.Text = "Successfully Registered for " + ((Label)gvSortingPaging.Rows[gvSortingPaging.SelectedIndex].Cells[0].FindControl("Label4")).Text;
            }
            catch (Exception err)
            {
                label1.Text += "Already Registered";
            }
            finally
            {
                con.Close();
            }
        }
    }
}
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
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection con2 = new SqlConnection();

            con2.ConnectionString = connectionString;
            string select_cmd = "SELECT * FROM CompanyDetails WHERE ";
            select_cmd += "Company_Name = @Company_Name AND Profile_Name = @Profile_Name";
            SqlCommand cmd = new SqlCommand(select_cmd, con2);
            string CName = Session["Company_Name"].ToString();
            string ProfileName = Session["Profile_Name"].ToString();

            cmd.Parameters.AddWithValue("@Company_Name", CName);
            cmd.Parameters.AddWithValue("@Profile_Name", ProfileName);

            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);

            Label2.Text = "Welcome " + CName + "\n" + "Your Unique Login ID is : " + dt.Rows[0]["Company_UID"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyLogin.aspx");
        }
    }
}
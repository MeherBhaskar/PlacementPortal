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
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "admin" && TextBox2.Text == "admin")
            {
                Session["GroupID"] = "BOSS";
                Response.Redirect("AdminMMenu.aspx");
            }

            bool flag1 = false;
            bool flag2 = false;

            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            string sql = "SELECT * FROM Groups INNER JOIN StudentDetails ON Admin = RegNo WHERE Admin = @Admin";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Admin", TextBox1.Text);
            connection.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            { //check if the query returns any data 
              //Valid Username and Password 
              //Response.Redirect("Default.aspx");

                Session["GroupID"] = dt.Rows[0]["Group_ID"];
                Response.Redirect("AdminMemberEdit.aspx");
            }
            else
            {
                
            }
            connection.Close();

        }
    }
}
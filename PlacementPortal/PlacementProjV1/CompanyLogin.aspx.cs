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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected bool ValidateUserInfo(string user, string pass)
        {

            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            string sql = "SELECT * FROM CompanyDetails WHERE Company_UID = @Company_UID AND Password = @Password";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Company_UID", user);
            cmd.Parameters.AddWithValue("@Password", pass);
            connection.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            { 
                Session["CompanyName"] = dt.Rows[0]["Company_Name"];
                Session["Company_UID"] = user;
                Label1.Text = "Login Succesful " + Session["CompanyName"].ToString();
                connection.Close();
                return true;
            }

            else
            {
                Label1.Text = "INVALID name and Password, Try Again!";
                connection.Close();
                return false;
            }
            
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            bool ret = ValidateUserInfo(RegNo.Text, Password.Text);
            if(ret == true)
            {
                Response.Redirect("CompanyStudentsList.aspx");
            }
        }
    }
}
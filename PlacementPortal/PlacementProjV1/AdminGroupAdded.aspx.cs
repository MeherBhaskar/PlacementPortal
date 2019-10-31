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
    public partial class WebForm17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["GroupID"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            string insertSQL = "";
            insertSQL += "INSERT INTO Groups ( ";
            insertSQL += "Admin, GroupName, GroupDesc) ";
            insertSQL += "VALUES ( ";
            insertSQL += "@Admin, @GroupName, @GroupDesc)";
            SqlCommand cmd = new SqlCommand(insertSQL, con);

            cmd.Parameters.AddWithValue("@Admin", Session["RegNo"].ToString());
            cmd.Parameters.AddWithValue("@GroupName", Session["GroupName"].ToString());
            cmd.Parameters.AddWithValue("@GroupDesc", Session["GroupDesc"].ToString());
            int added = 0;

            try
            {
                con.Open();
                added = cmd.ExecuteNonQuery();
                if (added > 0)
                {
                    Label2.Text = "Added Successfully";
                }
            }
            catch (Exception err)
            {
                Label2.Text += err.Message;
            }
            finally
            {
                con.Close();
            }

            con = new SqlConnection(connectionString);
            string select_cmd = "SELECT * FROM Groups WHERE ";
            select_cmd += "Admin = @Admin AND GroupName = @GroupName";
            cmd = new SqlCommand(select_cmd, con);
            
            cmd.Parameters.AddWithValue("@Admin", Session["RegNo"].ToString().ToString());
            cmd.Parameters.AddWithValue("@GroupName", Session["GroupName"].ToString());

            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            con.Close();

            Label2.Text = "Your Unique Login ID is : " + dt.Rows[0]["Group_ID"];

            con = new SqlConnection();
            con.ConnectionString = connectionString;
            insertSQL = "";
            insertSQL += "INSERT INTO MemberGroup ( ";
            insertSQL += "RegNo, Group_ID) ";
            insertSQL += "VALUES ( ";
            insertSQL += "@RegNo, @Group_ID)";
            cmd = new SqlCommand(insertSQL, con);

            cmd.Parameters.AddWithValue("@RegNo", Session["RegNo"].ToString());
            cmd.Parameters.AddWithValue("@Group_ID", dt.Rows[0]["Group_ID"]);
            
            added = 0;

            try
            {
                con.Open();
                added = cmd.ExecuteNonQuery();
                if (added > 0)
                {
                    Label2.Text += " ";
                }
            }
            catch (Exception err)
            {
                Label2.Text += err.Message;
            }
            finally
            {
                con.Close();
            }



        }
    }
}
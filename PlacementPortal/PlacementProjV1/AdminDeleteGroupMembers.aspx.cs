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
    public partial class WebForm21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((Session["GroupID"] == null))
                {
                    Response.Redirect("AdminLogin.aspx");

                }

                else
                {
                    string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = connectionString;
                    string sql = "SELECT RegNo FROM MemberGroup where Group_ID=@Group_ID";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Group_ID", Session["GroupID"]);
                    connection.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DropDownList1.Items.Add(new ListItem(dt.Rows[i]["RegNo"].ToString()));
                    }
                    connection.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            string sql = "DELETE FROM MemberGroup WHERE RegNo = @RegNo";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@RegNo", DropDownList1.SelectedItem.Value.ToString());
            int del = cmd.ExecuteNonQuery();
            connection.Close();
            if (del > 0)
            {
                Label2.Text = "Member " + DropDownList1.SelectedItem.Value.ToString() + " deleted succesfully";
            }
        }
    }
}
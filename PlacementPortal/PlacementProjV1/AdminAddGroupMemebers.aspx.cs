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
    public partial class WebForm18 : System.Web.UI.Page
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
                    string sql = "SELECT * FROM StudentDetails";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    connection.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DDL1.Items.Add(new ListItem(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["RegNo"].ToString()));
                    }
                    connection.Close();
                }
            }
        }

        protected void AddMem_Click(object sender, EventArgs e)
        {
            string regNo=DDL1.SelectedValue.ToString();
            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            string insertSQL = "";
            insertSQL += "INSERT INTO MemberGroup ( ";
            insertSQL += "RegNo, Group_ID) ";
            insertSQL += "VALUES ( ";
            insertSQL += "@RegNo, @Group_ID)";
            SqlCommand cmd = new SqlCommand(insertSQL, con);

            cmd.Parameters.AddWithValue("@RegNo", regNo);
            cmd.Parameters.AddWithValue("@Group_ID", Session["GroupID"].ToString());
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
                   
        }
    }
}
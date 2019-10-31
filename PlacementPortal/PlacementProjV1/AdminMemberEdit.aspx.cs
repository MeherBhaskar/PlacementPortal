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
    public partial class WebForm20 : System.Web.UI.Page
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

        protected void Add_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAddGroupMemebers.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDeleteGroupMembers.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminTransferAuthChange.aspx");
        }
    }
}
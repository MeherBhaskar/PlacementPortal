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
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["GroupID"] == null))
            {
                Response.Redirect("AdminLogin.aspx");

            }
            else if (Session["GroupID"].ToString() == "BOSS")
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

                if(!IsPostBack)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DropDownList1.Items.Add(new ListItem(dt.Rows[i]["Name"].ToString(), dt.Rows[i]["RegNo"].ToString()));
                    }
                    connection.Close();
                }
                
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["RegNo"] = DropDownList1.SelectedItem.Value.ToString();
            Session["GroupName"] = TextBox1.Text;
            Session["GroupDesc"] = TextBox2.Text;
            Response.Redirect("AdminGroupAdded.aspx");
        }
    }
}
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
    public partial class WebForm19 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if(!IsPostBack)
            {    
            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            string sql = "SELECT * FROM Groups";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DropDownList1.Items.Add(new ListItem(dt.Rows[i]["GroupName"].ToString(), dt.Rows[i]["Group_ID"].ToString()));
            }
            connection.Close();
        }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            string sql = "DELETE FROM Groups WHERE Group_ID = @Group_ID";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Group_ID", DropDownList1.SelectedItem.Value.ToString());
            int del = cmd.ExecuteNonQuery();
            connection.Close();
            if(del > 0)
            {
                Label2.Text = "Group " + DropDownList1.SelectedItem.Text.ToString() + " deleted succesfully";
            }
        }
    }
}
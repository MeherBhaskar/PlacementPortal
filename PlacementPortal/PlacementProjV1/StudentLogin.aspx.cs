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
    public partial class WebForm3 : System.Web.UI.Page
    {
        HttpCookie studentlogincookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            if (!IsPostBack)
            {
                studentlogincookie = Request.Cookies.Get("Login Credentials");
                if (studentlogincookie != null)
                {
                    studentlogincookie = Request.Cookies.Get("Login Credentials");
                    RegNo.Text = studentlogincookie["RegNo"];
                    Password.Attributes.Add("value", studentlogincookie["Password"]);
                }
            }

        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void ValidateUserInfo(string user, string pass)
        {
            if (CheckBox1.Checked == true)
            {
                studentlogincookie = new HttpCookie("Login Credentials");
                studentlogincookie["RegNo"] = RegNo.Text;
                studentlogincookie["Password"] = Password.Text;
                studentlogincookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(studentlogincookie);
            }
            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            string sql = "SELECT * FROM StudentDetails WHERE RegNo = @RegNo AND Password = @Password";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@RegNo", user);
            cmd.Parameters.AddWithValue("@Password", pass);
            connection.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            { //check if the query returns any data 
              //Valid Username and Password 
              //Response.Redirect("Default.aspx");
                
                Session["StudentName"] = dt.Rows[0]["Name"];
                Session["StudentRegNo"] = dt.Rows[0]["RegNo"];
                Label1.Text = "Login Succesful" + Session["StudentName"].ToString();

                Response.Redirect("StudentMenu.aspx");
            }
            else
            {
                Label1.Text="INVALIDname and Password, Try Again!";
            }
            connection.Close();
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            ValidateUserInfo(RegNo.Text, Password.Text);
        }

        
    }
}
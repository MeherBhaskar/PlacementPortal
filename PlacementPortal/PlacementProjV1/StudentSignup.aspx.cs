using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace PlacementProjV1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        HttpCookie studentlogincookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                studentlogincookie = Request.Cookies.Get("Login Credentials");
                if (studentlogincookie != null)
                {
                    studentlogincookie = Request.Cookies.Get("Login Credentials");
                    studentlogincookie["RegNo"]="";
                    studentlogincookie["Password"]="";
                    Response.Cookies.Add(studentlogincookie);
                }
                Branch.Items.Add(new ListItem("CSE"));
                Branch.Items.Add(new ListItem("IT"));
                Branch.Items.Add(new ListItem("CCE"));
                Branch.Items.Add(new ListItem("ME"));
                Branch.Items.Add(new ListItem("ECE"));
                Branch.Items.Add(new ListItem("BT"));
                Branch.Items.Add(new ListItem("EEE"));
            }

           
           

        }

        protected void SignupBtn_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            string insertSQL = "";
            insertSQL += "INSERT INTO StudentDetails ( ";
            insertSQL += "RegNo, Name, Branch, CGPA, NumberOfBacklogs, Password, Email_ID, PhoneNum) ";
            insertSQL += "VALUES (";
            insertSQL += "@RegNo, @Name, @Branch, @CGPA, @NumberOfBacklogs, @Password, @Email_ID, @PhoneNum)";

            SqlCommand cmd = new SqlCommand(insertSQL, con);
            cmd.Parameters.AddWithValue("@RegNo", RegNo.Text);
            cmd.Parameters.AddWithValue("@Name", Name.Text);
            cmd.Parameters.AddWithValue("@Password", Password.Text);
            cmd.Parameters.AddWithValue("@CGPA", CGPA.Text);
            cmd.Parameters.AddWithValue("@NumberOfBacklogs", NumBacklogs.Text);
            cmd.Parameters.AddWithValue("@Email_ID", Email.Text);
            cmd.Parameters.AddWithValue("@PhoneNum", PhoneNum.Text);
            cmd.Parameters.AddWithValue("@Branch", Branch.Text);
            int added=0;

            try
            {
                con.Open();
                added = cmd.ExecuteNonQuery();
                Response.Redirect("StudentLogin.aspx");
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}
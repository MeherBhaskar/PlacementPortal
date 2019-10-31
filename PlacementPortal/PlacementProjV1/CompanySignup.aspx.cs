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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OfferList.Items.Add(new ListItem("P"));
            OfferList.Items.Add(new ListItem("P+I"));
            OfferList.Items.Add(new ListItem("I"));
        }


        protected void Signup_Click1(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            string insertSQL = "";
            insertSQL += "INSERT INTO CompanyDetails ( ";
            insertSQL += "Company_Name, Location, CGPA, CTC, Num_Backlogs, Password, Tenth_Percentage, Twelth_Percentage, Offer_Type, Profile_Name, DescriptionLink, OT_date, Process_date ) ";
            insertSQL += "VALUES ( ";
            insertSQL += "@Company_Name, @Location, @CGPA, @CTC, @Num_Backlogs, @Password, @Tenth_Percentage, @Twelth_Percentage, @Offer_Type, @Profile_Name, @DescriptionLink, @OT_date, @Process_date )";
            SqlCommand cmd = new SqlCommand(insertSQL, con);
            
            int temp = 0;
            if (Application["Company_Count"] == null)
            {
                temp = 0;
            }
            else
            {
                int.TryParse(Application["Company_Count"].ToString(), out temp);
                temp = temp + 1;
            }

            Application["Company_Count"] = temp.ToString();

            Label1.Text = "STAGE 5" + temp.ToString();
            Label1.Text = "STAGE 5";


            cmd.Parameters.AddWithValue("@Company_Name", CName.Text);
            cmd.Parameters.AddWithValue("@Location", Location.Text);
            cmd.Parameters.AddWithValue("@Password", Password.Text);
            cmd.Parameters.AddWithValue("@CGPA", CGPA.Text);
            cmd.Parameters.AddWithValue("@Num_Backlogs", NumBacks.Text);
            cmd.Parameters.AddWithValue("@CTC", CTC.Text);
            cmd.Parameters.AddWithValue("@Offer_Type", OfferList.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Profile_Name", ProfileName.Text);
            cmd.Parameters.AddWithValue("@Tenth_Percentage", MinTen.Text);
            cmd.Parameters.AddWithValue("@Twelth_Percentage", MinTwelve.Text);
            cmd.Parameters.AddWithValue("@DescriptionLink", DescriptionLink.Text);
            cmd.Parameters.AddWithValue("@OT_date", OT_date.SelectedDate.ToString());
            cmd.Parameters.AddWithValue("@Process_date", Process_date.SelectedDate.ToString());
            int added = 0;
            Label1.Text = "STAGE 6" + temp.ToString();
            
            try
            {
                con.Open();
                Label1.Text = "STAGE 7" + temp.ToString();
                added = cmd.ExecuteNonQuery();
                Label1.Text = "STAGE 8" + temp.ToString();

                Session["Company_Name"] = CName.Text;
                Session["Profile_Name"] = ProfileName.Text;
                Session["Offer_Type"] = OfferList.SelectedItem.Text;

                Response.Redirect("CompanyRegSuccess.aspx");
                
            }
            catch (Exception err)
            {
                Label1.Text += " adsf as " + err.Message;
            }
            finally
            {
                con.Close();
                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlacementProjV1
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

            if (!(Session["CompanyName"] == null))
            {
                //Button1.Visible = true;
                //string cmd;
                string regNo = Request.QueryString["RegNo"];
               // DetailsView1.SelectParameters.Add("@RegNo", regNo);
                
                if (File.Exists(@"c:\Users\MAHE\Documents\" + regNo + ".txt"))
                {
                    Label2.Text = "";
                    Label3.Text = "";
                }

                else
                {
                    Label2.Text = "Resume Not Uploaded Yet!";
                    return;
                }
                string[] str = File.ReadAllLines(@"c:\Users\MAHE\Documents\" + regNo + ".txt");
                foreach(string s in str)
                {
                    Label3.Text = Label3.Text + "<br>" + s;
                }
                // cmd = "SELECT * FROM MemberGroup JOIN Groups ON Group_ID=Group_ID WHERE RegNo= " + regNo;


            }
            else
            {
                Response.Redirect("CompanyHomePage.aspx");
            }
        }
    }
}
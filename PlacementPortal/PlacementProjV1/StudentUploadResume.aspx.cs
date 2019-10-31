using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlacementProjV1
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["StudentName"] == null))
            {
                Button1.Visible = true;
                Response.Redirect("StudentHomePage.aspx");
                // Label1.Text = "Welcome " + Session["StudentName"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                try
                {

                    FileUpload1.SaveAs(@"c:\Users\MAHE\Documents\"+Session["StudentRegNo"].ToString()+".txt");
                    if(File.Exists(@"c:\Users\MAHE\Documents\" + Session["StudentRegNo"].ToString() + ".txt"))
                    {
                        Label2.Text = "Upload succesful";
                    }
                    else
                    {
                        Label2.Text = "Upload unsuccesful";
                    }
                }
                catch(Exception err)
                {
                    Label2.Text = err.Message;
                }
            
        }
    }
}
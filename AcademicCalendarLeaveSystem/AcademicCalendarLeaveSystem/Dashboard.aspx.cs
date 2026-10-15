using System;

namespace AcademicCalendarLeaveSystem
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check whether the user is logged in
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            // Display username
            if (!IsPostBack)
            {
                lblWelcome.Text =
                    Session["Username"].ToString();
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear all session data
            Session.Clear();

            // Remove session completely
            Session.Abandon();

            // Remove username cookie
            if (Request.Cookies["Username"] != null)
            {
                Response.Cookies["Username"].Expires =
                    DateTime.Now.AddDays(-1);
            }

            // Go back to Login page
            Response.Redirect("Login.aspx");
        }
    }
}
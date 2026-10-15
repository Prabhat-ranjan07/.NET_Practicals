using System;

namespace AcademicCalendarLeaveSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["Username"] != null)
                {
                    txtUsername.Text =
                        Request.Cookies["Username"].Value;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                // Create Session
                Session["Username"] = username;

                // Create Cookie
                if (chkRemember.Checked)
                {
                    Response.Cookies["Username"].Value = username;
                    Response.Cookies["Username"].Expires =
                        DateTime.Now.AddDays(7);
                }

                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                lblMessage.Text =
                    "Invalid username or password.";
            }
        }
    }
}
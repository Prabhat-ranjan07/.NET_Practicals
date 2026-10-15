using System;
using System.Data;

namespace AcademicCalendarLeaveSystem
{
    public partial class LeaveHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if user is logged in
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadLeaveHistory();
            }
        }

        private void LoadLeaveHistory()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("LeaveType");
            dt.Columns.Add("FromDate");
            dt.Columns.Add("ToDate");
            dt.Columns.Add("Reason");
            dt.Columns.Add("Status");

            if (Session["LeaveType"] != null)
            {
                DataRow row = dt.NewRow();

                row["LeaveType"] =
                    Session["LeaveType"].ToString();

                row["FromDate"] =
                    Session["FromDate"].ToString();

                row["ToDate"] =
                    Session["ToDate"].ToString();

                row["Reason"] =
                    Session["Reason"].ToString();

                row["Status"] = "Pending";

                dt.Rows.Add(row);
            }

            gvLeaveHistory.DataSource = dt;
            gvLeaveHistory.DataBind();
        }
    }
}
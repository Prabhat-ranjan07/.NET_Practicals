using System;

namespace AcademicCalendarLeaveSystem
{
    public partial class ApplyLeave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check whether user is logged in
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
        }


        // ==========================================
        // APPLY LEAVE BUTTON
        // ==========================================

        protected void btnApply_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                DateTime fromDate;
                DateTime toDate;


                // Check valid dates

                if (!DateTime.TryParse(
                    txtFromDate.Text,
                    out fromDate))
                {
                    return;
                }


                if (!DateTime.TryParse(
                    txtToDate.Text,
                    out toDate))
                {
                    return;
                }


                // Check date order

                if (toDate < fromDate)
                {
                    return;
                }


                // Get username from Session

                string username =
                    Session["Username"].ToString();


                // Get leave details

                string leaveType =
                    ddlLeaveType.SelectedValue;

                string reason =
                    txtReason.Text;


                // Store leave details in Session

                Session["LeaveType"] =
                    leaveType;

                Session["FromDate"] =
                    fromDate.ToString("dd-MM-yyyy");

                Session["ToDate"] =
                    toDate.ToString("dd-MM-yyyy");

                Session["Reason"] =
                    reason;


                // ==================================
                // IMPORTANT PART
                // ==================================

                // Hide the COMPLETE leave form
                pnlLeaveForm.Visible = false;

                // Show success message
                pnlSuccess.Visible = true;
            }
        }


        // ==========================================
        // APPLY ANOTHER LEAVE BUTTON
        // ==========================================

        protected void btnAnotherLeave_Click(
            object sender,
            EventArgs e)
        {
            // Show complete leave form
            pnlLeaveForm.Visible = true;

            // Hide success message
            pnlSuccess.Visible = false;


            // Clear previous values

            ddlLeaveType.SelectedIndex = 0;

            txtFromDate.Text = "";

            txtToDate.Text = "";

            txtReason.Text = "";
        }
    }
}
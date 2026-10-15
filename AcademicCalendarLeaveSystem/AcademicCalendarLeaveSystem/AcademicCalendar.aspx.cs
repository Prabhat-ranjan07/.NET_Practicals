using System;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AcademicCalendarLeaveSystem
{
    public partial class AcademicCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check login session
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
        }

        protected void AcademicCalendarControl_DayRender(
            object sender,
            DayRenderEventArgs e)
        {
            DateTime date = e.Day.Date;

            // Independence Day
            if (date == new DateTime(2026, 8, 15))
            {
                e.Cell.BackColor = Color.LightGreen;

                e.Cell.Controls.Add(
                    new LiteralControl("<br/>Independence Day")
                );
            }

            // Mid Semester Examination
            if (date == new DateTime(2026, 9, 1))
            {
                e.Cell.BackColor = Color.LightBlue;

                e.Cell.Controls.Add(
                    new LiteralControl("<br/>Mid Sem Exam")
                );
            }

            // Gandhi Jayanti
            if (date == new DateTime(2026, 10, 2))
            {
                e.Cell.BackColor = Color.LightYellow;

                e.Cell.Controls.Add(
                    new LiteralControl("<br/>Gandhi Jayanti")
                );
            }

            // End Semester Examination
            if (date == new DateTime(2026, 11, 10))
            {
                e.Cell.BackColor = Color.LightPink;

                e.Cell.Controls.Add(
                    new LiteralControl("<br/>End Sem Exam")
                );
            }

            // Christmas
            if (date == new DateTime(2026, 12, 25))
            {
                e.Cell.BackColor = Color.LightGreen;

                e.Cell.Controls.Add(
                    new LiteralControl("<br/>Christmas")
                );
            }
        }

        protected void AcademicCalendarControl_SelectionChanged(
            object sender,
            EventArgs e)
        {
            lblSelectedDate.Text =
                "Selected Date: " +
                AcademicCalendarControl.SelectedDate.ToString("dd MMMM yyyy");
        }
    }
}
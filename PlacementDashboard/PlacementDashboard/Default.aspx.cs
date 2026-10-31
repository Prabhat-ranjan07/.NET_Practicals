using System;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlacementDashboard.Data;

namespace PlacementDashboard
{
    public partial class _Default : Page
    {
        private readonly StudentDataAccess dataAccess =
            new StudentDataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCompanyDropdown();
                BindStudents();
            }
        }

        // Loads the company filter dropdown.
        private void BindCompanyDropdown()
        {
            DataTable students = dataAccess.GetAllStudents();

            ddlCompany.Items.Clear();

            ddlCompany.Items.Add(
                new ListItem("All Companies", ""));

            ddlCompany.Items.Add(
                new ListItem("Not Placed", "__NOT_PLACED__"));

            var companies = students.AsEnumerable()
                .Where(row => !row.IsNull("CompanyName"))
                .Select(row => row.Field<string>("CompanyName"))
                .Distinct()
                .OrderBy(company => company);

            foreach (string company in companies)
            {
                ddlCompany.Items.Add(
                    new ListItem(company, company));
            }
        }

        // Calculates dashboard statistics and displays student records.
        private void BindStudents()
        {
            DataTable students = dataAccess.GetAllStudents();

            int totalStudents = students.Rows.Count;

            int placedStudents = students.AsEnumerable()
                .Count(row =>
                    row.Field<string>("PlacementStatus") == "Placed");

            int unplacedStudents =
                totalStudents - placedStudents;

            double placementPercentage = totalStudents > 0
                ? (double)placedStudents * 100 / totalStudents
                : 0;

            lblTotalStudents.Text = totalStudents.ToString();
            lblPlacedStudents.Text = placedStudents.ToString();
            lblUnplacedStudents.Text = unplacedStudents.ToString();

            lblPlacementPercentage.Text =
                placementPercentage.ToString("0.00") + "%";

            string selectedCompany = ddlCompany.SelectedValue;

            DataView view = students.DefaultView;

            if (selectedCompany == "__NOT_PLACED__")
            {
                view.RowFilter = "PlacementStatus = 'Not Placed'";
            }
            else if (!string.IsNullOrEmpty(selectedCompany))
            {
                string safeCompany = selectedCompany.Replace("'", "''");

                view.RowFilter = "CompanyName = '" + safeCompany + "'";
            }
            else
            {
                view.RowFilter = "";
            }

            gvStudents.DataSource = view;
            gvStudents.DataBind();
        }

        // Runs when the company dropdown selection changes.
        protected void ddlCompany_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            BindStudents();
        }

        // Resets the filter and displays every student.
        protected void btnRefresh_Click(
            object sender, EventArgs e)
        {
            ddlCompany.SelectedValue = "";
            BindStudents();
        }
    }
}
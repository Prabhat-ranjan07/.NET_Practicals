using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PlacementDashboard.Data
{
    public class StudentDataAccess
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings[
                "PlacementConnection"
            ].ConnectionString;

        public DataTable GetAllStudents()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT StudentId,
                           StudentName,
                           Branch,
                           CGPA,
                           CompanyName,
                           JobRole,
                           PackageLPA,
                           PlacementStatus
                    FROM dbo.Students
                    ORDER BY StudentId";

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }
    }
}
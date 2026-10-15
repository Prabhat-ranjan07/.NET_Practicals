<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="LeaveHistory.aspx.cs"
    Inherits="AcademicCalendarLeaveSystem.LeaveHistory" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <title>Leave History</title>

    <style>

        body {
            margin: 0;
            font-family: Arial, sans-serif;
            background: #f4f6f9;
        }

        .navbar {
            background: #1e3a8a;
            color: white;
            padding: 18px 30px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .navbar h2 {
            margin: 0;
        }

        .back {
            color: white;
            text-decoration: none;
        }

        .container {
            width: 90%;
            max-width: 1000px;
            margin: 40px auto;
        }

        .card {
            background: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 3px 10px rgba(0,0,0,0.1);
        }

        .card h2 {
            margin-top: 0;
            color: #222;
        }

        .subtitle {
            color: #666;
            margin-bottom: 25px;
        }

        /* GridView */

        .grid {
            width: 100%;
            border-collapse: collapse;
        }

        .grid th {
            background: #2563eb;
            color: white;
            padding: 14px;
            text-align: left;
        }

        .grid td {
            padding: 14px;
            border-bottom: 1px solid #ddd;
        }

        .grid tr:hover {
            background: #f5f7ff;
        }

        .status {
            color: #d97706;
            font-weight: bold;
        }

        .no-data {
            text-align: center;
            padding: 40px;
            color: #777;
        }

        .apply-btn {
            display: inline-block;
            margin-top: 25px;
            padding: 12px 25px;
            background: #2563eb;
            color: white;
            text-decoration: none;
            border-radius: 5px;
        }

        .apply-btn:hover {
            background: #1d4ed8;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

    <!-- NAVBAR -->

    <div class="navbar">

        <h2>Leave Management</h2>

        <a href="Dashboard.aspx" class="back">
            ← Dashboard
        </a>

    </div>


    <!-- MAIN CONTENT -->

    <div class="container">

        <div class="card">

            <h2>Leave History</h2>

            <p class="subtitle">
                View your submitted leave applications.
            </p>


            <!-- GRIDVIEW -->

            <asp:GridView
                ID="gvLeaveHistory"
                runat="server"
                AutoGenerateColumns="False"
                CssClass="grid"
                EmptyDataText="No leave applications found."
                GridLines="None">

                <Columns>

                    <asp:BoundField
                        DataField="LeaveType"
                        HeaderText="Leave Type" />

                    <asp:BoundField
                        DataField="FromDate"
                        HeaderText="From Date" />

                    <asp:BoundField
                        DataField="ToDate"
                        HeaderText="To Date" />

                    <asp:BoundField
                        DataField="Reason"
                        HeaderText="Reason" />

                    <asp:BoundField
                        DataField="Status"
                        HeaderText="Status" />

                </Columns>

            </asp:GridView>


            <!-- APPLY NEW LEAVE -->

            <a href="ApplyLeave.aspx"
               class="apply-btn">
                + Apply New Leave
            </a>

        </div>

    </div>

</form>

</body>
</html>
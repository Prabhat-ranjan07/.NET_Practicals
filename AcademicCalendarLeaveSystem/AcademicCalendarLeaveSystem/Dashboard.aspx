<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Dashboard.aspx.cs"
    Inherits="AcademicCalendarLeaveSystem.Dashboard" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <title>Dashboard</title>

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

        .container {
            width: 90%;
            margin: 40px auto;
        }

        .welcome {
            background: white;
            padding: 25px;
            border-radius: 10px;
            margin-bottom: 30px;
            box-shadow: 0 3px 10px rgba(0,0,0,0.1);
        }

        .cards {
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            gap: 20px;
        }

        .card {
            background: white;
            padding: 30px;
            border-radius: 10px;
            text-align: center;
            box-shadow: 0 3px 10px rgba(0,0,0,0.1);
        }

        .card h3 {
            margin-bottom: 15px;
        }

        .btn {
            display: inline-block;
            padding: 10px 20px;
            background: #2563eb;
            color: white;
            text-decoration: none;
            border-radius: 5px;
        }

        .logout {
            color: white;
            text-decoration: none;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

    <div class="navbar">

        <h2>Academic Calendar & Leave Management</h2>

      <asp:Button
    ID="btnLogout"
    runat="server"
    Text="Logout"
    OnClick="btnLogout_Click" />

    </div>

    <div class="container">

        <div class="welcome">

            <h2>
                Welcome,
                <asp:Label ID="lblWelcome"
                    runat="server">
                </asp:Label>
            </h2>

            <p>
                Welcome to the Academic Calendar and
                Leave Management System.
            </p>

        </div>

        <div class="cards">

            <div class="card">

                <h3>Academic Calendar</h3>

                <p>
                    View academic events, holidays and
                    examination dates.
                </p>

                <a href="AcademicCalendar.aspx"
                   class="btn">
                    View Calendar
                </a>

            </div>


            <div class="card">

                <h3>Apply Leave</h3>

                <p>
                    Apply for leave by providing
                    the required details.
                </p>

                <a href="ApplyLeave.aspx"
                   class="btn">
                    Apply Leave
                </a>

            </div>


            <div class="card">

                <h3>Leave History</h3>

                <p>
                    View your previous leave applications
                    and their status.
                </p>

                <a href="LeaveHistory.aspx"
                   class="btn">
                    View History
                </a>

            </div>

        </div>

    </div>

</form>

</body>
</html>
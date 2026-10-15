<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="AcademicCalendar.aspx.cs"
    Inherits="AcademicCalendarLeaveSystem.AcademicCalendar" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <title>Academic Calendar</title>

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
            margin: 35px auto;
        }

        .calendar-box {
            background: white;
            padding: 25px;
            border-radius: 10px;
            box-shadow: 0 3px 10px rgba(0,0,0,0.1);
        }

        .calendar-title {
            text-align: center;
            margin-bottom: 25px;
        }

        .event-box {
            margin-top: 25px;
            padding: 20px;
            background: #f8fafc;
            border-radius: 8px;
        }

        .event-box h3 {
            margin-top: 0;
        }

        .event {
            padding: 10px;
            margin: 8px 0;
            background: white;
            border-left: 4px solid #2563eb;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

    <div class="navbar">

        <h2>Academic Calendar</h2>

        <a href="Dashboard.aspx" class="back">
            ← Dashboard
        </a>

    </div>


    <div class="container">

        <div class="calendar-box">

            <div class="calendar-title">

                <h2>Academic Calendar 2026</h2>

                <p>
                    View important academic dates and holidays
                </p>

            </div>


            <!-- ASP.NET CALENDAR RICH CONTROL -->

            <asp:Calendar
                ID="AcademicCalendarControl"
                runat="server"
                Width="100%"
                Height="400px"
                BackColor="White"
                BorderColor="#999999"
                CellPadding="5"
                DayNameFormat="Short"
                Font-Names="Arial"
                Font-Size="10pt"
                ForeColor="Black"
                ShowGridLines="True"
                OnDayRender="AcademicCalendarControl_DayRender"
                OnSelectionChanged="AcademicCalendarControl_SelectionChanged">

                <SelectedDayStyle
                    BackColor="#2563eb"
                    Font-Bold="True"
                    ForeColor="White" />

                <TodayDayStyle
                    BackColor="#e5e7eb"
                    ForeColor="Black" />

                <WeekendDayStyle
                    BackColor="#f8fafc" />

                <TitleStyle
                    BackColor="#1e3a8a"
                    Font-Bold="True"
                    Font-Size="14pt"
                    ForeColor="White" />

                <NextPrevStyle
                    Font-Size="9pt"
                    ForeColor="White" />

                <DayHeaderStyle
                    BackColor="#e5e7eb"
                    Font-Bold="True" />

            </asp:Calendar>


            <!-- SELECTED DATE -->

            <div class="event-box">

                <h3>Selected Date</h3>

                <asp:Label
                    ID="lblSelectedDate"
                    runat="server"
                    Text="Select a date from the calendar.">
                </asp:Label>

            </div>


            <!-- ACADEMIC EVENTS -->

            <div class="event-box">

                <h3>Important Academic Events</h3>

                <div class="event">
                    <strong>15 August 2026</strong>
                    - Independence Day
                </div>

                <div class="event">
                    <strong>1 September 2026</strong>
                    - Mid Semester Examination
                </div>

                <div class="event">
                    <strong>2 October 2026</strong>
                    - Gandhi Jayanti
                </div>

                <div class="event">
                    <strong>10 November 2026</strong>
                    - End Semester Examination
                </div>

                <div class="event">
                    <strong>25 December 2026</strong>
                    - Christmas Holiday
                </div>

            </div>

        </div>

    </div>

</form>

</body>
</html>
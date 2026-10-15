<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ApplyLeave.aspx.cs"
    Inherits="AcademicCalendarLeaveSystem.ApplyLeave" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <title>Apply Leave</title>

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
            width: 500px;
            margin: 40px auto;
        }

        .form-box {
            background: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 3px 10px rgba(0,0,0,0.1);
        }

        .form-group {
            margin-bottom: 18px;
        }

        .form-group label {
            display: block;
            margin-bottom: 6px;
            font-weight: bold;
        }

        .input {
            width: 100%;
            padding: 10px;
            box-sizing: border-box;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .btn {
            width: 100%;
            padding: 12px;
            background: #2563eb;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 15px;
        }

        .btn:hover {
            background: #1d4ed8;
        }

        .error {
            color: red;
            font-size: 13px;
            display: block;
            margin-top: 5px;
        }

        /* SUCCESS MESSAGE */

        .success-box {
            text-align: center;
            padding: 30px 20px;
        }

        .success-icon {
            width: 65px;
            height: 65px;
            line-height: 65px;
            margin: 0 auto 15px;
            border-radius: 50%;
            background: #22c55e;
            color: white;
            font-size: 35px;
            font-weight: bold;
        }

        .success-box h2 {
            color: #16a34a;
            margin-bottom: 10px;
        }

        .success-box p {
            color: #555;
            margin-bottom: 25px;
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


    <!-- MAIN CONTAINER -->

    <div class="container">

        <div class="form-box">


            <!-- ================================= -->
            <!-- LEAVE FORM -->
            <!-- ================================= -->

            <asp:Panel
                ID="pnlLeaveForm"
                runat="server">

                <h2>Apply for Leave</h2>

                <p>
                    Apply for leave by entering the required details.
                </p>


                <!-- LEAVE TYPE -->

                <div class="form-group">

                    <label>Leave Type</label>

                    <asp:DropDownList
                        ID="ddlLeaveType"
                        runat="server"
                        CssClass="input">

                        <asp:ListItem
                            Text="-- Select Leave Type --"
                            Value="">
                        </asp:ListItem>

                        <asp:ListItem
                            Text="Casual Leave"
                            Value="Casual Leave">
                        </asp:ListItem>

                        <asp:ListItem
                            Text="Sick Leave"
                            Value="Sick Leave">
                        </asp:ListItem>

                        <asp:ListItem
                            Text="Emergency Leave"
                            Value="Emergency Leave">
                        </asp:ListItem>

                        <asp:ListItem
                            Text="Other"
                            Value="Other">
                        </asp:ListItem>

                    </asp:DropDownList>


                    <asp:RequiredFieldValidator
                        ID="rfvLeaveType"
                        runat="server"
                        ControlToValidate="ddlLeaveType"
                        InitialValue=""
                        ErrorMessage="Please select leave type."
                        CssClass="error">
                    </asp:RequiredFieldValidator>

                </div>


                <!-- FROM DATE -->

                <div class="form-group">

                    <label>From Date</label>

                    <asp:TextBox
                        ID="txtFromDate"
                        runat="server"
                        TextMode="Date"
                        CssClass="input">
                    </asp:TextBox>


                    <asp:RequiredFieldValidator
                        ID="rfvFromDate"
                        runat="server"
                        ControlToValidate="txtFromDate"
                        ErrorMessage="Please select starting date."
                        CssClass="error">
                    </asp:RequiredFieldValidator>

                </div>


                <!-- TO DATE -->

                <div class="form-group">

                    <label>To Date</label>

                    <asp:TextBox
                        ID="txtToDate"
                        runat="server"
                        TextMode="Date"
                        CssClass="input">
                    </asp:TextBox>


                    <asp:RequiredFieldValidator
                        ID="rfvToDate"
                        runat="server"
                        ControlToValidate="txtToDate"
                        ErrorMessage="Please select ending date."
                        CssClass="error">
                    </asp:RequiredFieldValidator>

                </div>


                <!-- REASON -->

                <div class="form-group">

                    <label>Reason</label>

                    <asp:TextBox
                        ID="txtReason"
                        runat="server"
                        TextMode="MultiLine"
                        Rows="4"
                        CssClass="input">
                    </asp:TextBox>


                    <asp:RequiredFieldValidator
                        ID="rfvReason"
                        runat="server"
                        ControlToValidate="txtReason"
                        ErrorMessage="Please enter reason."
                        CssClass="error">
                    </asp:RequiredFieldValidator>

                </div>


                <!-- APPLY BUTTON -->

                <asp:Button
                    ID="btnApply"
                    runat="server"
                    Text="Apply Leave"
                    CssClass="btn"
                    OnClick="btnApply_Click" />

            </asp:Panel>


            <!-- ================================= -->
            <!-- SUCCESS MESSAGE -->
            <!-- ================================= -->

            <asp:Panel
                ID="pnlSuccess"
                runat="server"
                Visible="false"
                CssClass="success-box">

                <div class="success-icon">
                    ✓
                </div>

                <h2>
                    Leave Applied Successfully!
                </h2>

                <p>
                    Your leave application has been submitted successfully.
                </p>


                <!-- APPLY ANOTHER LEAVE -->

                <asp:Button
                    ID="btnAnotherLeave"
                    runat="server"
                    Text="Apply Another Leave"
                    CssClass="btn"
                    OnClick="btnAnotherLeave_Click" />

            </asp:Panel>


        </div>

    </div>

</form>

</body>
</html>
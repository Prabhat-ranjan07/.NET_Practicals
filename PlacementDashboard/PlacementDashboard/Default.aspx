<%@ Page Title="Placement Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PlacementDashboard._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .dashboard-container {
            padding: 25px 10px;
        }

        .dashboard-title {
            font-size: 30px;
            font-weight: bold;
            margin-bottom: 8px;
            color: #1e293b;
        }

        .dashboard-subtitle {
            color: #64748b;
            margin-bottom: 25px;
        }

        .stat-card {
            background: #ffffff;
            border-radius: 12px;
            padding: 22px;
            margin-bottom: 20px;
            box-shadow: 0 3px 12px rgba(0, 0, 0, 0.08);
            border-left: 5px solid #2563eb;
            min-height: 125px;
        }

        .stat-label {
            display: block;
            color: #64748b;
            font-size: 15px;
            margin-bottom: 10px;
        }

        .stat-value {
            display: block;
            color: #0f172a;
            font-size: 30px;
            font-weight: bold;
        }

        .filter-panel {
            background: #ffffff;
            padding: 20px;
            border-radius: 12px;
            margin: 10px 0 25px 0;
            box-shadow: 0 3px 12px rgba(0, 0, 0, 0.06);
        }

        .section-title {
            font-size: 21px;
            font-weight: bold;
            color: #1e293b;
            margin: 20px 0 15px 0;
        }

        .table-container {
            overflow-x: auto;
            background: #ffffff;
            border-radius: 10px;
            padding: 10px;
            box-shadow: 0 3px 12px rgba(0, 0, 0, 0.06);
        }

        .student-table {
            width: 100%;
            border-collapse: collapse;
        }

        .student-table th {
            background: #1d4ed8;
            color: white;
            padding: 12px;
            text-align: left;
            white-space: nowrap;
        }

        .student-table td {
            padding: 11px;
            border-bottom: 1px solid #e2e8f0;
            color: #334155;
        }

        .student-table tr:hover td {
            background: #f1f5f9;
        }

        .filter-label {
            display: block;
            font-weight: bold;
            margin-bottom: 8px;
        }

        @media (max-width: 768px) {
            .dashboard-title {
                font-size: 24px;
            }
        }
    </style>

    <div class="container-fluid dashboard-container">

        <h1 class="dashboard-title">Student Placement Dashboard</h1>

        <p class="dashboard-subtitle">
            Monitor student placement statistics, companies, and placement records.
        </p>

        <!-- Dashboard statistics -->
        <div class="row">

            <div class="col-md-3 col-sm-6">
                <div class="stat-card">
                    <span class="stat-label">Total Students</span>
                    <asp:Label
                        ID="lblTotalStudents"
                        runat="server"
                        CssClass="stat-value"
                        Text="0" />
                </div>
            </div>

            <div class="col-md-3 col-sm-6">
                <div class="stat-card" style="border-left-color: #16a34a;">
                    <span class="stat-label">Placed Students</span>
                    <asp:Label
                        ID="lblPlacedStudents"
                        runat="server"
                        CssClass="stat-value"
                        Text="0" />
                </div>
            </div>

            <div class="col-md-3 col-sm-6">
                <div class="stat-card" style="border-left-color: #dc2626;">
                    <span class="stat-label">Not Placed</span>
                    <asp:Label
                        ID="lblUnplacedStudents"
                        runat="server"
                        CssClass="stat-value"
                        Text="0" />
                </div>
            </div>

            <div class="col-md-3 col-sm-6">
                <div class="stat-card" style="border-left-color: #9333ea;">
                    <span class="stat-label">Placement Percentage</span>
                    <asp:Label
                        ID="lblPlacementPercentage"
                        runat="server"
                        CssClass="stat-value"
                        Text="0.00%" />
                </div>
            </div>

        </div>

        <!-- Company filter -->
        <div class="filter-panel">

            <h3 class="section-title" style="margin-top: 0;">
                Filter Placement Records
            </h3>

            <div class="row">

                <div class="col-md-6 col-sm-8">
                    <label class="filter-label" for="<%= ddlCompany.ClientID %>">
                        Select Company or Placement Status
                    </label>

                    <asp:DropDownList
                        ID="ddlCompany"
                        runat="server"
                        CssClass="form-control"
                        AutoPostBack="true"
                        OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>

                <div class="col-md-3 col-sm-4" style="padding-top: 26px;">
                    <asp:Button
                        ID="btnRefresh"
                        runat="server"
                        Text="Show All Students"
                        CssClass="btn btn-primary"
                        OnClick="btnRefresh_Click" />
                </div>

            </div>

        </div>

        <!-- Student data table -->
        <h3 class="section-title">Student Placement Records</h3>

        <div class="table-container">

            <asp:GridView
                ID="gvStudents"
                runat="server"
                AutoGenerateColumns="False"
                CssClass="student-table"
                GridLines="None"
                EmptyDataText="No student records found."
                Width="100%">

                <Columns>

                    <asp:BoundField
                        DataField="StudentId"
                        HeaderText="Student ID" />

                    <asp:BoundField
                        DataField="StudentName"
                        HeaderText="Student Name" />

                    <asp:BoundField
                        DataField="Branch"
                        HeaderText="Branch" />

                    <asp:BoundField
                        DataField="CGPA"
                        HeaderText="CGPA"
                        DataFormatString="{0:0.00}" />

                    <asp:BoundField
                        DataField="CompanyName"
                        HeaderText="Company" />

                    <asp:BoundField
                        DataField="JobRole"
                        HeaderText="Job Role" />

                    <asp:BoundField
                        DataField="PackageLPA"
                        HeaderText="Package (LPA)"
                        DataFormatString="{0:0.00}" />

                    <asp:BoundField
                        DataField="PlacementStatus"
                        HeaderText="Placement Status" />

                </Columns>

            </asp:GridView>

        </div>

    </div>

</asp:Content>
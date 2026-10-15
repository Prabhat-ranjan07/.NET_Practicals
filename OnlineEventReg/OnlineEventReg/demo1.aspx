<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="demo1.aspx.cs"
    Inherits="OnlineEventReg.demo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Online Event Registration</title>
</head>

<body>

<form id="form1" runat="server">

<div>

    <h2>Online Event Registration</h2>

    <table>

        <!-- Full Name -->
        <tr>
            <td>
                <asp:Label ID="Label1"
                    runat="server"
                    Text="Full Name">
                </asp:Label>
            </td>

            <td>
                <asp:TextBox ID="TextBox1"
                    runat="server"
                    Width="200px">
                </asp:TextBox>
            </td>
        </tr>


        <!-- Email -->
        <tr>
            <td>
                <asp:Label ID="Label2"
                    runat="server"
                    Text="Email Id">
                </asp:Label>
            </td>

            <td>
                <asp:TextBox ID="TextBox2"
                    runat="server"
                    Width="200px">
                </asp:TextBox>
            </td>
        </tr>


        <!-- Contact -->
        <tr>
            <td>
                <asp:Label ID="Label3"
                    runat="server"
                    Text="Contact No.">
                </asp:Label>
            </td>

            <td>
                <asp:TextBox ID="TextBox3"
                    runat="server"
                    Width="200px">
                </asp:TextBox>
            </td>
        </tr>


        <!-- College -->
        <tr>
            <td>
                <asp:Label ID="Label4"
                    runat="server"
                    Text="College">
                </asp:Label>
            </td>

            <td>
                <asp:TextBox ID="TextBox4"
                    runat="server"
                    Width="200px">
                </asp:TextBox>
            </td>
        </tr>


        <!-- Department -->
        <tr>
            <td>
                <asp:Label ID="Label5"
                    runat="server"
                    Text="Department">
                </asp:Label>
            </td>

            <td>

                <asp:RadioButton ID="RadioButton1"
                    runat="server"
                    Text="Computer"
                    GroupName="Department" />

                <br />

                <asp:RadioButton ID="RadioButton2"
                    runat="server"
                    Text="Mechanical"
                    GroupName="Department" />

                <br />

                <asp:RadioButton ID="RadioButton3"
                    runat="server"
                    Text="Chemical"
                    GroupName="Department" />

                <br />

                <asp:RadioButton ID="RadioButton4"
                    runat="server"
                    Text="Civil"
                    GroupName="Department" />

            </td>
        </tr>


        <!-- Event -->
        <tr>
            <td>
                <asp:Label ID="Label6"
                    runat="server"
                    Text="Event">
                </asp:Label>
            </td>

            <td>

                <select id="Select1" runat="server">

                    <option value="">
                        -Select Event-
                    </option>

                    <option value="Hackathon">
                        Hackathon
                    </option>

                    <option value="Workshop">
                        Workshop
                    </option>

                    <option value="Quiz">
                        Quiz
                    </option>

                </select>

            </td>
        </tr>


        <!-- Gender -->
        <tr>
            <td>
                <asp:Label ID="Label7"
                    runat="server"
                    Text="Gender">
                </asp:Label>
            </td>

            <td>

                <asp:RadioButton ID="RadioButton5"
                    runat="server"
                    Text="Male"
                    GroupName="Gender" />

                <br />

                <asp:RadioButton ID="RadioButton6"
                    runat="server"
                    Text="Female"
                    GroupName="Gender" />

            </td>
        </tr>


        <!-- Skills -->
        <tr>
            <td>
                <asp:Label ID="Label8"
                    runat="server"
                    Text="Skills">
                </asp:Label>
            </td>

            <td>

                <asp:CheckBox ID="CheckBox1"
                    runat="server"
                    Text="C#" />

                <asp:CheckBox ID="CheckBox2"
                    runat="server"
                    Text="Python" />

                <asp:CheckBox ID="CheckBox3"
                    runat="server"
                    Text="AI" />

                <asp:CheckBox ID="CheckBox4"
                    runat="server"
                    Text="Java" />

                <asp:CheckBox ID="CheckBox5"
                    runat="server"
                    Text="C++" />

            </td>
        </tr>


        <!-- Address -->
        <tr>
            <td>
                <asp:Label ID="Label9"
                    runat="server"
                    Text="Address">
                </asp:Label>
            </td>

            <td>

                <textarea
                    id="TextArea1"
                    runat="server"
                    cols="25"
                    rows="4">
                </textarea>

            </td>
        </tr>


        <!-- Terms -->
        <tr>
            <td>
                <asp:Label ID="Label10"
                    runat="server"
                    Text="Terms">
                </asp:Label>
            </td>

            <td>

                <asp:CheckBox ID="CheckBox6"
                    runat="server"
                    Text="I accept Terms & Conditions" />

            </td>
        </tr>


        <!-- Buttons -->
        <tr>
            <td></td>

            <td>

                <asp:Button ID="Button1"
                    runat="server"
                    Text="Submit"
                    OnClick="Button1_Click" />

                &nbsp;&nbsp;

                <asp:Button ID="Button2"
                    runat="server"
                    Text="Clear"
                    CausesValidation="false"
                    OnClick="Button2_Click" />

            </td>
        </tr>

    </table>

</div>

</form>

</body>
</html>
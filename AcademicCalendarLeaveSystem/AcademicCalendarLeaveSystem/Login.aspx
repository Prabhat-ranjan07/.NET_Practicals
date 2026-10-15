<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AcademicCalendarLeaveSystem.Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Login - Academic Calendar</title>

    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: Arial;
            background: #f2f4f7;
        }

        .login-container {
            width: 400px;
            margin: 100px auto;
            background: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 15px rgba(0,0,0,0.15);
        }

        h2 {
            text-align: center;
            margin-bottom: 25px;
        }

        .input {
            width: 100%;
            padding: 10px;
            margin-top: 6px;
            margin-bottom: 15px;
            box-sizing: border-box;
        }

        .btn {
            width: 100%;
            padding: 11px;
            background: #2563eb;
            color: white;
            border: none;
            cursor: pointer;
            border-radius: 5px;
        }

        .message {
            color: red;
            text-align: center;
        }
    </style>
</head>

<body>

<form id="form1" runat="server">

    <div class="login-container">

        <h2>Academic Calendar</h2>

        <asp:Label ID="lblUsername" runat="server"
            Text="Username"></asp:Label>

        <asp:TextBox ID="txtUsername"
            runat="server"
            CssClass="input">
        </asp:TextBox>

        <asp:Label ID="lblPassword" runat="server"
            Text="Password"></asp:Label>

        <asp:TextBox ID="txtPassword"
            runat="server"
            TextMode="Password"
            CssClass="input">
        </asp:TextBox>

        <asp:CheckBox ID="chkRemember"
            runat="server"
            Text=" Remember Me" />

        <br /><br />

        <asp:Button ID="btnLogin"
            runat="server"
            Text="Login"
            CssClass="btn"
            OnClick="btnLogin_Click" />

        <br /><br />

        <asp:Label ID="lblMessage"
            runat="server"
            CssClass="message">
        </asp:Label>

    </div>

</form>

</body>
</html>

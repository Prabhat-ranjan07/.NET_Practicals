using System;
using System.Text.RegularExpressions;

namespace OnlineEventReg
{
    public partial class demo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                errorMessage += "Full Name is required.\\n";
            }

            if (string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                errorMessage += "Email is required.\\n";
            }
            else if (!Regex.IsMatch(
                TextBox2.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage += "Enter a valid Email ID.\\n";
            }

            if (string.IsNullOrWhiteSpace(TextBox3.Text))
            {
                errorMessage += "Contact Number is required.\\n";
            }
            else if (!Regex.IsMatch(
                TextBox3.Text,
                @"^[0-9]{10}$"))
            {
                errorMessage +=
                    "Contact Number must contain exactly 10 digits.\\n";
            }

            if (string.IsNullOrWhiteSpace(TextBox4.Text))
            {
                errorMessage += "College name is required.\\n";
            }

            if (!RadioButton1.Checked &&
                !RadioButton2.Checked &&
                !RadioButton3.Checked &&
                !RadioButton4.Checked)
            {
                errorMessage +=
                    "Please select a Department.\\n";
            }
            if (Select1.Value == "")
            {
                errorMessage +=
                    "Please select an Event.\\n";
            }

            if (!RadioButton5.Checked &&
                !RadioButton6.Checked)
            {
                errorMessage +=
                    "Please select Gender.\\n";
            }

            if (string.IsNullOrWhiteSpace(TextArea1.Value))
            {
                errorMessage +=
                    "Address is required.\\n";
            }

            if (!CheckBox6.Checked)
            {
                errorMessage +=
                    "Please accept Terms & Conditions.\\n";
            }


            if (errorMessage != "")
            {
                ClientScript.RegisterStartupScript(
                    this.GetType(),
                    "Validation",
                    "alert('" + errorMessage + "');",
                    true
                );

                return;
            }



            string department = "";

            if (RadioButton1.Checked)
            {
                department = "Computer";
            }
            else if (RadioButton2.Checked)
            {
                department = "Mechanical";
            }
            else if (RadioButton3.Checked)
            {
                department = "Chemical";
            }
            else if (RadioButton4.Checked)
            {
                department = "Civil";
            }

            string gender = "";

            if (RadioButton5.Checked)
            {
                gender = "Male";
            }
            else if (RadioButton6.Checked)
            {
                gender = "Female";
            }


            string skills = "";

            if (CheckBox1.Checked)
            {
                skills += "C#, ";
            }

            if (CheckBox2.Checked)
            {
                skills += "Python, ";
            }

            if (CheckBox3.Checked)
            {
                skills += "AI, ";
            }

            if (CheckBox4.Checked)
            {
                skills += "Java, ";
            }

            if (CheckBox5.Checked)
            {
                skills += "C++, ";
            }

            if (skills.EndsWith(", "))
            {
                skills = skills.Substring(
                    0,
                    skills.Length - 2
                );
            }

            string message =
                "Registration Successful!\\n\\n" +
                "Name: " + TextBox1.Text + "\\n" +
                "Email: " + TextBox2.Text + "\\n" +
                "Contact: " + TextBox3.Text + "\\n" +
                "College: " + TextBox4.Text + "\\n" +
                "Department: " + department + "\\n" +
                "Event: " + Select1.Value + "\\n" +
                "Gender: " + gender + "\\n" +
                "Skills: " + skills;

            ClientScript.RegisterStartupScript(
                this.GetType(),
                "Success",
                "alert('" + message + "');",
                true
            );
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Clear TextBoxes

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";


            // Clear Department

            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;


            // Clear Event

            Select1.SelectedIndex = 0;


            // Clear Gender

            RadioButton5.Checked = false;
            RadioButton6.Checked = false;


            // Clear Skills

            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;


            // Clear Address

            TextArea1.Value = "";


            // Clear Terms

            CheckBox6.Checked = false;
        }
    }
}
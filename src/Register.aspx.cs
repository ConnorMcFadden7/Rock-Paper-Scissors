using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

public partial class Register : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /** Registers the user */
    protected void Register_Click(object sender, EventArgs e)
    {
        /** Checks if the user has filled in their details */
        if (UsernameText.Text == "" && DOBText.Text == "")
        {
            UsernameEmpty.Text = "Please enter a username.";
            DOBEmpty.Text = "Please enter your date of birth.";
        }
        else if (UsernameText.Text == "")
        {
            UsernameEmpty.Text = "Please enter a username.";
        }
        else if (DOBText.Text == "")
        {
            DOBEmpty.Text = "Please enter your date of birth.";
        }     
        else
        {
            DOBValidation();
            /** Insert the user details into the database */
            try
            {
                SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                dbConnection.Open();
                /** Query the database */
                SqlCommand registerCommand = new SqlCommand("insert into Users (Username,DOB) values (@username ,@dob)", dbConnection);
                registerCommand.Parameters.AddWithValue("@username", UsernameText.Text);
                registerCommand.Parameters.AddWithValue("@dob", DOBText.Text);
                registerCommand.ExecuteNonQuery();
                /** Redirect to login page after details have been registered */
                Response.Redirect("MainPage.aspx");

                dbConnection.Close();
            }
            catch (Exception ex)
            {
                //Response.Write("Error: " + ex.ToString());
            }
        }
       

    }
    /** Redirect to the login page without registering details */
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPage.aspx");
    }

    /** Test is the date of birth is correct */
    protected void DOBValidation()
    { 
        try
        {
            DateTime checkDob = new DateTime();
            checkDob = DateTime.Parse(DOBText.Text);
            if (checkDob.Month > 12 || checkDob.Day > 31)
            {
                DOBIncorrect.Text = "Invalid Date of birth, format should be (MM/DD/YYYY)";
            }
            else
            {
                //Do nothing
            }
        }
        catch (Exception ex)
        {
            DOBIncorrect.Text = "Invalid Date of birth, format should be (MM/DD/YYYY)";
        }
        
    }
}
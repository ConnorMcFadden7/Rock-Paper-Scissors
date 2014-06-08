using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Default : System.Web.UI.Page
{
    /** On page load start a Session with what the User enters to login */
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Statistics"] = UsernameLogin.Text;
    }

    /** Check the database to see if the username which is entered exists */
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        string user = UsernameLogin.Text;
        try
        {
            SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            dbConnection.Open();
            /** Query the database */
            SqlCommand usernameCommand = new SqlCommand("select * from Users where Username = @user", dbConnection);
            usernameCommand.Parameters.Add("@user", SqlDbType.VarChar);
            usernameCommand.Parameters["@user"].Value = user;
            /** Compare the username entered with every username in the database */
            SqlDataReader readUsername = usernameCommand.ExecuteReader();
            if (readUsername.Read())
            {
                 Response.Redirect("Game.aspx");
            } 
            else 
            {
                /** Inform the username that the user entered doesn't exist */
                 UserDoesntExist.Text = "User doesn't exist! Please enter a correct username.";
            }
            dbConnection.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.ToString());
        }
        
    }
    /** Redirect to Register page */
    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}
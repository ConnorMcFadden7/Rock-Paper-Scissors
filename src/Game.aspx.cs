using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Game : System.Web.UI.Page
{
    // Global variables
    Random randomOption = new Random();
    String computerChoice;

    int totalPlays;
    int finalWin;
    int finalDraw;
    int finalLoss;

    DateTime finalDOB;

    /** On page load get the current wins/draws/losses from the database 
     *  Display the score
     *  Reset the labels
     *  Wish the user a happy birthday (if it's his/her birthday)
     */
    protected void Page_Load(object sender, EventArgs e)
    {
        GetWins();
        GetDraws();
        GetLoss();

        DisplayScores();

        ResetLabels();

        Birthday();
    }

    /** Determine the outcome if the user selects 'Rock' */
    protected void Rock()
    {
        /** If the value equals 1 from the RadioButtonList (Rock) and the computer chooses
         *  Paper then the computer wins. 
         *  The following if statements are very similar to this one, hense why there is no need for comments.
         */
        RandomComputer();
        if (MainList.SelectedValue == "1" && computerChoice.Equals("Paper"))
        {
            RockSelected.Text = "You selected Rock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            /** Increment the loss by 1 for the statistics */
            finalLoss = finalLoss + 1;

        }
        else if (MainList.SelectedValue == "1" && computerChoice.Equals("Scissors"))
        {
            RockSelected.Text = "You selected Rock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            /** Increment the win by 1 for the statistics */
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "1" && computerChoice.Equals("Lizard"))
        {
            RockSelected.Text = "You selected Rock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "1" && computerChoice.Equals("Spock"))
        {
            RockSelected.Text = "You selected Rock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            finalLoss = finalLoss + 1;
        }
        else if (MainList.SelectedValue == "1" && computerChoice.Equals("Rock"))
        {
            RockSelected.Text = "You selected Rock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "It's a draw!";
            /** Increment the draw by 1 for the statistics */
            finalDraw = finalDraw + 1;
        }
    }

    /** Determine the outcome if the user selects 'Paper' */
    protected void Paper()
    {
        RandomComputer();
        if (MainList.SelectedValue == "2" && computerChoice.Equals("Rock"))
        {
            PaperSelected.Text = "You selected Paper";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "2" && computerChoice.Equals("Scissors"))
        {
            PaperSelected.Text = "You selected Paper";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            finalLoss = finalLoss + 1;
        }
        else if (MainList.SelectedValue == "2" && computerChoice.Equals("Lizard"))
        {
            PaperSelected.Text = "You selected Paper";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            finalLoss = finalLoss + 1;
        }
        else if (MainList.SelectedValue == "2" && computerChoice.Equals("Spock"))
        {
            PaperSelected.Text = "You selected Paper";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "2" && computerChoice.Equals("Paper"))
        {
            PaperSelected.Text = "You selected Paper";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "It's a draw!";
            finalDraw = finalDraw + 1;
        }
    }

    /** Determine the outcome if the user selects 'Scissors' */
    protected void Scissors()
    {
        RandomComputer();
        if (MainList.SelectedValue == "3" && computerChoice.Equals("Paper"))
        {
            ScissorsSelected.Text = "You selected Scissors";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "3" && computerChoice.Equals("Spock"))
        {
            ScissorsSelected.Text = "You selected Scissors";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            finalLoss = finalLoss + 1;
        }
        else if (MainList.SelectedValue == "3" && computerChoice.Equals("Lizard"))
        {
            ScissorsSelected.Text = "You selected Scissors";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "3" && computerChoice.Equals("Rock"))
        {
            ScissorsSelected.Text = "You selected Scissors";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            finalLoss = finalLoss + 1;
        }
        else if (MainList.SelectedValue == "3" && computerChoice.Equals("Scissors"))
        {
            ScissorsSelected.Text = "You selected Scissors";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "It's a draw!";
            finalDraw = finalDraw + 1;
        }
    }

    /** Determine the outcome if the user selects 'Lizard' */
    protected void Lizard()
    {
        RandomComputer();
        if (MainList.SelectedValue == "4" && computerChoice.Equals("Rock"))
        {
            LizardSelected.Text = "You selected Lizard ";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            finalLoss = finalLoss + 1;
        }
        else if (MainList.SelectedValue == "4" && computerChoice.Equals("Spock"))
        {
            LizardSelected.Text = "You selected Lizard ";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "4" && computerChoice.Equals("Scissors"))
        {
            LizardSelected.Text = "You selected Lizard ";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            finalLoss = finalLoss + 1;
        }
        else if (MainList.SelectedValue == "4" && computerChoice.Equals("Paper"))
        {
            LizardSelected.Text = "You selected Lizard ";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "4" && computerChoice.Equals("Lizard"))
        {
            LizardSelected.Text = "You selected Lizard ";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "It's a draw!";
            finalDraw = finalDraw + 1;
        }
    }

    /** Determine the outcome if the user selects 'Spock' */
    protected void Spock()
    {
        RandomComputer();
        if (MainList.SelectedValue == "5" && computerChoice.Equals("Lizard"))
        {
            SpockSelected.Text = "You selected Spock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            finalLoss = finalLoss + 1;
        }
        else if (MainList.SelectedValue == "5" && computerChoice.Equals("Scissors"))
        {
            SpockSelected.Text = "You selected Spock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "5" && computerChoice.Equals("Paper"))
        {
            SpockSelected.Text = "You selected Spock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You lose! Computer wins.";
            finalLoss = finalLoss + 1;
        }
        else if (MainList.SelectedValue == "5" && computerChoice.Equals("Rock"))
        {
            SpockSelected.Text = "You selected Spock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "You win! Computer loses.";
            finalWin = finalWin + 1;
        }
        else if (MainList.SelectedValue == "5" && computerChoice.Equals("Spock"))
        {
            SpockSelected.Text = "You selected Spock";
            NothingSelected.Text = "";
            ComputerSelected.Text = "and the Computer selected " + computerChoice;
            Winner.Text = "It's a draw!";
            finalDraw = finalDraw + 1;  
        }
    }

    /** Call the methods and events when you select different buttons in the RadioList */
    protected void MainList_SelectedIndexChanged(object sender, EventArgs e)
    {
        Rock();
        Paper();
        Scissors();
        Lizard();
        Spock();
    }

    /** Generate the computers choices */
    protected void RandomComputer()
    {
        String[] options = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        computerChoice = options[randomOption.Next(1, 5)];
    }

    /** If nothing is selected inform the user 
     *  Clear the current user selection (allowing the user to replay)
     */
    protected void Play_Click(object sender, EventArgs e)
    {
        if (MainList.SelectedValue != "1" && MainList.SelectedValue != "2" && MainList.SelectedValue != "3"
            && MainList.SelectedValue != "4" && MainList.SelectedValue != "5")
        {
            NothingSelected.Text = "You haven't selected anything!";
        }
        /** Give the user the option to play again */
        Play.Text = "Play again!";
        MainList.ClearSelection();
        DisplayScores();
        UpdateStatistics();
    }

    /** Log the user out */
    protected void LogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPage.aspx");
    }

    /** Reset the labels allowing the user to continue playing */
    protected void ResetLabels()
    {
        RockSelected.Text = "";
        PaperSelected.Text = "";
        ScissorsSelected.Text = "";
        LizardSelected.Text = "";
        SpockSelected.Text = "";
        NothingSelected.Text = "";
        ComputerSelected.Text = "";
        Winner.Text = "";
    }

    /** Display the current user statistics to the screen */
    protected void DisplayScores()
    {
        totalPlays = finalWin + finalDraw + finalLoss;
        TotalPlays.Text = "Total Plays: " + totalPlays;
        DisplayWins.Text = "Wins: " + finalWin;
        DisplayDraws.Text = "Draws: " + finalDraw;
        DisplayLoss.Text = "Loss: " + finalLoss;
    }

    /** Get the number of user wins */
    protected void GetWins()
    {
        var username = Session["Statistics"];
        try
        {
            SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            dbConnection.Open();
            /** Query to the database */ 
            SqlCommand winCommand = new SqlCommand("SELECT Wins from Users WHERE Username = '" + username + "'", dbConnection);
            /** Convert the SQLCommand into an integer, allowing the value to be incremented when the user wins */
            finalWin = Convert.ToInt32(winCommand.ExecuteScalar());
            winCommand.ExecuteNonQuery();
            dbConnection.Close();
        }
        catch (Exception ex)
        {
            //DEBUGGING
            //Response.Write("Error: " + ex.ToString());
        }
    }

    /** Get the number of user draws */
    protected void GetDraws()
    {
        var username = Session["Statistics"];
        try
        {
            SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            dbConnection.Open();
            /* Query the database */
            SqlCommand drawCommand = new SqlCommand("SELECT Draws from Users WHERE Username = '" + username + "'", dbConnection);
            /** Convert the SQLCommand into an integer, allowing the value to be incremented when the user draws */
            finalDraw = Convert.ToInt32(drawCommand.ExecuteScalar());
            drawCommand.ExecuteNonQuery();
            dbConnection.Close();
        }
        catch (Exception ex)
        {
            //DEBUGGING
            //Response.Write("Error: " + ex.ToString());
        }
    }

    /** Get the number of user losses */
    protected void GetLoss() 
    {
        var username = Session["Statistics"];
        try
        {
            SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            dbConnection.Open();
            /** Query the database */
            SqlCommand lossCommand = new SqlCommand("SELECT Loss from Users WHERE Username = '" + username + "'", dbConnection);
            /** Convert the SQLCommand into an integer, allowing the value to be incremented when the user loses */
            finalLoss = Convert.ToInt32(lossCommand.ExecuteScalar());
            lossCommand.ExecuteNonQuery();
            dbConnection.Close();
        }
        catch (Exception ex)
        {
            //DEBUGGING
            //Response.Write("Error: " + ex.ToString());
        }
    }
    /** Update the current users score to the database (Wins, Draws and Losses) */
    protected void UpdateStatistics()
    {
        var username = Session["Statistics"];
        try
        {
            SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            dbConnection.Open();
            /** Query the database */
            SqlCommand statisticsCommand = new SqlCommand("UPDATE Users SET Wins = '" + finalWin + "', Draws = '" + finalDraw + "', Loss = '" + finalLoss + "' WHERE Username= '" + username + "'", 
                                                    dbConnection);
            statisticsCommand.ExecuteNonQuery();
            dbConnection.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.ToString());
        }
    }

    /** Get the current logged in users date of birth */
    protected void GetBirthday()
    {
        var username = Session["Statistics"];
        try
        {
            SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            dbConnection.Open();
            /** Query the database */
            SqlCommand dobCommand = new SqlCommand("SELECT DOB from Users WHERE Username = '" + username + "'", dbConnection);
            /** Parse the SQLCommand to a DateTime object */
            finalDOB = DateTime.Parse(dobCommand.ExecuteScalar().ToString());
            dobCommand.ExecuteNonQuery();
            dbConnection.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.ToString());
        }
    }

    /** Determine if it's the users birthday */
    protected void Birthday()
    {
        var username = Session["Statistics"];
        GetBirthday();
        /** Gets the current date */
        DateTime todayDate = DateTime.Today;
        DateTime birthdayDate = finalDOB;
        /** If todays day and month is equal to the users date of birth then wish them a happy birthday */
        if (todayDate.Day.Equals(birthdayDate.Day) == true && todayDate.Month.Equals(birthdayDate.Month))
        {
            BirthdayNotifier.Text = "Happy Birthday "+username+"!";
            Balloon.Visible = true;
        }
        else
        {
            // Do nothing
        }
    }
}
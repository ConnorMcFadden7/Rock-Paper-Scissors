<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Game.aspx.cs" Inherits="Game"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Rock, Paper, Scissors, Lizard, Spock!</title>
    </head>
    <body style="background:#333333">
        <form id="form1" runat="server">
            <div>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/header.png" />
                <asp:RadioButtonList ID="MainList" runat="server" OnSelectedIndexChanged="MainList_SelectedIndexChanged" RepeatDirection="Horizontal" style="color: #FFFFFF; z-index: 1; left: 755px; top: 330px; position: absolute; height: 27px; width: 319px;">
                    <asp:ListItem Text="Rock" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Paper" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Scissors" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Lizard" Value="4"></asp:ListItem>
                    <asp:ListItem Text="Spock" Value="5"></asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="Play" runat="server" Text="Play" OnClick="Play_Click" style="z-index: 1; left: 871px; top: 399px; position: absolute; right: 273px; width:94px" />
                <asp:Button ID="LogOut" runat="server" Text="Log out" OnClick="LogOut_Click" style="z-index: 1; left: 979px; top: 399px; position: absolute; width: 94px" />
                <asp:Label ID="RockSelected" runat="server" ForeColor="White" style="z-index: 1; left: 758px; top: 436px; position: absolute"></asp:Label>
                <asp:Label ID="PaperSelected" runat="server" ForeColor="White" style="z-index: 1; left: 755px; top: 436px; position: absolute"></asp:Label>
                <asp:Label ID="ScissorsSelected" runat="server" ForeColor="White" style="z-index: 1; left: 741px; top: 436px; position: absolute"></asp:Label>
                <asp:Label ID="LizardSelected" runat="server" ForeColor="White" style="z-index: 1; left: 753px; top: 436px; position: absolute"></asp:Label>
                <asp:Label ID="SpockSelected" runat="server" ForeColor="White" style="z-index: 1; left: 751px; top: 436px; position: absolute"></asp:Label>
                <asp:Label ID="NothingSelected" runat="server" ForeColor="White" style="z-index: 1; left: 743px; top: 436px; position: absolute"></asp:Label>
                <asp:Label ID="ComputerSelected" runat="server" ForeColor="White" style="z-index: 1; left: 886px; top: 436px; position: absolute; right: 229px"></asp:Label>
                <asp:Label ID="Winner" runat="server" ForeColor="White" style="z-index: 1; left: 742px; top: 473px; position: absolute" Font-Bold="true"></asp:Label>
                <asp:Label ID="StatisticsLabel" runat="server" Text="User Statistics:" ForeColor="White" Font-Underline="true" style="z-index: 1; left: 743px; top: 510px; position: absolute"></asp:Label>
                <asp:Label ID="TotalPlays" runat="server" ForeColor="White" style="z-index: 1; left: 743px; top: 539px; position: absolute"></asp:Label>
                <asp:Label ID="DisplayWins" runat="server" ForeColor="White" style="z-index: 1; left: 743px; top: 559px; position: absolute"></asp:Label>
                <asp:Label ID="DisplayDraws" runat="server" ForeColor="White" style="z-index: 1; left: 743px; top: 579px; position: absolute"></asp:Label>
                <asp:Label ID="DisplayLoss" runat="server" ForeColor="White" style="z-index: 1; left: 743px; top: 598px; position: absolute"></asp:Label>
                <asp:Label ID="BirthdayNotifier" runat="server" ForeColor="Yellow" Font-Size="Larger" style="z-index: 1; left: 833px; top: 667px; position: absolute"></asp:Label>
                <asp:Image ID="Balloon" runat="server" ImageUrl="~/balloon.png" style="z-index: 1; left: 759px; top: 647px; position: absolute" Visible="false"/>
            </div>
        </form>
    </body>
</html>

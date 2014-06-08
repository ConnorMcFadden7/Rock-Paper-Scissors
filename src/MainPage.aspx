<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage"%>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Rock, Paper, Scissors, Lizard, Spock!</title>
    </head>
    <body style="background:#333333">
        <form id="form1" runat="server">
            <div> 
                <asp:Image ID="Image1" runat="server" ImageUrl="~/header.png" />
                <asp:Label ID="UserDoesntExist" runat="server" ForeColor="Red" style="z-index: 1; left: 844px; top: 334px; position: absolute; margin-top: 4px;" ></asp:Label>
                <asp:Label ID="Username" runat="server" Text="Username:" ForeColor="White" style="z-index: 1; left: 760px; top: 368px; position: absolute" />
                <asp:TextBox ID="UsernameLogin" runat="server" style="z-index: 1; left: 842px; top: 366px; position: absolute; width: 162px"  />
                <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" style="z-index: 1; left: 847px; top: 398px; position: absolute" />
                <asp:Label ID="Or" runat="server" Text="or" style="z-index: 1; left: 901px; top: 400px; position: absolute; right: 571px;" ForeColor="Gray" Font-Underline="True" />
                <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" style="z-index: 1; left: 918px; top: 397px; position: absolute" />
            </div>
        </form>
    </body>
</html>


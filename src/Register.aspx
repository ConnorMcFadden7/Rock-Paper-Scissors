<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rock, Paper, Scissors, Lizard, Spock!</title>
</head>
    <body style="background:#333333; height: 454px;">
        <form id="form1" runat="server">
            <div style="height: 450px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/header.png" />
                <br />
                <asp:Label ID="Username" runat="server" Text="Username:" ForeColor="White" style="z-index: 1; left: 738px; top: 336px; position: absolute"></asp:Label>
                <asp:Label ID="UsernameEmpty" runat="server" ForeColor="Red" style="z-index: 1; left: 1008px; top: 335px; position: absolute"></asp:Label>
                <asp:TextBox ID="UsernameText" runat="server" style="z-index: 1; left: 814px; top: 333px; position: absolute; width: 178px" ></asp:TextBox>
                <br />
                <asp:Label ID="Date_of_birth" runat="server" Text="Date of birth:" ForeColor="White" style="z-index: 1; left: 724px; top: 372px; position: absolute"></asp:Label>
                <asp:Label ID="DOBEmpty" runat="server" ForeColor="Red" style="z-index: 1; left: 1132px; top: 370px; position: absolute" ></asp:Label>
                <asp:Label ID="DOBVal" runat="server" Text="MM/DD/YYYY" ForeColor="Gray" style="z-index: 1; left: 1008px; top: 372px; position: absolute"></asp:Label>
                <br />
                <asp:Button ID="ReturnHome" runat="server" Text="Back" OnClick="Back_Click" style="z-index: 1; left: 887px; top: 400px; position: absolute; height:25px" />
                <asp:TextBox ID="DOBText" runat="server" style="z-index: 1; left: 814px; top: 371px; position: absolute; width: 178px" ></asp:TextBox>
                <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="Register_Click" style="position: relative; top: 47px; left: 804px; height:25px" />
                <asp:Label ID="DOBIncorrect" runat="server" style="z-index: 1; left: 1132px; top: 370px; position: absolute" ForeColor="Red"></asp:Label>
            </div>
        </form>
    </body>
</html>


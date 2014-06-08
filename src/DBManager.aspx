<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DBManager.aspx.cs" Inherits="DBManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Username" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Username" HeaderText="Username" ReadOnly="True" SortExpression="Username" />
                    <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                    <asp:BoundField DataField="Wins" HeaderText="Wins" SortExpression="Wins" />
                    <asp:BoundField DataField="Draws" HeaderText="Draws" SortExpression="Draws" />
                    <asp:BoundField DataField="Loss" HeaderText="Loss" SortExpression="Loss" />
                </Columns>
            </asp:GridView>
        </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
        </form>
    </body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weekly_Calendar.aspx.cs" Inherits="N01350618_Bonus_Assignment_B.Weekly_Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h2>Select your working day(s) of the week:</h2>
            <asp:CheckBoxList runat="server" ID="user_working_days">
                <asp:ListItem Value="Monday">Monday</asp:ListItem>
                <asp:ListItem Value="Tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="Wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="Thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="Friday">Friday</asp:ListItem>
                <asp:ListItem Value="Saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="Sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>
        </section>

        <section id="weekly_calendar_summary" runat="server">
        </section>

        <section>
            <input type="submit" value="submit" />
        </section>
    </form>
</body>
</html>

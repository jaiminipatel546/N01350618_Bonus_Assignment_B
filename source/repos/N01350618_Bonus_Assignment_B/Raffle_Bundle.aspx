<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Raffle_Bundle.aspx.cs" Inherits="N01350618_Bonus_Assignment_B.Raffle_Bundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h2>Please enter the number of tickets you want to purchase</h2>
            <asp:TextBox runat="server" ID="ticket_purchased"></asp:TextBox>
        </section>

        <section id="raffle_bundle_summary" runat="server">
        </section>

        <section>
            <input type="submit" value="submit" />
        </section>
    </form>
</body>
</html>

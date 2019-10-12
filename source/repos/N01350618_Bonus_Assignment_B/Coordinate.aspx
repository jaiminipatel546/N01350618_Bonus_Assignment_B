<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coordinate.aspx.cs" Inherits="N01350618_Bonus_Assignment_B.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h2>Please enter your X-coordinate value</h2>
            <asp:TextBox runat="server" ID="x_coordinate"></asp:TextBox>
            <asp:CustomValidator runat="server" ControlToValidate="x_coordinate"   ErrorMessage="X-Coordinate value cannot be zero." OnServerValidate="validateCoordinateValue"></asp:CustomValidator>
        </section>

        <section>
            <h2>Please enter your Y-coordinate value</h2>
            <asp:TextBox runat="server" ID="y_coordinate"></asp:TextBox>
            <asp:CustomValidator runat="server" ControlToValidate="y_coordinate"   ErrorMessage="Y-Coordinate value cannot be zero." OnServerValidate="validateCoordinateValue"></asp:CustomValidator>
        </section>
        
        <section>
            <asp:ValidationSummary runat="server" ShowSummary="true" />
        </section>

        <section id="coordinate_summary" runat="server">
        </section>

        <section>
            <input type="submit" value="submit" />
        </section>
    </form>
</body>
</html>

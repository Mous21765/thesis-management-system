<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArrangeDate.aspx.cs" Inherits="SystimaDiaxeirisisPtyxiakwn.ArrangeDate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Οργάνωση Ραντεβού</title>
</head>
<body style="background-color:coral;">
    <form id="form1" runat="server">
        <div>
            <h1>Οργάνωση Ραντεβού</h1>
        </div>
        <div>
            <asp:Calendar ID="Calendar1" runat="server" Width="400px" ></asp:Calendar><br /><br />
            Ώρα:<asp:DropDownList ID="hour" runat="server"></asp:DropDownList>:<asp:DropDownList ID="minutes" runat="server"></asp:DropDownList><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Κανόνισε το ραντεβού" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

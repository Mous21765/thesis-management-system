<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grade.aspx.cs" Inherits="SystimaDiaxeirisisPtyxiakwn.Grade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Κατάθεση Βαθμολογίας</title>
</head>
<body style="text-align:center;background-color:coral;">
    <form id="form1" runat="server">
        <div>
            <h1>Κατάθεση Βαθμολογίας</h1>
        </div><br /><br />
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="200"></asp:DropDownList><br /><br />
            Βαθμός:<asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Κατάθεση Βαθμού"  Width="200" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>

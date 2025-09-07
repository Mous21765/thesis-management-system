<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dates.aspx.cs" Inherits="SystimaDiaxeirisisPtyxiakwn.Dates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ραντεβού</title>
</head>
<body style="background-color:coral;">
    <form id="form1" runat="server">
        <div>
             <h1>Λίστα των Ραντεβού με φοιτητές</h1>
        </div><br /><br />
        <div>
            <asp:Table ID="dates_table" runat="server">
                <asp:TableRow><asp:TableCell Width="200"><b>Όνομα φοιτή</b></asp:TableCell><asp:TableCell><b>Ημερομηνία και Ώρα</b></asp:TableCell></asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>

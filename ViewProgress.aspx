<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProgress.aspx.cs" Inherits="SystimaDiaxeirisisPtyxiakwn.ViewProgress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Πρόοδος πτυχιακής</title>
</head>
<body style="text-align:center;background-color:coral;">
    <form id="form1" runat="server">
        <div>
             <h1>Έλεγχος προόδου πτυχιακής</h1>
        </div><br /><br />
        <div>
            <table style="margin-left:auto;margin-right:auto">
                <tr><td>Τίτλος Πτυχιακής:</td><td>
                    <asp:Label ID="title" runat="server" Text="Label"></asp:Label></td></tr>
                <tr><td>Περιγραφή Πτυχιακής:</td><td><asp:Label ID="desc" runat="server" Text="Label"></asp:Label></td></tr>
                <tr><td>Βαθμός Πτυχιακής:</td><td><asp:Label ID="grade" runat="server" Text="Label"></asp:Label></td></tr>
            </table>
        </div>
    </form>
</body>
</html>

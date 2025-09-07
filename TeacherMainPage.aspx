<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherMainPage.aspx.cs" Inherits="SystimaDiaxeirisisPtyxiakwn.TeacherMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Κεντρική Σελίδα Καθηγητή</title>
</head>
<body style="text-align:center;background-color:coral;">
    <form id="form1" runat="server">
        <div>
              <h1>Κεντρική Σελίδα Καθηγητή</h1>
            <h3><asp:Label ID="NameLabel" runat="server" Text="Label"></asp:Label></h3>
        </div><br /><br />
        <div>
            <asp:HyperLink ID="view_dates" runat="server">Δείτε τα ραντεβού</asp:HyperLink><br /><br />
            <asp:HyperLink ID="grade" runat="server">Βαθμολογήστε πτυχιακή</asp:HyperLink><br /><br />
        </div>
    </form>
</body>
</html>

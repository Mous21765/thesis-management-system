<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentMainPage.aspx.cs" Inherits="SystimaDiaxeirisisPtyxiakwn.StudentMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Κεντρική σελίδα φοιτητή</title>
</head>
<body style="text-align:center;background-color:coral;">
    <form id="form1" runat="server">
        <div>
            <h1>Κεντρική σελίδα φοιτητή</h1>
            <h3>
                <asp:Label ID="NameLabel" runat="server" Text="Label"></asp:Label></h3>
        </div><br /><br />
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ptyxiaki.aspx">Δημιουργία καταχώρισης πτυχιακής εργασίας.</asp:HyperLink><br /><br />
            <asp:HyperLink ID="HyperLink2" runat="server">Ανέβασμα αρχείου.</asp:HyperLink><br /><br />
            <asp:HyperLink ID="HyperLink4" runat="server">Οργάνωση συνάντησης με τον καθηγητή.</asp:HyperLink><br /><br />
            <asp:HyperLink ID="HyperLink3" runat="server">Παρακολούθηση προόδου πτυχιακής.</asp:HyperLink><br /><br />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ptyxiaki.aspx.cs" Inherits="SystimaDiaxeirisisPtyxiakwn.ptyxiaki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Πτυχιακή</title>
</head>
<body style="text-align:center;background-color:coral;">
    <form id="form1" runat="server">
        <div>
            <h1>Καταχώριση Στοιχείων Πτυχιακής Εργασίας </h1>
        </div><br /><br />
        <div>
            <table style="margin-left:auto;margin-right:auto;">
                <tr><td>ΙD φοιτητή</td><td><asp:TextBox ID="idf" runat="server" Width="200"></asp:TextBox></td></tr>
                 <tr><td>ΙD καθηγητή</td><td>
                     <asp:DropDownList ID="kathigites_list" runat="server" Width="200"></asp:DropDownList></td></tr>
                <tr><td>Τίτλος</td><td><asp:TextBox ID="title" runat="server" Width="200"></asp:TextBox></td></tr>
                <tr><td>Περιγραφή</td><td><asp:TextBox ID="desc" runat="server" Width="200" Height="100"></asp:TextBox></td></tr>
                <tr><td colspan="2">
                    <asp:Button ID="b" runat="server" Text="Κάταχώριση" OnClick="b_Click" /></td></tr>
            </table>
        </div>
    </form>
</body>
</html>

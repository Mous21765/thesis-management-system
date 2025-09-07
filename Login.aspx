<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SystimaDiaxeirisisPtyxiakwn.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align:center;background-color:coral;">
    <form id="form1" runat="server">
        <div>
            <h1>Είσοδος Χρήστη στο Σύστημα</h1>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Όνομα Χρήστη:"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Κωδικός:" ></asp:Label><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Είσοδος" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

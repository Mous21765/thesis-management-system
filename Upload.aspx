<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="SystimaDiaxeirisisPtyxiakwn.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ανάρτηση Αρχείου</title>
</head>
<body style="text-align:center;background-color:coral;">
    <form id="form1" runat="server">
        <div>
             <h1>Ανάρτηση Αρχείου</h1>
            <h3>Η καινούρια ανάρτηση θα διαγράψει την προηγούμενη,εάν υπάρχει.</h3>
        </div><br /><br />
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server"/><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Ανάρτηση Αρχείου" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

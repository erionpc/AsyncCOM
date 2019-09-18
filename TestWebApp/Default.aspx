<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="TestWebApp._Default" AspCompat="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Test web form with async=false</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnGetResult" runat="server" OnClick="btnGetResult_Click" Text="Get result" /><br />
            <asp:Label ID="lblResult" runat="server"></asp:Label><br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

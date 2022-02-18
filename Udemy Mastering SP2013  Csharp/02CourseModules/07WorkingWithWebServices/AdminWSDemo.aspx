<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminWSDemo.aspx.cs" Inherits="AdminWSDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Site Collection" />
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete Site Collection" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

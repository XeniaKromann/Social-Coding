<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestBruger.aspx.cs" Inherits="TestBruger" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl_user" Text="" runat="server" />

        <asp:Button ID="btn_opret" Text="Opret" runat="server" OnClick="btn_opret_Click" />
        <asp:Button ID="btn_slet" Text="Slet" runat="server" OnClick="btn_slet_Click" />
        <asp:Button ID="btn_reload" Text="Reload" runat="server" />
        <asp:Label Text="text" runat="server" />
    </div>
    </form>
</body>
</html>

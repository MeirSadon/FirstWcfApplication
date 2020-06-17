<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PostMethodWcf.WebForm1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>fourthbottle</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Name : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        Addr : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        Mobi : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        Dept : <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" /><br />
        <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
    </div>
    </form>
</body>
</html>
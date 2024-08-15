<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Drop_Click">
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label style="color:red" ID="Label6" runat="server" Text=""></asp:Label><br />
        <div>
            <p>Add correct details</p>
            Name:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
            Emai:
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br />
            EmpID:
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> <br />
            EmpDept:
                <asp:DropDownList ID="DropDown1" runat="server">
                    <asp:ListItem>HR</asp:ListItem>
                    <asp:ListItem>IT</asp:ListItem>
                    <asp:ListItem>CS</asp:ListItem>
                    <asp:ListItem>Others...</asp:ListItem>
                </asp:DropDownList><br />
            Salary:
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" onClick="Button1_Click"/>
            <br />
        </div>

        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>

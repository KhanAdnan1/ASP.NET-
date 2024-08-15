<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:15px">
            Name:
            `   <asp:TextBox style="margin:5px" ID="TextBox1" runat="server"></asp:TextBox>
            <br/>

            Email:
                   <asp:TextBox style="margin:5px" ID="TextBox2" runat="server"></asp:TextBox>
            <br/>

            EmpID:
                <asp:TextBox style="margin:5px" ID="TextBox3" runat="server"></asp:TextBox>

            <br/>
            Dept:
                <asp:DropDownList style="margin:5px" ID="DropDownList1" runat="server">
                    <asp:ListItem>HR</asp:ListItem>
                    <asp:ListItem>IT</asp:ListItem>
                    <asp:ListItem>CS</asp:ListItem>
                    <asp:ListItem>Others..</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            <br/>

            Salary:
                <asp:TextBox style="margin:5px" ID="TextBox4" runat="server"></asp:TextBox>
            <br/>
            D.O.B:
                <asp:TextBox style="margin:5px" ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>

        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

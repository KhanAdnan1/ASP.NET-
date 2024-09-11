<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormValidation.aspx.cs" Inherits="back.FormValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BorderColor="Red" 
            ControlToValidate="TextBox2" ErrorMessage="Name is requored" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
&nbsp;<div>
            Age&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" BackColor="White" BorderColor="Red" 
                ControlToValidate="TextBox3" ErrorMessage="Age is required " ForeColor="Red"
                MinimumValue="18" MaximumValue="50"></asp:RangeValidator>
            <br />
            <br />
            Email&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
             ControlToValidate="TextBox4" ErrorMessage="Enter a correct email" ForeColor="Red" 
             ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            Pass&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
<asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="1st letter should be Capital letter" ForeColor="Red" 
    OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
            <br />
            <br />
            CnfPass <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ErrorMessage="Check the password" ForeColor="Red"></asp:CompareValidator>
        </div>
    </form>
</body>
</html>

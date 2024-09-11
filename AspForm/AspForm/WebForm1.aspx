<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="AspForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        .center-div {
            display: flex;
            flex-direction:column;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center-div">
            <asp:Label style="font-size:large" ID="Label1" runat="server" Text="Change Body BackGround color"></asp:Label><br/>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter color name"></asp:TextBox><br/>
            <asp:Button ID="Button1" runat="server" Text="Change" />
            
        </div>

        
        
        
        
    </form>
</body>
</html>

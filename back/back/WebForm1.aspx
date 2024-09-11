<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="back.WebForm1" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="a" TagName="b" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a:b  runat="server"/>
        </div>
    </form>
</body>
</html>

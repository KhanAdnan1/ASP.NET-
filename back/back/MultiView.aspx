<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiView.aspx.cs" Inherits="back.MultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:MultiView ID="MultiView1" runat="server" >
                <asp:View ID="View1" runat="server">
                    <h1>Personal Details</h1><br /> 
                    First Name&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    Lirst Name&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    Contact No
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                    Email ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />
                </asp:View>

                <asp:View ID="View2" runat="server">
                    <h1>Address Details</h1>
                    
                        Area&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <br />
                    City&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    <br />
                    State&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <br />
                    PinCode
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
                    <asp:Button ID="Button3" runat="server" Text="Next" OnClick="Button3_Click" />
                    <br />

                </asp:View>

                <asp:View ID="View3" runat="server">
                    <h1>Education Details</h1>
                        SSC Marks
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    <br />
                    HSC Marks
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text="Back" OnClick="Button4_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" Text="Next" OnClick="Button5_Click" />
                </asp:View>

                <asp:View ID="View4" runat="server">
                    <h1>Student Details</h1>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="Button6" runat="server" Text="Back" OnClick="Button6_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button7" runat="server" Text="Submit" OnClick="Button7_Click" />
                    <br />

                    
                </asp:View>
            </asp:MultiView>


            
        </div>
    </form>
</body>
</html>

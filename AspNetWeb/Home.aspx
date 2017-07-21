<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AspNetWeb.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="/welcome.aspx">
    <div>
        

        <table>
            <tr><td colspan="2" align="center"><h1>Welcome to Marlabs</h1></td></tr>
            <tr><td><img src ="https://media.licdn.com/mpr/mpr/shrink_200_200/AAEAAQAAAAAAAAMaAAAAJGYwOGMyYjdjLWJlY2EtNGM0OC04OWI2LTA0MWY2NWExZWIxMA.png" /></td>
                <td>
                    <table>
                        <tr><td colspan="2" align="center">
                            <asp:Label ID="Label3" runat="server" Visible="false" Text="Username or Password is Invalid"></asp:Label>
                            </td>
                        <tr><td>
                            <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
                            </td><td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td></tr>
                        <tr><td>
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                            </td><td>
                                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:LinkButton ID="link1" runat="server" Text="show password" OnClick="link1_Click"></asp:LinkButton>
                            </td></tr>
                        <tr><td colspan="2" align="center">
                            <asp:CheckBox ID="CheckBox1" runat="server" />&nbsp;I Agree
                            </td></tr>
                        <tr><td colspan="2" align="center">
                            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                            <input id="testButton" type="button" onclick= "btnOnClick();" />
                            </td></tr>
                    </table>
                </td>

            </tr>
            <tr><td colspan="2" align="center"><h6>Contact our office located at Piscataway, NJ</h6></td></tr>
        </table>
    </div>
    </form>
    <script>
        function btnOnClick()
        {
            alert("hello");
            form1.submit();
        }
    </script>
</body>
</html>

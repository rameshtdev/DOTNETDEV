<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelfAssessment.aspx.cs" Inherits="AspNetWeb.SelfAssessment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td colspan="2"><B>Self Assessment</B></td></tr>
        <tr><td>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            </td><td>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </td></tr>
         <tr><td>
            <asp:Label ID="lblHireDate" runat="server" Text="HireDate"></asp:Label>
            </td><td>
                <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
                 <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                     <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                     <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                     <OtherMonthDayStyle ForeColor="#CC9966" />
                     <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                     <SelectorStyle BackColor="#FFCC66" />
                     <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                     <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                 </asp:Calendar>
            </td></tr>
        <tr><td>
            <asp:Label ID="lblLastName" runat="server" Text="Last name"></asp:Label>
            </td><td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </td></tr>
        <tr><td>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td><td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td></tr>
        <tr><td>
            <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
            </td><td>
                <asp:RadioButtonList ID="rbtnGenderList" runat="server">
                    <asp:ListItem Value="1">Male</asp:ListItem>
                    <asp:ListItem Value="0">Female</asp:ListItem>
                </asp:RadioButtonList>
            </td></tr>
        <tr><td>
            <asp:Label ID="lblCountry" runat="server" Text="Country of Birth"></asp:Label>
            </td><td>
                <asp:DropDownList ID="ddlCountry" runat="server">
                </asp:DropDownList>
            </td></tr>
        <tr><td>
            <asp:Label ID="lblTech" runat="server" Text="Technologies"></asp:Label>
            </td><td>
                <asp:CheckBoxList ID="chkTech" runat="server">
                    <asp:ListItem>C-Sharp</asp:ListItem>
                    <asp:ListItem>ASP.NET</asp:ListItem>
                    <asp:ListItem>MVC</asp:ListItem>
                    <asp:ListItem>SQL</asp:ListItem>
                    <asp:ListItem>Entity Framework</asp:ListItem>
                    <asp:ListItem>LINQ</asp:ListItem>
                </asp:CheckBoxList>
            </td></tr>
        <tr><td>
            <asp:Label ID="lblQualification" runat="server" Text="Qualification"></asp:Label>
            </td><td>
                <asp:ListBox ID="lstQualification" runat="server" Width="109px">
                    <asp:ListItem>Bachelor in Engineering</asp:ListItem>
                    <asp:ListItem>Masters in Engineering</asp:ListItem>
                    <asp:ListItem>Existing work experience</asp:ListItem>
                </asp:ListBox>
            </td></tr>
        <tr><td colspan="2">
            <asp:Button ID="btnSave" runat="server" Text="Save" />
            </td></tr>
    </table>
    </div>
    </form>
</body>
</html>

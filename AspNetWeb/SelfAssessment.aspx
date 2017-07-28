<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelfAssessment.aspx.cs" Inherits="AspNetWeb.SelfAssessment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
  $( function() {
      $("#txtHireDate").datepicker();
  } );
  </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td colspan="2"><B style="background-color: #00FFFF">Self Assessment</B></td></tr>
        <tr><td>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            </td><td>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Firstname is Required" ControlToValidate="txtFirstName">*</asp:RequiredFieldValidator>
            </td></tr>         
        <tr><td>
            <asp:Label ID="lblLastName" runat="server" Text="Last name"></asp:Label>
            </td><td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Last name is Required" ControlToValidate="txtLastName">*</asp:RequiredFieldValidator>
            </td></tr>
        <tr><td>
            <asp:Label ID="lblHireDate" runat="server" Text="HireDate"></asp:Label>
            </td><td>
                <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="HireDate is Required" ControlToValidate="txtHireDate">*</asp:RequiredFieldValidator>
            </td></tr>
        <tr><td>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td><td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email is Required" ControlToValidate="txtEmail">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
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
                <asp:ListBox ID="lstQualification" runat="server" Width="109px" SelectionMode="Multiple">
                    <asp:ListItem>Bachelor in Engineering</asp:ListItem>
                    <asp:ListItem>Masters in Engineering</asp:ListItem>
                    <asp:ListItem>Existing work experience</asp:ListItem>
                </asp:ListBox>
            </td></tr>
        <tr><td colspan="2">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td></tr>
        <tr><td colspan="2">
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            </td></tr>
    </table>
    </div>
    </form>
</body>
</html>

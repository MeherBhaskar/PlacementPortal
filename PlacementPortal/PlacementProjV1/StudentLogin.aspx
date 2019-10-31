<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StudentLogin.aspx.cs" Inherits="PlacementProjV1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Registration Number:
        <asp:TextBox ID="RegNo" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" BorderStyle="Double" ControlToValidate="RegNo" ErrorMessage="Enter a Registration Number" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="RegNo" ErrorMessage="Enter a valid Registration number of 9 digits" ValidationExpression="\d{9}" ForeColor="Red" ></asp:RegularExpressionValidator>
    </p>
    <p>
        Password :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Password" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:CheckBox ID="CheckBox1" runat="server"  Text="Remember Me" />
    </p>
</asp:Content>

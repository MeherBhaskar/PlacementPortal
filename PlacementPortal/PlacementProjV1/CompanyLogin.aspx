<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CompanyLogin.aspx.cs" Inherits="PlacementProjV1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p>
        Company UID:
        <asp:TextBox ID="RegNo" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" BorderStyle="Double" ControlToValidate="RegNo" ErrorMessage="Enter a Registration Number" ForeColor="Red"></asp:RequiredFieldValidator>
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
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminMMenu.aspx.cs" Inherits="PlacementProjV1.WebForm15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add Group" />
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete Group" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View/Edit Student Profiles" />
    <br />
    <br />
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="View/Edit Company Profiles" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Groups" />
</asp:Content>

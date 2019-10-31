<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminTransferAuthChange.aspx.cs" Inherits="PlacementProjV1.WebForm23" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Select Member to Transfer Rights To<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Delegate" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</asp:Content>

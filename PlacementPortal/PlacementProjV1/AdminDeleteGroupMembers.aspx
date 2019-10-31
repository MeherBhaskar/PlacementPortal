<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminDeleteGroupMembers.aspx.cs" Inherits="PlacementProjV1.WebForm21" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    Select Member to delete<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</asp:Content>

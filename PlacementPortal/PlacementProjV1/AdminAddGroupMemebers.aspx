<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminAddGroupMemebers.aspx.cs" Inherits="PlacementProjV1.WebForm18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <p>Select Member
        <asp:DropDownList ID="DDL1" runat="server" style="margin-bottom: 0px">
        </asp:DropDownList>
    </p>
    <asp:Button ID="AddMem" text="Add Member" runat="server" OnClick="AddMem_Click" />
    <br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StudentSignup.aspx.cs" Inherits="PlacementProjV1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        Registration Number :
        <asp:TextBox ID="RegNo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="RegNo" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        Name :
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="Name" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        Password :
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="Password" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    
    <p>
        Branch :
        <asp:DropDownList ID="Branch" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        CGPA :
        <asp:TextBox ID="CGPA" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="CGPA" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>

    </p>
    <p>
        Number of Backlogs :
        <asp:TextBox ID="NumBacklogs" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="NumBacklogs" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
     <p>
        Email ID :
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="Email" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>

         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="Email" runat="server" ErrorMessage="Enter valid Email ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

    </p>
     <p>
        Phone Number:
        <asp:TextBox ID="PhoneNum" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="PhoneNum" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>

         <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="PhoneNum"  ErrorMessage="Enter valid phone number" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>

    </p>
    <p>
        <asp:Button ID="SignupBtn" runat="server" Text="Sign Up" OnClick="SignupBtn_Click" />
    </p>
    <p>
        &nbsp;</p>

</asp:Content>

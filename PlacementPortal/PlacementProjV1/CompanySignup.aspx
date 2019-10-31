<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CompanySignup.aspx.cs" Inherits="PlacementProjV1.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Comapny Name:
    <asp:TextBox ID="CName" runat="server" Width="118px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="CName" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
     Profile Name:
    <asp:TextBox ID="ProfileName" runat="server" Width="118px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="ProfileName" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    Offer type:
    <asp:DropDownList ID="OfferList" runat="server" style="margin-bottom: 0px">
     
    </asp:DropDownList>
    <br />
    CTC:
    <asp:TextBox ID="CTC" runat="server" Width="118px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="CTC" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    Location:
    <asp:TextBox ID="Location" runat="server" Width="118px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="Location" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    Minimum CGPA :
    <asp:TextBox ID="CGPA" runat="server" Width="117px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="CGPA" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    Minimum 10th percentage:
    <asp:TextBox ID="MinTen" runat="server" Width="118px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="MinTen" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    Minimum 12th Percentage:
    <asp:TextBox ID="MinTwelve" runat="server" Width="118px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="MinTwelve" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    Number of backlogs allowed:
    <asp:TextBox ID="NumBacks" runat="server" Width="118px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="NumBacks" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
   
    OT Date:
    <asp:Calendar ID="OT_date" AutoPostBack="false" runat="server" Width="118px"></asp:Calendar>
     
    <br />
    Process Date:
    <asp:Calendar ID="Process_date" AutoPostBack="false" runat="server" Width="118px"></asp:Calendar>
    <br /> 
    Description Link:
    <asp:TextBox ID="DescriptionLink" runat="server" Width="118px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="CTC" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    
    Branches Allowed:<asp:CheckBoxList ID="BranchList" runat="server">
    </asp:CheckBoxList>
    <br />
    Password:
    <asp:TextBox ID="Password" runat="server" Width="118px" TextMode="Password"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="Password" ErrorMessage="Required Field" runat="server" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />    
    <asp:Button ID="Signup" runat="server" Text="SignUp" OnClick="Signup_Click1" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </asp:Content>

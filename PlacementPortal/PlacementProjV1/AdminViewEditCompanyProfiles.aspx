<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminViewEditCompanyProfiles.aspx.cs" Inherits="PlacementProjV1.WebForm25" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsView1" runat="Server" CellPadding="4" ForeColor="#333333" GridLines="None"
     Width="100%" DataSourceID="SqlDataSource1" AllowPaging="true" AutoGenerateRows="True" 
      AutoGenerateEditButton="True" >
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:DetailsView>

// SqlDataSource control
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:DB %>'
     SelectCommand="Select Company_UID, Company_Name, CTC, Location, CGPA, Tenth_Percentage, Twelth_Percentage, Num_Backlogs, Offer_Type, Profile_Name, Password, DescriptionLink from CompanyDetails"
     UpdateCommand="UPDATE CompanyDetails SET Company_Name = @Company_Name, CTC=@CTC, Location = @Location, CGPA = @CGPA, Tenth_Percentage = @Tenth_Percentage, Twelth_Percentage = @Twelth_Percentage ,Num_Backlogs = @Num_Backlogs, Offer_Type = @Offer_Type, Profile_Name = @Profile_Name, Password = @Password, DescriptionLink = @DescriptionLink WHERE Company_UID = @Company_UID">    
     </asp:SqlDataSource>
</asp:Content>
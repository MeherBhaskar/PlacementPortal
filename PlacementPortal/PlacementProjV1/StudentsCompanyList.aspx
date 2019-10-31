<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StudentsCompanyList.aspx.cs" Inherits="PlacementProjV1.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="label1" runat ="server" />
    <asp:GridView ID="gvSortingPaging" EnableSortion ="true" DataKeyNames ="Company_UID" EnablePersistedSelection="true" onselectedindexchanged="gv_SelectedIndexChanged" runat="server" DataSourceID ="SqlDataSource1" BorderColor="#999999" AutoGenerateColumns="False" BorderWidth="1px" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="true" AllowPaging="true" PageSize="20">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:TemplateField HeaderText="Company UID" SortExpression ="Company_UID">
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Company_UID") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
        <asp:TemplateField HeaderText="Company Name" sortExpression="Company_Name" >
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("Company_Name") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
        <asp:TemplateField HeaderText="CTC" sortExpression="CTC" >
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Eval("CTC") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
        <asp:TemplateField HeaderText="Location" sortExpression="Location" >
            <ItemTemplate>
                <asp:Label ID="Label6" runat="server" Text='<%# Eval("Location") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="Minimum CGPA" sortExpression="CGPA">
            <ItemTemplate>
                <asp:Label ID="Label7" runat="server"  Text='<%# Eval("CGPA") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
        <asp:TemplateField HeaderText="Minimum 10th% " sortExpression="Tenth_Percentage" >
            <ItemTemplate>
                <asp:Label ID="Label8" runat="server" Text='<%# Eval("Tenth_Percentage") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
        <asp:TemplateField HeaderText="Minimum 12th%" sortExpression="Twelth_Percentage" >
            <ItemTemplate>
                <asp:Label ID="Label9" runat="server" Text='<%# Eval("Twelth_Percentage") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>

        <asp:TemplateField HeaderText="NUmber of Backlogs Allowed" sortExpression="Num_Backlogs">
            <ItemTemplate>
                <asp:Label ID="Label10" runat="server" Text='<%# Eval("Num_Backlogs") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Offer Type" sortExpression="Offer_Type">
            <ItemTemplate>
                <asp:Label ID="Label11" runat="server"  Text='<%# Eval("Offer_Type") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
        <asp:TemplateField HeaderText="OT Date" SortExpression ="Company_UID">
            <ItemTemplate>
                <asp:Label ID="Label12" runat="server" DataFormatString="{0:d}" Text='<%# Eval("OT_date") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
         <asp:TemplateField HeaderText="Process Date" SortExpression ="Company_UID" >
            <ItemTemplate>
                <asp:Label ID="Label13" runat="server" DataFormatString="{0:MM/dd/yy}" Text='<%# Eval("Process_date") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
        <asp:TemplateField HeaderText="Description Link" sortExpression="Offer_Type">
            <ItemTemplate>
                
                   <asp:LinkButton ID="hyp1" runat="server" Text="View" CommandArgument='<%# Bind("DescriptionLink") %>' />
            </ItemTemplate>
       </asp:TemplateField>
      <asp:CommandField ShowSelectButton="True" ButtonType ="Button" SelectText="Apply For This Company" />

   </Columns>
    <EditRowStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
</asp:GridView>

<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB %>"
SelectCommand="Select Company_UID, Company_Name, CTC, Location, CGPA, Tenth_Percentage, Twelth_Percentage, Num_Backlogs, Offer_Type, OT_date, Process_date, DescriptionLink from CompanyDetails" />
    <br />
   
</asp:Content>

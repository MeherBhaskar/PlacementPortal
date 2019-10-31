<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CompanyStudentResume.aspx.cs" Inherits="PlacementProjV1.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <p>Group Details</p>
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging ="true" 
              AutoGenerateRows="True" DataKeyNames="Group_ID"
              DataSourceID="Details" Height="50px" Width="301px">
        <headerstyle backcolor="Navy"
            forecolor="White"/>
            
          <pagersettings mode="NextPreviousFirstLast"
            firstpagetext="First"
            lastpagetext="Last"
            nextpagetext="Next"
            previouspagetext="Prev"/>
            
          <pagerstyle forecolor="White"
            backcolor="Blue"
            font-names="Arial"
            font-size="8" />   
       

            </asp:DetailsView>


    <asp:SqlDataSource ID="Details" runat="server"  ConnectionString="<%$ ConnectionStrings:DB %>" SelectCommand="SELECT * FROM MemberGroup M JOIN Groups G ON M.Group_ID=G.Group_ID WHERE RegNo=@RegNo">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="RegNo" Name="RegNo" />
            </SelectParameters>
            </asp:SqlDataSource>

    


    
</asp:Content>

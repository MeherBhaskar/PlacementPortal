<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminViewGroups.aspx.cs" Inherits="PlacementProjV1.WebForm22" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
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
        </asp:detailsview>

            </asp:DetailsView>


    <asp:SqlDataSource ID="Details" runat="server"  ConnectionString="<%$ ConnectionStrings:DB %>" SelectCommand="SELECT * FROM Groups"/>

</asp:Content>

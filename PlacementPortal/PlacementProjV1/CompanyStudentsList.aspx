<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CompanyStudentsList.aspx.cs" Inherits="PlacementProjV1.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv" EnableSortion ="true" DataKeyNames ="RegNo" onselectedindexchanged="gv_SelectedIndexChanged" EnablePersistedSelection="true" runat="server" BorderColor="#999999" AutoGenerateColumns="False" BorderWidth="1px" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="true" AllowPaging="true" PageSize="20">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:TemplateField HeaderText="Student Regitration Number" SortExpression ="RegNo">
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("RegNo") %>'></asp:Label>
         </ItemTemplate>
       </asp:TemplateField>
       
      <asp:CommandField ShowSelectButton="True" ButtonType ="Button" SelectText="View student resume" />

   </Columns>
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
</asp:GridView>

    <br />
    <br />
    View Different Student Groups Here :&nbsp; <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Student Groups" />

</asp:Content>

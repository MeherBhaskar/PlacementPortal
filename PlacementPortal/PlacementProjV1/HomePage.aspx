<%@ Page Language="C#" StyleSheetTheme="Theme1"  AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PlacementProjV1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
            <h1 align ="center">Welcome To MIT Placement Portal</h1>
            <p align ="center">
                <asp:Button  ID="Button1" runat="server" Text="Student Portal" OnClick="Button1_Click" />
            </p>
            <p align ="center">&nbsp;<asp:Button ID="Button2" runat="server" Text="Company Portal" OnClick="Button2_Click" />
            </p>
            <p align ="center">
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Admin Login" />
            </p>
        
        </div>
    </form>
</body>
</html>

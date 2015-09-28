<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionExample.aspx.cs" Inherits="ASPVariables.SessionExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <asp:Button ID="btnSaveFirstName" runat="server" OnClick="btnSave_Click" Text="Save First Name" />
    </form>
</body>
</html>

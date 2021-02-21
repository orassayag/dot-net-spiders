<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="getAddress1" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="getAddress2" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="getAddress3" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="getAddress4" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="getAddress5" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="getAddress6" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="getAddress7" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="getAddress8" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="getAddress9" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="getAddress10" runat="server" Width="500px"></asp:TextBox>
        <br />
        <asp:Button ID="runJob" runat="server" OnClick="runJob_Click" Text="Run!" Width="200px" />
        <br />
        <asp:Label ID="doneLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="totalLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>

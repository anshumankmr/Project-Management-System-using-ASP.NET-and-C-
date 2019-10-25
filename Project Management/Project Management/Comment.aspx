<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comment.aspx.cs" Inherits="Project_Management.Comment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">

            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter the comment"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
&nbsp;<br />
            <asp:Label ID="Label2" runat="server" Text="Enter the project ID"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />

        <asp:button ID="btn" runat="server" text="Confirm" OnClick="Unnamed1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
&nbsp;
        </div>
    </form>
</body>
</html>


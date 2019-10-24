<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="Project_Management.AddProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
                 <asp:Label ID="Label1" runat="server" Text="Project Details"></asp:Label></div>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter the project title"></asp:Label>

             &nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="ProjectName" runat="server" style="margin-bottom: 0px"></asp:TextBox>

             <br />
             <br />
             Enter the client&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="Client" runat="server" Width="168px"></asp:TextBox>

             <br />
             <br />
             Enter the duration&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="TextBox1" runat="server" Width="164px"></asp:TextBox>
             <br />
             <br />
             <br />
            <br />
        </div>
    </form>
</body>
</html>

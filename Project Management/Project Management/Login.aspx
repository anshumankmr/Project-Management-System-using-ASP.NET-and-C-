<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project_Management.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Project Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">

            <br />
  WELCOME TO THE TASK MANAGEMENT SYSTEM<br />
            <asp:Label ID="Label1" runat="server" Text="Enter Your Username">

            </asp:Label>       
            <br />
            &nbsp<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter Your Password<br />
            &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            &nbsp;
            <asp:Button ID="ButtonLogin" runat="server" OnClick="Button1_Click" Text="Login" style="width: 60px" />
             <br />
         <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
        
    </form>
</body>
</html>

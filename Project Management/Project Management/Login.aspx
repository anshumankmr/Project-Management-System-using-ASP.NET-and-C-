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
            <br />
            <br />
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
            <asp:Button ID="ButtonLogin" runat="server" OnClick="Button1_Click" Text="Login" style="width: 60px" SkinID="Button"/>
             <br />
         <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <asp:RequiredFieldValidator ID="username_required" Display="None" runat="server" ControlToValidate="TextBox1" ErrorMessage="Username is mandatory!" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="password_required" Display="None" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password is mandatory!" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        
    </form>
</body>
</html>

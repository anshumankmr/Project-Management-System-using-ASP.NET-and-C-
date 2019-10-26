<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="Project_Management.AddProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="margin-left: auto; margin-right: auto; text-align: center;">

            <asp:Panel ID="Panel1" runat="server" BackColor="LightBlue">Enter the Project Details:
                             
            </asp:Panel>
             </div>
            <asp:Label ID="Label1" runat="server" Text="Enter the title of the project"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the name of the client&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the expected duration of the project&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the initial status of the project&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
       
            
            <br />
       
            
            <br />
       
            
            <asp:Button ID="EnterButton" runat="server" Text="Create Project" OnClick="EnterButton_Click"  />
            &nbsp;<asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <br />
            <br /><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go Back To Admin Page" PostBackUrl="~/Admin.aspx" />
            <br />
            <br />
            <br />
            <div style="margin-left: auto; margin-right: auto; text-align: center;">

            <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
             </div>
            
            <br />
            <br />
        </div>
    </form>
</body>
</html>

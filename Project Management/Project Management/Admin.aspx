<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Project_Management.Admin"   %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        
            <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Panel ID="Panel1" runat="server" BackColor="LightBlue">Admin's WebPage:
            </asp:Panel>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <br />
            <br />
            <asp:Button ID="CreateButton" runat="server" Text="Create a New Project" OnClick="Button1_Click" PostBackUrl="AddProject.aspx" />
            <br />
            <br />
            <asp:Button ID="ViewProjectButton" runat="server" Text="View Project Details" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="UpdateProjectButton" runat="server" Text="Update Project Details" OnClick="Button3_Click" PostBackUrl ="UpdateProjectDetails.aspx"/>
            <br />
            <br />
            <asp:Button ID="ApproveCommentsButton" runat="server" Text="Approve Project Comments" OnClick="Button4_Click" />
            <br />
            <br />
           
            <asp:Button ID="GenerateReportButton" runat="server" Text="Generate A Report" OnClick="Button5_Click" />
            <br />
            <br />
             <br />
            <br />
             <br />
            <br />
            <asp:GridView ID="GridView1"  runat="server">
            </asp:GridView>
        </div>
        
    </form>
    
</body>
</html>

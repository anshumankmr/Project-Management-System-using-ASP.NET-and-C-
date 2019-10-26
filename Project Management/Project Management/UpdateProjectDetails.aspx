<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProjectDetails.aspx.cs" Inherits="Project_Management.UpdateProjectDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
             <div style="margin-left: auto; margin-right: auto; text-align: center;">

            <asp:Panel ID="Panel1" runat="server" BackColor="LightBlue">Update Your Project Detailss:
                             
            </asp:Panel>
        
                 <br />
        
            <asp:Label ID="ProjectTitle" runat="server" Text="Enter the Project Title"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox id="TextBox1" runat="server" />
               <br />
                 <br />
                 <asp:Label ID="Label2" runat="server" Text="OR"></asp:Label>
                 <br />
            <br />
             <asp:Label ID="Label1" runat="server" Text="Enter The Project ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox id="TextBox2" runat="server" />

           &nbsp;<br />
                 <br />

           <asp:CustomValidator ID="CV1" runat="server"  OnServerValidate="ServerValidate" ErrorMessage=" One Of Two Required" />


                 <br />
                 <br />
                 <asp:Button ID="Button1" runat="server" Text="Click To Search" OnClick="Button1_Click" />
                 <br />
                 <br />
                 <asp:GridView ID="GridView1" runat="server">
                 </asp:GridView>
                 <br />
                 <br />
                 <asp:Label ID="Label3" runat="server" Text="Would You Like To Update the Values?"></asp:Label>
                 <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" TextAlign="Right" AutoPostBack ="true">
                 </asp:RadioButtonList>
                 <br />
                 <asp:Label ID="Label4" runat="server" Text="Enter the remaining duration "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Label ID="Label5" runat="server" Text="Insert The Updated Status"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                 <br />
                 <br />
                 <br />
                 <asp:Button ID="Button2" runat="server" Text="Confirm" OnClick="Button2_Click" />
                 &nbsp;&nbsp;
                 <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                 <br />
                 <br />
        </div>
    </form>
</body>
</html>

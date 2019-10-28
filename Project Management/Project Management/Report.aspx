<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="Project_Management.Report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1"> </asp:RequiredFieldValidator>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            

        </div>
    </form>
</body>
</html>

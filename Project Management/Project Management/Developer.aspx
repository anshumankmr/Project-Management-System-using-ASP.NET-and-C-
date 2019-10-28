<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Developer.aspx.cs" Inherits="Project_Management.Developer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
         <div style="margin-left: auto; margin-right: auto; text-align: center;">
                <asp:Panel ID="Panel1" runat="server" BackColor="LightBlue">
                    Developer&#39;s WebPage:
                </asp:Panel>
            
             <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
             
                <br />
                <br />
             
            <br />
            <asp:Button ID="Button1" runat="server" Text="Make A Comment" OnClick="Button1_Click" SkinID="Button" />

                <br />
                <br />
             <asp:Button ID="Button2" runat="server" Text="View Comments" Width="187px" OnClick="Button2_Click" SkinID="Button" />


                <br />
                <br />
                <asp:Button ID="Button3" runat="server" Height="29px" Text="View Project Details" OnClick="Button3_Click" />


        </div>
    </form>
</body>
</html>

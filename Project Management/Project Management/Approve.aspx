<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Approve.aspx.cs" Inherits="Project_Management.Approve" MasterPageFile="Site1.Master" %>
<asp:Content ID ="content2" ContentPlaceHolderID ="cph1" runat="server">
   


                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"   
                        DataKeyNames="CommentId">  
                        <Columns>  
                            <asp:TemplateField HeaderText="Comment_ID">  
                               <EditItemTemplate>  
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CommentID") %>'></asp:TextBox>  
                                </EditItemTemplate>  
                                <ItemTemplate>  
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("CommentID") %>'></asp:Label>  
                                </ItemTemplate>
                            </asp:TemplateField>  
                            <asp:TemplateField HeaderText="Text">  
                              <EditItemTemplate>  
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Text") %>'></asp:TextBox>  
                                </EditItemTemplate>  
                                <ItemTemplate>  
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Text") %>'></asp:Label>  
                                </ItemTemplate> 
                            </asp:TemplateField>  
                            <asp:TemplateField HeaderText="Project">  
                                <EditItemTemplate>  
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("ProjectID") %>'></asp:TextBox>  
                                </EditItemTemplate>  
                                <ItemTemplate>  
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("ProjectID") %>'></asp:Label>  
                                </ItemTemplate>  
                            </asp:TemplateField>  
                            <asp:TemplateField>  
                                <EditItemTemplate>  
                                    <asp:CheckBox ID="CheckBox1" runat="server" />  
                                </EditItemTemplate>  
                                <ItemTemplate>  
                                    <asp:CheckBox ID="CheckBox1" runat="server" />  
                                </ItemTemplate>  
                            </asp:TemplateField>  
                        </Columns>  
                    </asp:GridView>  
               
                    <br />
               
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Delete" />  
                
      
    
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
 
        <%--<h1>Login</h1>--%>
    <asp:Label ID="UsernameLabel" runat="server" Text="Username:" AssociatedControlID="UsernameTextBox"></asp:Label><br/>
    <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox><br/>

    <asp:Label ID="PasswordLabel" runat="server" Text="Password:"  AssociatedControlID="PasswordTextBox"></asp:Label><br/>
    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox><br/>

    <asp:Button ID="LoginButton" runat="server" Text="Login"  OnClick="LoginButton_Click"  /><br/>

    <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
  
</asp:Content>


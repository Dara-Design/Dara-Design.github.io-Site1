<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <% if (Request.IsAuthenticated)
        { %>
     <asp:Panel ID="Panel1" runat="server">
        <asp:Button ID="NewButton" runat="server" Text="New" PostBackUrl="Product.aspx?mode=new"/>
    </asp:Panel>
     <% } %>
    <asp:Panel ID="ProductContainer" CssClass="ProductContainer" runat="server"></asp:Panel>
</asp:Content>


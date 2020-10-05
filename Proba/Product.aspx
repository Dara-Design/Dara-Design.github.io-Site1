<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h1 runat="server" id="PageHeading"></h1>
    <asp:label ID="ProductNameLabel" runat="server" text="Product name:"></asp:label> <br />
    <asp:Textbox ID="ProductNameTextBox" runat="server"></asp:Textbox> <br />

     <asp:label ID="ProductCategoryLabel" runat="server" text="Product category:"></asp:label> <br />
    <asp:Textbox ID="ProductCategoryTextBox" runat="server"></asp:Textbox> <br />

    <asp:label ID="ProductDescriptionLabel" runat="server" text="Product description:"></asp:label> <br />
    <textarea id="ProductDescriptionTextArea" cols="20" runat="server" rows="2"></textarea>

    <asp:Hiddenfield  ID="IdHiddenfield" runat="server"></asp:Hiddenfield>

    <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
   

</asp:Content>


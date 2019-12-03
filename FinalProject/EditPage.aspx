<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="FinalProject.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <a href="ManagePages.aspx" class="back">Back to Manage</a>
    <h1>Update <span id="page_header" runat="server"></span> </h1>
    <div id="page_update" class="crud" runat="server">    
        <div class="input">
            <label>Page Title:</label>
            <asp:TextBox runat="server" ID="new_page_title" class="big_title"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="new_title_validator" ControlToValidate="new_page_title" ErrorMessage="PLEASE ENTER A TITLE FOR YOUR PAGE!"></asp:RequiredFieldValidator>
        </div>
        <div class="input">
            <label>Page Content:</label>
            <asp:TextBox runat="server" ID="new_page_content" class="big_text"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="new_content_validator" ControlToValidate="new_page_content" ErrorMessage="PLEASE ENTER SOME CONTENT FOR YOUR PAGE!"></asp:RequiredFieldValidator>
        </div>

        <div id ="delete_update">     
            <asp:Button OnClick="Update_Page" Text="Update" runat="server" class="bttn" />
            <Asp:Button OnClientClick="if(!confirm('Are you sure you want to delete this page?')) return false;" OnClick="Delete_Page" Text="Delete" runat="server" class="bttn"/>
        </div>
        <div class="viewnav">
            <a class="left" href="ManagePages.aspx">Cancel</a>
        </div>
    </div>
</asp:Content>

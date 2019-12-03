<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="FinalProject.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <h1>Update <span id="page_header" runat="server"></span> </h1>
    <div id="page_update" class="crud" runat="server">    
        <div class="input">
            <label>Page Title:</label>
            <asp:TextBox runat="server" ID="new_page_title"></asp:TextBox>
        </div>
        <div class="input">
            <label>Page Content:</label>
            <asp:TextBox runat="server" ID="new_page_content" class="big_text"></asp:TextBox>
        </div>
        <div>
            <asp:Button OnClick="Update_Page" Text="Update" runat="server" />
        </div>
        <div>
             <Asp:Button OnClientClick="if(!confirm('Are you sure you want to delete this page?')) return false;" OnClick="Delete_Page" CssClass="right spaced" Text="Delete" runat="server"/>
        </div>
        <div class="viewnav">
            <a class="left" href="ManagePages.aspx">Cancel</a>
        </div>
    </div>
</asp:Content>

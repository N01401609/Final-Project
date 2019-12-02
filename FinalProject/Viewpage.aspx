<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Viewpage.aspx.cs" Inherits="FinalProject.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <div id="view_page" runat="server">
        <h2><span id="page_title" runat="server"></span></h2>
        <span id="page_content" runat="server"></span><br />
        <Asp:Button OnClientClick="if(!confirm('Are you sure you want to delete this?')) return false;" OnClick="Delete_Page" CssClass="right spaced" Text="Delete" runat="server"/>
    </div>
</asp:Content>

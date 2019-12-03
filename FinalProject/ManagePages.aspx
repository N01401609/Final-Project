<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ManagePages.aspx.cs" Inherits="FinalProject.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <h1>Manage Pages</h1>
    <div id="new_page" >
        <asp:Button runat="server" Text="New Page" class ="bttn" PostBackUrl="AddPage.aspx" />
    </div>
    <div class="_table" runat="server">
        <div class="listitem" id ="titles">
            <div class="colfirst">PAGE TITLE</div>
            <div class="col">VIEW</div>
            <div class="col">EDIT</div>
        </div>
        <div id="result" runat="server"></div>
    </div>

</asp:Content>
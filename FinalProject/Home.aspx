<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalProject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <h1 id="landing_title">Welcome to the Create Lounge</h1>
    <p>Create the page you wish in no time! Press manage pages and let the creating begin!</p>
    <div id="home_page" >
        <asp:Button runat="server" Text="Manage Pages" class ="bttn" PostBackUrl="ManagePages.aspx" />
    </div>
</asp:Content>

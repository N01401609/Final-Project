<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddPage.aspx.cs" Inherits="FinalProject.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <h1>ADD NEW PAGE</h1>
    <div class="crud">
        <div class="input">
            <label>Page Title:</label>
            <asp:TextBox runat="server" ID="page_title" ></asp:TextBox>
        </div>
        <div class="input">
            <label>Page Content:</label>
            <asp:TextBox runat="server" ID="page_content" class="big_text"></asp:TextBox>
        </div>
        <div>
            <asp:Button runat="server" text="Create" OnClick="Add_Page" />
        </div>
    </div>
</asp:Content>

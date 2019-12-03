<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddPage.aspx.cs" Inherits="FinalProject.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <a href="ManagePages.aspx" class="back">Back to Manage</a>
    <h1>ADD NEW PAGE</h1>
    <div class="crud">
        <div class="input">
            <label>Page Title:</label>
            <asp:TextBox runat="server" ID="page_title" class="big_title" ></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="validate_title" ControlToValidate="page_title" ErrorMessage="PLEASE ENTER A TITLE FOR YOUR PAGE!"></asp:RequiredFieldValidator>
        </div>
        <div class="input">
            <label>Page Content:</label>
            <asp:TextBox runat="server" ID="page_content" class="big_text"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="validate_body" ControlToValidate="page_content" ErrorMessage="PLEASE ENTER SOME CONTENT FOR YOUR PAGE!"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Button runat="server" text="Create" OnClick="Add_Page" class="bttn" />
        </div>
    </div>
</asp:Content>

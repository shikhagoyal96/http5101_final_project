<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addpage.aspx.cs" Inherits="HTTP_5101_FinalProject_N01329988.addpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ADD NEW SEASON</h2>  

    <div id="main_content">
        <div class="row">
            <label for="season_title">Season Title : </label>
            <asp:TextBox runat="server" ID="season_title"></asp:TextBox>
        </div>
        <div class="row">
            <label for="season_body">Season Body : </label>
            <asp:TextBox runat="server" ID="season_body"></asp:TextBox>
        </div>
    </div>

       
    <asp:Button OnClick="Add_Page" Text="Add Season" runat="server" />
 
</asp:Content>

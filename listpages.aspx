<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listpages.aspx.cs" Inherits="HTTP_5101_FinalProject_N01329988.listpages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <h2>LIST OF SEASONS</h2>
     
    <div id="main_content"> 
        <div id="result_season" runat="server"></div>
    </div>
    
    <asp:Button runat="server"  Text="Add Season" PostBackUrl="~/addpage.aspx" />    

</asp:Content>

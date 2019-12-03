<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showpage.aspx.cs" Inherits="HTTP_5101_FinalProject_N01329988.showpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>PARTICULAR SEASON DETAILS</h2>

    <div id="main_content" runat="server">
        
       
        <p>Season Title : </p><span id="s_title" runat="server"></span><br />
        
        <p>Season Body : </p><span id="s_body" runat="server"></span>
           
    </div>
    
    <asp:Button runat="server" OnClick="Delete_Season" Text="Delete Season"  />
    
    <a href="editpage.aspx?seasonid=<%=Request.QueryString["seasonid"] %>">Update</a>
    
</asp:Content>

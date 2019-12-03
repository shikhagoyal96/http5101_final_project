<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="editpage.aspx.cs" Inherits="HTTP_5101_FinalProject_N01329988.editpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EDIT DETAILS</h2>

     <div id="main_content" runat="server"> 
        
             <div class="row">
                <label>Season Title : </label>
                <asp:TextBox ID="s_title" runat="server"></asp:TextBox>
             </div>
             <div class="row">
                <label>Season Body : </label>
                <asp:TextBox ID="s_body" runat="server"></asp:TextBox>
            </div>
       
    </div>
    
    <asp:Button OnClick="Update_Page" Text="Update details" runat="server" />

</asp:Content>

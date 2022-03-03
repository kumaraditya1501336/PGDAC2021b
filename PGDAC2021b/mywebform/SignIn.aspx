<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="PGDAC2021b.mywebform.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
    </asp:Login>
</asp:Content>

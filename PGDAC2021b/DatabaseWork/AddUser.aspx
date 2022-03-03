<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="Pgdac_Web.DataBaseWork.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <strong>
        <br />
        ADD New User</strong></p>
    <table style="width: 100%; height: 128px; border-color: #99FFCC; background-color: #CCFFCC">
        <tr>
            <td><strong></strong></td>
            <td><strong></strong></td>
        </tr>
        <tr>
            <td><strong>User Name</strong></td>
            <td><strong>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td><strong>Password</strong></td>
            <td><strong>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td><strong>Full Name</strong></td>
            <td><strong>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td><strong>Mobile</strong></td>
            <td><strong>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td><strong></strong></td>
            <td><strong>
                <asp:Button ID="btnSave" runat="server" Text="Add User" Width="101px" />
                </strong></td>
        </tr>
        <tr>
            <td><strong></strong></td>
            <td><strong></strong></td>
        </tr>
    </table>
    <p>
    </p>
</asp:Content>
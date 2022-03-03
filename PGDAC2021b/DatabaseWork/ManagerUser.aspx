<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" Async="true" AutoEventWireup="true" CodeBehind="ManagedUser.aspx.cs" Inherits="Pgdac_Web.DataBaseWork.ManagedUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <p>
        <strong>
        <br />
        </strong>
    </p>
    <table style="width: 100%; height: 128px; border-color: #99FFCC; background-color: #CCFFCC">
        <tr>
            <td><strong>Managed User</strong></td>
            <td><strong></strong></td>
        </tr>
        <tr>
            <td><strong>User Id</strong></td>
            <td><strong>
                <asp:TextBox ID="txtUserID" runat="server" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td><strong>User Name</strong></td>
            <td><strong>
                <asp:TextBox ID="txtUserName" runat="server" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="btnSearch_Click" Text="Find User" Width="104px" />
                </strong></td>
        </tr>
        <tr>
            <td><strong>Password</strong></td>
            <td><strong>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td style="height: 22px"><strong>Full Name</strong></td>
            <td style="height: 22px"><strong>
                <asp:TextBox ID="txtName" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td><strong>Mobile</strong></td>
            <td><strong>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td><strong>
                <asp:Button ID="Button2" runat="server" OnClick="btnUpdate_Click()" Text="Update User" Width="138px" />
                </strong></td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Delete User" Width="125px" />
                <asp:Button ID="Button4" runat="server" Text="View All Users" Width="135px" />
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>






</asp:Content>
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Calculator.aspx.cs" Inherits="PGDAC2021b.mywebform.Calculator" %>


    
    

    <asp:Content ID="CalId" ContentPlaceHolderID="MainContent" runat="server">
    <%--<form id="form1" runat="server">--%>
        <div>
            <h1>Working with ASP.NET </h1>
            <table align="center" class="auto-style1">
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td><strong>First Number</strong></td>
                    <td>
                        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><strong>Second Number</strong></td>
                    <td>
                        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>Third Number</strong></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtNum3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2">
                        <asp:Button ID="btnAdd" runat="server" Text="Add Values" 
                            BackColor="#99FFCC" ForeColor="#CC3300" 
                            OnClick="btnAdd_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" 
                            style="font-weight: 700"></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    <%--</form>--%>
    
        </asp:Content>


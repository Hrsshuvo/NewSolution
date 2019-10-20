<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Supply.aspx.cs" Inherits="NwProject.Supply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table cellpadding="5" cellspacing="5" class="nav-justified" style="width: 31%; border: 5px solid #00FFFF; margin-left: 512px; background-color: #2E6DA4">
        <tr>
            <td class="text-center" colspan="2">Add Supplyer</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 272px">Name</td>
            <td style="width: 477px">
                <asp:TextBox ID="txtName" runat="server" style="margin-left: 0px" Width="256px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 272px">Email</td>
            <td style="width: 477px">
                <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 0px" Width="256px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 272px">Phone</td>
            <td style="width: 477px">
                <asp:TextBox ID="txtPhone" runat="server" style="margin-left: 0px" Width="256px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 272px">Address</td>
            <td style="width: 477px">
                <asp:TextBox ID="txtAddress" runat="server" style="margin-left: 0px" Width="256px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 272px">Notes</td>
            <td style="width: 477px">
                <asp:TextBox ID="txtNotrs" runat="server" style="margin-left: 0px" Width="256px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </td>
        </tr>
    </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server" Font-Underline="True" OnClick="LinkButton1_Click">Go To Supplyer List....=>> </asp:LinkButton>
</asp:Content>

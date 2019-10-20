<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="NwProject.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <script src="Scripts/jquery-3.3.1.min.js"></script>
<%--    <script type="text/javascript" src="https://cdn.datatables.net/v/dt/dt-1.10.18/datatables.min.js"></script>--%>
    <script src="https://cdn.datatables.net/1.10.13/js/jquery.dataTables.min.js"></script>
    <link href="https://cdn.datatables.net/1.10.13/css/jquery.dataTables.min.css" rel="stylesheet"/>
    <script>
        $(function () {
            $("#GridView1").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
    <table class="nav-justified" style="width: 39%; border: 5px solid #00FFFF; margin-left: 470px; margin-top:10px; background-color: #2E6DA4">
        <tr>
            <td class="text-center" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Add Category" Font-Bold="True" Font-Size="Larger"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 111px">Name</td>
            <td class="text-center">
                <asp:TextBox ID="txtName" runat="server" style="margin-left: 0" Width="295px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 111px">Description</td>
            <td class="text-center">
                <asp:TextBox ID="txtDescription" runat="server" style="margin-left: 0" Width="295px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="text-center">
                <asp:Label ID="lblMessege" runat="server" Text=""></asp:Label>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </td>
        </tr>
    </table>
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Overline="True" Font-Strikeout="False" Font-Underline="True" OnClick="LinkButton1_Click">Go To List......</asp:LinkButton>
    </div>
</asp:Content>

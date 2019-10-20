<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateMedecine.aspx.cs" Inherits="NwProject.UpdateMedecine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <table cellpadding="5" cellspacing="5" class="nav-justified" style="width: 36%; border: 5px solid #00FFFF; margin-left: 474px; background-color: #D9EDF7">
        <tr>
            <td class="text-center" colspan="2">Add Medicine</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 102px">Category</td>
            <td class="text-center">
                <asp:DropDownList ID="dropCategory" runat="server" Height="25px" Width="279px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 102px">Shalf</td>
            <td class="text-center">
                <asp:DropDownList ID="drop_Shalf" runat="server" Height="25px" Width="279px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 102px">Name</td>
            <td class="text-center">
                <asp:TextBox ID="txtName" runat="server" Width="266px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 102px">Batch No.</td>
            <td class="text-center">
                <asp:TextBox ID="txtBatchNo" runat="server" Width="266px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 102px">Buying Price</td>
            <td class="text-center">
                <asp:TextBox ID="txtBuingPrice" runat="server" Width="266px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 102px">Selling Price</td>
            <td class="text-center">
                <asp:TextBox ID="txtSellingPrice" runat="server" Width="266px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 102px">&nbsp;</td>
            <td class="text-center">
                <asp:TextBox ID="txtQty" runat="server" Width="266px" Text="0" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                <asp:Button ID="btnAdd" runat="server" Text="Update" OnClick="btnAdd_Click" />
            </td>
        </tr>
    </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server" Font-Underline="True" OnClick="LinkButton1_Click">Go To List...===>></asp:LinkButton>

</asp:Content>

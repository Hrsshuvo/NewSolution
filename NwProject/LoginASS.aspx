<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginASS.aspx.cs" Inherits="NwProject.LoginASS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 37%;
            border: 5px solid #00FFFF;
            margin-left: 462px;
            background-color: #00FF00;
            vertical-align:central;
        }
        .auto-style4 {
            width: 71px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div class="auto-style1">
        <div class="auto-style1">
        <asp:Label ID="Label1" runat="server" Text="WelCome To Pharma Assistance Project" Font-Size="XX-Large"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Dattopara,Tongi,Gazipur" Font-Size="Large"></asp:Label>
        </div>
        <asp:Label ID="Label3" runat="server" Text="---------------------------------------------------------------------------------------------------------------------------" Font-Bold="True"></asp:Label>
        </div>
        <table style="grid-column-end" align="center" cellpadding="5" cellspacing="5" class="auto-style2">
            <tr>
                <td colspan="2" class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Login Form"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Email</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtEmail" runat="server" Width="236px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Passward</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPass" runat="server" Width="236px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style1">
                    <asp:Label ID="lblMessege" runat="server" Text=""></asp:Label>
                    <asp:Button ID="btnLog" runat="server" Text="Login" OnClick="btnLog_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

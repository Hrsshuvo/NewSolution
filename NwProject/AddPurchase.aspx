<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPurchase.aspx.cs" Inherits="NwProject.AddPurchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" cellpadding="5" cellspacing="5" class="nav-justified" style="width: 49%; height: 45px; border: 5px solid #00FFFF; background-color: #2E6DA4">
        <tr>
            <td class="text-center" style="width: 70px">Supplyer</td>
            <td style="width: 94px">
                <asp:DropDownList ID="dropSupplyer" runat="server" Height="17px" Width="128px" AutoPostBack="true">
                </asp:DropDownList>
            </td>
            <td style="width: 43px">Code</td>
            <td style="width: 132px">
                <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
            </td>
            <td style="width: 55px">Date</td>
            <td>
                <asp:TextBox ID="txtDate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
    </table>
    <div>

        <table class="nav-justified" style="height: 283px">
            <tr>
                <td class="text-center" style="width: 436px">
                    <table cellpadding="5" cellspacing="5" style="width: 100%; border: 5px solid #00FFFF; background-color: #2E6DA4">
                        <tr>
                            <td>Category</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="dropCategory" runat="server" Height="30px" Width="357px" OnSelectedIndexChanged="dropCategory_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Medicine</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DropDownList ID="dropMedicine" runat="server" Height="30px" Width="357px" OnSelectedIndexChanged="dropMedicine_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblProductPrice" runat="server" Text="PerMedicinePrice"></asp:Label>
&nbsp;:<asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="lblHaveQuantitus" runat="server" Text="Alredy Quanty"></asp:Label>
                                &nbsp;:<asp:Label ID="lblQuantity" runat="server" Text=""></asp:Label>
                            &nbsp;
                                <asp:Label ID="lblAllQty" runat="server" Text=""></asp:Label>
                            &nbsp;</td>
                        </tr>
                        <tr>
                            <td>Quantity</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtQuantity" runat="server" Width="341px"></asp:TextBox>
                                <br />
                                <asp:TextBox ID="txtMathod" runat="server" Width="341px" Text="None" Visible="False"></asp:TextBox>
                                <br />
                                <asp:TextBox ID="txtSatatus" runat="server" Width="341px" Text="None" Visible="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                            </td>
                        </tr>
                    </table>
                    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Style="margin-left: 172px; margin-top: 9px" Width="254px">
                        <Columns>
                            <asp:BoundField HeaderText="Name" DataField="Name" />
                            <asp:BoundField HeaderText="Quantity" DataField="Quantity" />
                            <asp:BoundField HeaderText="price" DataField="price" />
                            <asp:BoundField DataField="Total" HeaderText="Total" />
                        </Columns>
                    </asp:GridView>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label>
                    &nbsp;=
                    <asp:Label ID="lblAmmount" runat="server" Text=""></asp:Label>
                    <br />
                    <br />
                    <table style="width: 91%; border: 1px solid #00FF00; margin-left: 66px; background-color: #2E6DA4; margin-top: 49px;">
                        <tr>
                            <td class="text-left" colspan="2">Notes:</td>
                            <td style="width: 362px">&nbsp;</td>
                            <td class="text-center">Discount</td>
                            <td class="text-center">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2" rowspan="2" class="text-center">
                                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="319px"></asp:TextBox>
                            </td>
                            <td style="width: 362px">&nbsp;</td>
                            <td>
                                <asp:TextBox ID="txtDis" runat="server" Style="margin-left: 0px" Width="142px" OnTextChanged="txtdiscount_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 362px">&nbsp;</td>
                            <td class="text-center">Grand Total</td>
                            <td class="text-center">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="text-center" style="width: 2378px">Payment Mathod</td>
                            <td class="text-center" style="width: 1110px">Status</td>
                            <td style="width: 362px">&nbsp;</td>
                            <td>
                                <asp:TextBox ID="txtGranf" runat="server" Style="margin-left: 0px" Width="142px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="text-center" style="width: 2378px">
                                <asp:DropDownList ID="dropMathod" runat="server" Height="17px" Width="135px">
                                    <asp:ListItem Selected="False">Payment Mathod</asp:ListItem>
                                    <asp:ListItem Value="Cash"> Cash </asp:ListItem>
                                    <asp:ListItem Value="Check"> Check </asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="text-center" style="width: 1110px">
                                <asp:DropDownList ID="dropStatus" runat="server" Height="16px" Width="145px">
                                    <asp:ListItem Selected="False" Value="White"> <<<Select Status>>> </asp:ListItem>
                                    <asp:ListItem Value="Paid"> Paid </asp:ListItem>
                                    <asp:ListItem Value="Due"> Due </asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td style="width: 362px">&nbsp;</td>
                            <td class="text-center">
                                <asp:Label ID="lblTotalMessage" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="text-center">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 2378px">&nbsp;</td>
                            <td style="width: 1110px">&nbsp;</td>
                            <td style="width: 362px">&nbsp;</td>
                            <td class="text-center">
                                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                            </td>
                            <td class="text-center">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>

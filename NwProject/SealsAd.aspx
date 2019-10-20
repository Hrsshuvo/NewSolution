<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SealsAd.aspx.cs" Inherits="NwProject.SealsAd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" cellpadding="5" cellspacing="5" class="nav-justified" style="width: 49%; height: 45px; border: 5px solid #00FFFF; background-color: #2E6DA4">
        <tr>
            <td class="text-center" style="width: 70px">Customer Name</td>
            <td style="width: 94px">
                <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            </td>
            <td style="width: 43px">Code</td>
            <td style="width: 132px">
                <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
            </td>
            <td style="width: 55px">Date</td>
            <td class="text-center">
                <asp:TextBox ID="txtDate" runat="server" ReadOnly="true"></asp:TextBox>
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
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="lblHaveQuantitus" runat="server" Text="avilable Quanty"></asp:Label>
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
                                <asp:DropDownList ID="dropMathod" runat="server" Height="17px" Width="135px" OnSelectedIndexChanged="dropMathod_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Selected="False" Value="0">Payment Mathod</asp:ListItem>
                                    <asp:ListItem Value="1"> Cash </asp:ListItem>
                                    <asp:ListItem Value="2"> Check </asp:ListItem>
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
    <div class="text-right">

        <table id="tym" runat="server" align="right" cellpadding="5" cellspacing="5" style="width: 29%; border: 5px solid #FFFF00; background-color: #4CAE4C">
            <tr>
                <td colspan="3" class="text-center">
                    <asp:Label ID="lblHeader" runat="server" Text="Add Check Detals"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="text-center">
                    <asp:Label ID="lblBankName" runat="server" Text="Bank Name"></asp:Label>
                </td>
                <td class="text-center">

        <asp:DropDownList ID="dropBank" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="BankName" DataValueField="BankName">
        </asp:DropDownList>
                </td>
                <td class="text-center">

                    &nbsp;</td>
            </tr>
            <tr>
                <td class="text-center">
                    <asp:Label ID="lblAccountHolder" runat="server" Text="Account Holder Name:"></asp:Label>
                </td>
                <td class="text-center">
        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
                </td>
                <td class="text-center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="text-center">
                    <asp:Label ID="lblAccountNumber" runat="server" Text="Account Number:"></asp:Label>
                </td>
                <td class="text-center">
        <asp:TextBox ID="txt3" runat="server"></asp:TextBox>

                </td>
                <td class="text-center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="text-center">
                    <asp:Label ID="lblBankAddress" runat="server" Text="Branch Address:"></asp:Label>
                </td>
                <td class="text-center">
        <asp:TextBox ID="txt4" runat="server"></asp:TextBox>

                </td>
                <td class="text-center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="text-center">
                    <asp:Label ID="lblEDate" runat="server" Text="Expire Date:"></asp:Label>
                </td>
                <td class="text-center">
        <asp:TextBox ID="txtEDate" runat="server"></asp:TextBox>

                </td>
                <td class="text-center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" class="text-center">
                    <asp:Button ID="btnAAAA" runat="server" Text="Add Check" OnClick="btnAAAA_Click" />
                </td>
            </tr>
        </table>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaDbConnectionString %>" SelectCommand="SELECT [BankName] FROM [tbl_bank]"></asp:SqlDataSource>
        <br />
        <br />

    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="NwProject.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
        <tr>
            <td style="width: 22px">
                <asp:GridView ID="gridSupplyer" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaDbConnectionString %>" SelectCommand="SELECT [Name] FROM [tbl_Supply]"></asp:SqlDataSource>
            </td>
            <td style="width: 98px">
                <asp:GridView ID="gridShalf" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaDbConnectionString %>" SelectCommand="SELECT [Name] FROM [tbl_Shelf]"></asp:SqlDataSource>
            </td>
            <td class="modal-sm" style="width: 104px">
                <asp:GridView ID="gridMedicine" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaDbConnectionString %>" SelectCommand="SELECT [Name] FROM [tbl_Madecine]"></asp:SqlDataSource>
            </td>
            <td style="width: 133px">
                <asp:GridView ID="gridQuantity" runat="server" AutoGenerateColumns="False" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    </Columns>
                </asp:GridView>
                <br />
            </td>
            <td style="width: 91px">
                <asp:GridView ID="gridPurTotel" runat="server" AutoGenerateColumns="False" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="GrandTotal" HeaderText="GrandTotal" SortExpression="GrandTotal" />
                    </Columns>
                </asp:GridView>
                <br />
            </td>
            <td>
                <asp:GridView ID="gridSellsGd" runat="server" AutoGenerateColumns="False" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="GrandTotal" HeaderText="GrandTotal" />
                    </Columns>
                </asp:GridView>
                <br />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <div>

        <table align="center" cellpadding="5" cellspacing="6" style="width: 100%; border-style: solid; border-width: 5px; background-color: #5BC0DE">
            <tr>
                <td class="text-center" style="height: 115px; width: 67px">
                    &nbsp;</td>
                <td class="text-center" style="height: 115px; width: 264px">
                    <asp:Panel ID="Panel6" runat="server" BackColor="White" BorderColor="White" Height="81px" style="margin-left: 0px" Width="205px">
                        <div class="text-center">
                            <asp:Image ID="Image6" runat="server" Height="38px" ImageUrl="~/Image/businessman.png" Width="149px" />
                            <br />
                            <asp:Label ID="Label1" runat="server" BackColor="White" Text="TotalSupplyer:"></asp:Label>
                            <br />
                            <asp:Label ID="lblSupplyer" runat="server" BackColor="White"></asp:Label>
                            <br />
                        </div>
                    </asp:Panel>
                </td>
                <td style="height: 115px">
                    <asp:Panel ID="Panel2" runat="server" BackColor="White" Height="82px" Width="204px">
                        <div class="text-center">
                            <asp:Image ID="Image2" runat="server" Height="38px" ImageUrl="~/Image/shop.png" Width="127px" />
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="TotalShalf"></asp:Label>
                            <br />
                            <asp:Label ID="lblShalf" runat="server" Text=""></asp:Label>
                        </div>
                    </asp:Panel>
                </td>
                <td style="height: 115px">
                    <asp:Panel ID="Panel3" runat="server" BackColor="White" BorderColor="White" Height="81px" style="margin-left: 0px" Width="205px">
                        <div class="text-center">
                            <asp:Image ID="Image3" runat="server" Height="42px" ImageUrl="~/Image/medicine.png" Width="149px" />
                            <br />
                            <asp:Label ID="Label3" runat="server" Text="Total Medicine"></asp:Label>
                            <br />
                            <asp:Label ID="lblMedicine" runat="server" Text="Label"></asp:Label>
                        </div>
                    </asp:Panel>
                </td>
                <td style="height: 115px" class="text-center">
                    <asp:Panel ID="Panel4" runat="server" BackColor="White" BorderColor="White" Height="81px" style="margin-left: 0px" Width="205px">
                        <div class="text-center">
                            <asp:Image ID="Image4" runat="server" Height="38px" ImageUrl="~/Image/overflow.png" Width="149px" />
                            <br />
                            <asp:Label ID="Label4" runat="server" Text="TotalQuantity"></asp:Label>
                            <br />
                            <asp:Label ID="lblQuantityTotal" runat="server" Text=""></asp:Label>
                            <br />
                        </div>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td style="height: 110px; width: 67px" class="text-center">
                    &nbsp;</td>
                <td style="height: 110px; width: 264px" class="text-center">
                    <asp:Panel ID="Panel5" runat="server" BackColor="White" BorderColor="White" Height="81px" style="margin-left: 0px" Width="205px">
                        <div class="text-center">
                            <asp:Image ID="Image5" runat="server" Height="38px" ImageUrl="~/Image/funds.png" Width="149px" />
                            <br />
                            <asp:Label ID="Label8" runat="server" Text="Grand Purchase Total"></asp:Label>
                            <br />
                            <asp:Label ID="lblGDPTotal" runat="server" Text=""></asp:Label>
                            <br />
                        </div>
                    </asp:Panel>
                </td>
                <td style="height: 110px">
                    <asp:Panel ID="Panel7" runat="server" BackColor="White" BorderColor="White" Height="81px" style="margin-left: 0px" Width="205px">
                        <div class="text-center">
                            <asp:Image ID="Image7" runat="server" Height="38px" ImageUrl="~/Image/pay.png" Width="149px" />
                            <br />
                            <asp:Label ID="Label6" runat="server" Text="Sealls Total"></asp:Label>
                            <br />
                            <asp:Label ID="lblStooo" runat="server" Text=""></asp:Label>
                            <br />
                        </div>
                    </asp:Panel>
                </td>
                <td style="height: 110px" class="text-center">
                    <asp:Panel ID="Panel8" runat="server" BackColor="White" BorderColor="White" Height="81px" style="margin-left: 0px" Width="205px">
                        <div class="text-center">
                            <asp:Image ID="Image8" runat="server" Height="38px" ImageUrl="~/Image/unpaid-sign-stamp-white-background-vector-illustration-unpaid-sign-stamp-144606540.jpg" Width="149px" />
                            <br />
                            <asp:Label ID="Label11" runat="server" Text="TotalQuantity"></asp:Label>
                            <br />
                            <br />
                        </div>
                    </asp:Panel>
                </td>
                <td style="height: 110px">
                    <asp:Panel ID="Panel9" runat="server" BackColor="White" BorderColor="White" Height="81px" style="margin-left: 0px" Width="205px">
                        <div class="text-center">
                            <asp:Image ID="Image9" runat="server" Height="38px" ImageUrl="~/Image/109171633-unpaid-vector-icon-isolated-on-transparent-background-unpaid-logo-concept.jpg" Width="149px" />
                            <br />
                            <asp:Label ID="Label10" runat="server" Text="TotalQuantity"></asp:Label>
                            <br />
                            <br />
                        </div>
                    </asp:Panel>
                </td>
            </tr>
        </table>

    </div>

</asp:Content>

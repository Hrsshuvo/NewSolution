<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockList.aspx.cs" Inherits="NwProject.StockList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align: center">

         <div class="text-left">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:LinkButton ID="LinkButton1"  runat="server" Font-Bold="True" Font-Size="Larger" Font-Underline="True" ForeColor="#9900FF" OnClick="LinkButton1_Click">Add New Purchase</asp:LinkButton>
         </div>
         <div class="text-left">
             <div class="text-center">
 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="808px" style="margin-left: 188px; margin-top: 13px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
     <AlternatingRowStyle BackColor="#DCDCDC" />
     <Columns>
         <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
         <asp:BoundField DataField="BatchNo" HeaderText="BatchNo" SortExpression="BatchNo"></asp:BoundField>
         <asp:BoundField DataField="BuyingPrice" HeaderText="BuyingPrice" SortExpression="BuyingPrice"></asp:BoundField>
         <asp:BoundField DataField="SellingPrice" HeaderText="SellingPrice" SortExpression="SellingPrice" />
         <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
     </Columns>
     <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
     <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
     <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
     <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
     <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
     <SortedAscendingCellStyle BackColor="#F1F1F1" />
     <SortedAscendingHeaderStyle BackColor="#0000A9" />
     <SortedDescendingCellStyle BackColor="#CAC9C9" />
     <SortedDescendingHeaderStyle BackColor="#000065" />
</asp:GridView>
             </div>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaDbConnectionString %>" SelectCommand="SELECT [Name], [BatchNo], [BuyingPrice], [Quantity], [SellingPrice] FROM [tbl_Madecine]"></asp:SqlDataSource>
         </div>
    </div>
<%--<script type="text/javascript" src="https://code.jquery.com/jquery-1.12.4.js"></script>--%>
<script type="text/javascript" src="https://cdn.datatables.net/1.10.9/js/jquery.dataTables.min.js"></script>
<%--<script type="text/javascript" src="https://cdn.datatables.net/responsive/1.0.7/js/dataTables.responsive.min.js"></script>--%>
<script type="text/javascript" src="https://cdn.datatables.net/1.10.9/js/dataTables.bootstrap.min.js"></script>
<%--<script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>--%>
<script type="text/javascript">
    $(function () {
        $('[id*=GridView1]').prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable({
            "responsive": true,
            "sPaginationType": "full_numbers"
        });
    });
</script>
</asp:Content>

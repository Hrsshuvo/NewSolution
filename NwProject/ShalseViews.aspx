<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShalseViews.aspx.cs" Inherits="NwProject.ShalseViews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div style="text-align: center">

         <div class="text-left">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<%--           <asp:LinkButton ID="LinkButton1"  runat="server" Font-Bold="True" Font-Size="Larger" Font-Underline="True" ForeColor="#9900FF" OnClick="LinkButton1_Click">Add New Seals</asp:LinkButton>--%>
         </div>
 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="887px" style="margin-left: 188px; margin-top: 13px; margin-right: 0px;" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" DataKeyNames="Id" Height="123px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
     <AlternatingRowStyle BackColor="#DCDCDC" />
     <Columns>
         <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
         <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
         <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName" />
         <asp:BoundField DataField="Code" HeaderText="Code" SortExpression="Code" />
         <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" />
         <asp:BoundField DataField="Discount" HeaderText="Discount" SortExpression="Discount" />
         <asp:BoundField DataField="PaymentMathod" HeaderText="PaymentMathod" SortExpression="PaymentMathod" />
         <asp:BoundField DataField="GrandTotal" HeaderText="GrandTotal" SortExpression="GrandTotal" />
         <asp:BoundField DataField="Statas" HeaderText="Statas" SortExpression="Statas" />
          <asp:CommandField SelectText="Pdf" ShowSelectButton="True">
                    <ItemStyle ForeColor="#CC0000" />
                </asp:CommandField>
     </Columns>

     <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
     <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
     <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
     <PagerTemplate>
         <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Status" DataValueField="Status">
         </asp:DropDownList>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaDbConnectionString %>" SelectCommand="SELECT * FROM [tbl_Status]"></asp:SqlDataSource>
     </PagerTemplate>

     <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
     <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
     <SortedAscendingCellStyle BackColor="#F1F1F1" />
     <SortedAscendingHeaderStyle BackColor="#0000A9" />
     <SortedDescendingCellStyle BackColor="#CAC9C9" />
     <SortedDescendingHeaderStyle BackColor="#000065" />
</asp:GridView>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaDbConnectionString %>" DeleteCommand="DELETE FROM [tbl_Seals] WHERE [Id] = @Id" InsertCommand="INSERT INTO [tbl_Seals] ([CustomerName], [Code], [Total], [Discount], [PaymentMathod], [GrandTotal], [Statas]) VALUES (@CustomerName, @Code, @Total, @Discount, @PaymentMathod, @GrandTotal, @Statas)" SelectCommand="SELECT * FROM [tbl_Seals]" UpdateCommand="UPDATE [tbl_Seals] SET [CustomerName] = @CustomerName, [Code] = @Code, [Total] = @Total, [Discount] = @Discount, [PaymentMathod] = @PaymentMathod, [GrandTotal] = @GrandTotal, [Statas] = @Statas WHERE [Id] = @Id">
             <DeleteParameters>
                 <asp:Parameter Name="Id" Type="Int32" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="CustomerName" Type="String" />
                 <asp:Parameter Name="Code" Type="String" />
                 <asp:Parameter Name="Total" Type="Int32" />
                 <asp:Parameter Name="Discount" Type="Int32" />
                 <asp:Parameter Name="PaymentMathod" Type="String" />
                 <asp:Parameter Name="GrandTotal" Type="Int32" />
                 <asp:Parameter Name="Statas" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="CustomerName" Type="String" />
                 <asp:Parameter Name="Code" Type="String" />
                 <asp:Parameter Name="Total" Type="Int32" />
                 <asp:Parameter Name="Discount" Type="Int32" />
                 <asp:Parameter Name="PaymentMathod" Type="String" />
                 <asp:Parameter Name="GrandTotal" Type="Int32" />
                 <asp:Parameter Name="Statas" Type="String" />
                 <asp:Parameter Name="Id" Type="Int32" />
             </UpdateParameters>
         </asp:SqlDataSource>
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

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SupplyView.aspx.cs" Inherits="NwProject.SupplyView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div style="text-align: center">

         <div class="text-left">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:LinkButton ID="LinkButton1"  runat="server" Font-Bold="True" Font-Size="Larger" Font-Underline="True" ForeColor="#9900FF" OnClick="LinkButton1_Click">Add New Supplyer</asp:LinkButton>
         </div>
 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="839px" style="margin-left: 188px; margin-top: 13px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" DataKeyNames="Id">
     <AlternatingRowStyle BackColor="#DCDCDC" />
     <Columns>
         <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name">
         <ItemStyle HorizontalAlign="Left" />
         </asp:BoundField>
         <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email">
         <ItemStyle HorizontalAlign="Left" />
         </asp:BoundField>
         <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" >
         <ItemStyle HorizontalAlign="Left" />
         </asp:BoundField>
         <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" >
         <ItemStyle HorizontalAlign="Left" />
         </asp:BoundField>
         <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes">
         <ItemStyle HorizontalAlign="Left" />
         </asp:BoundField>
         <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" Visible="False"></asp:BoundField>
         <asp:CommandField HeaderText="Edit   Delete" ShowDeleteButton="True" ShowEditButton="True">
         <ItemStyle HorizontalAlign="Left" />
         </asp:CommandField>
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
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaDbConnectionString %>" DeleteCommand="DELETE FROM [tbl_Supply] WHERE [Id] = @Id" InsertCommand="INSERT INTO [tbl_Supply] ([Name], [Email], [Phone], [Address], [Notes]) VALUES (@Name, @Email, @Phone, @Address, @Notes)" SelectCommand="SELECT * FROM [tbl_Supply]" UpdateCommand="UPDATE [tbl_Supply] SET [Name] = @Name, [Email] = @Email, [Phone] = @Phone, [Address] = @Address, [Notes] = @Notes WHERE [Id] = @Id">
             <DeleteParameters>
                 <asp:Parameter Name="Id" Type="Int32" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="Name" Type="String" />
                 <asp:Parameter Name="Email" Type="String" />
                 <asp:Parameter Name="Phone" Type="String" />
                 <asp:Parameter Name="Address" Type="String" />
                 <asp:Parameter Name="Notes" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="Name" Type="String" />
                 <asp:Parameter Name="Email" Type="String" />
                 <asp:Parameter Name="Phone" Type="String" />
                 <asp:Parameter Name="Address" Type="String" />
                 <asp:Parameter Name="Notes" Type="String" />
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

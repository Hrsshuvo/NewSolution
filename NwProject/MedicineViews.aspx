﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MedicineViews.aspx.cs" Inherits="NwProject.MedicineViews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div style="text-align: center">

         <div class="text-left">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:LinkButton ID="LinkButton1"  runat="server" Font-Bold="True" Font-Size="Larger" Font-Underline="True" ForeColor="#9900FF" OnClick="LinkButton1_Click">Add New Medicine</asp:LinkButton>
         </div>
 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Width="808px" style="margin-left: 188px; margin-top: 13px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" OnRowEditing="GridView1_RowEditing" DataKeyNames="Id">
     <AlternatingRowStyle BackColor="#DCDCDC" />
     <Columns>
         <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" Visible="False"></asp:BoundField>
         <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category"></asp:BoundField>
         <asp:BoundField DataField="Shalf" HeaderText="Shalf" SortExpression="Shalf" />
         <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
         <asp:BoundField DataField="BatchNo" HeaderText="BatchNo" SortExpression="BatchNo" />
         <asp:BoundField DataField="BuyingPrice" HeaderText="BuyingPrice" SortExpression="BuyingPrice" />
         <asp:BoundField DataField="SellingPrice" HeaderText="SellingPrice" SortExpression="SellingPrice" />
         <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" Visible="False" />
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
          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaDbConnectionString %>" SelectCommand="SELECT * FROM [tbl_Madecine]" DeleteCommand="DELETE from [tbl_Madecine]  Where [Id]=@Id"></asp:SqlDataSource>
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
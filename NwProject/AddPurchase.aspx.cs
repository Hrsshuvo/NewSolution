using NewP.Core.Model;
using Np.Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NwProject
{
    public partial class AddPurchase : System.Web.UI.Page
    {
        //DataTable dt;
        //Int64 Total;
        //PurchaseManager _purchaseManager = new PurchaseManager();
        //SealsManager _sealsManager = new SealsManager();
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        DropSupplyerview();
        //        CategoryView();
        //        //MedicineView();
        //    }
        //}

        //public void MedicineView()
        //{
        //    try
        //    {
        //        var subject = _purchaseManager.GetMedicine();
        //        dropMedicine.DataSource = subject;
        //        dropMedicine.DataTextField = "Name";
        //        dropMedicine.DataValueField = "Id";
        //        dropMedicine.DataBind();
        //    }
        //    catch (Exception e)
        //    {
        //        lblMessage.Text = e.Message;
        //    }
        //}

        //public void CategoryView()
        //{
        //    try
        //    {
        //        var subject = _purchaseManager.GetCategory();
        //        dropCategory.DataSource = subject;
        //        dropCategory.DataTextField = "Name";
        //        dropCategory.DataValueField = "Id";
        //        dropCategory.DataBind();
        //    }
        //    catch (Exception e)
        //    {
        //        lblMessage.Text = e.Message;
        //    }
        //}

        //public void DropSupplyerview()
        //{
        //    try
        //    {
        //        var subject = _purchaseManager.GetSupplyer();
        //        dropSupplyer.DataSource = subject;
        //        dropSupplyer.DataTextField = "Name";
        //        dropSupplyer.DataValueField = "Id";
        //        dropSupplyer.DataBind();
        //        dropSupplyer.SelectedIndex = -1;
        //    }
        //    catch (Exception e)
        //    {
        //        lblMessage.Text = e.Message;
        //    }
        //}
        //public void AddPurchaseItems()
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable.Columns.Add("Name", typeof(string));
        //    dataTable.Columns.Add("Quantity", typeof(int));
        //    dataTable.Columns.Add("price", typeof(int));
        //    dataTable.Columns.Add("Total", typeof(int));
        //    DataRow dr = null;
        //    var data = (DataTable)ViewState["Details"];
        //    if (data != null)
        //    {
        //        for (int i = 0; i < 1; i++)
        //        {
        //            dataTable = (DataTable)ViewState["Details"];
        //            if (dataTable.Rows.Count > 0)
        //            {
        //                dr = dataTable.NewRow();
        //                dr["Name"] = dropMedicine.SelectedItem.ToString();
        //                dr["Quantity"] = txtQuantity.Text;
        //                dr["price"] = lblPrice.Text;
        //                Total = Convert.ToInt64(lblPrice.Text) * Convert.ToInt64(txtQuantity.Text);
        //                dr["Total"] = Total.ToString();
        //                dataTable.Rows.Add(dr);
        //                GridView1.DataSource = dataTable;
        //                GridView1.DataBind();
        //            }
        //            else
        //            {
        //                dr = dataTable.NewRow();
        //                dr["Name"] = dropMedicine.SelectedItem.ToString();
        //                dr["Quantity"] = txtQuantity.Text;
        //                dr["price"] = lblPrice.Text;
        //                Total = Convert.ToInt64(lblPrice.Text) * Convert.ToInt64(txtQuantity.Text);
        //                dr["Total"] = Total.ToString();
        //                dataTable.Rows.Add(dr);
        //                GridView1.DataSource = dataTable;
        //                GridView1.DataBind();
        //            }
        //        }
        //    }
        //    else
        //    {

        //        dr = dataTable.NewRow();
        //        dr["Name"] = dropMedicine.SelectedItem.ToString();
        //        dr["Quantity"] = txtQuantity.Text;
        //        dr["price"] = lblPrice.Text;
        //        Total = Convert.ToInt64(lblPrice.Text) * Convert.ToInt64(txtQuantity.Text);
        //        dr["Total"] = Total.ToString();
        //        dataTable.Rows.Add(dr);
        //        GridView1.DataSource = dataTable;
        //        GridView1.DataBind();
        //    }
        //    ViewState["Details"] = dataTable;

        //}
        //public void GridviewRowSum()
        //{
        //    decimal SubTotal = 0;
        //    foreach (GridViewRow row in GridView1.Rows)
        //    {
        //        SubTotal = SubTotal + Convert.ToDecimal(row.Cells[3].Text);
        //    }
        //    lblAmmount.Text = SubTotal.ToString();
        //    txtGranf.Text = SubTotal.ToString();


        //}

        //protected void btnAdd_Click(object sender, EventArgs e)
        //{
        //    lblAllQty.Text = Convert.ToString(Convert.ToInt32(lblQuantity.Text) + Convert.ToInt32(txtQuantity.Text));

        //    try
        //    {
        //        var PurchaseesModel = new PurchaseesModelsd();

        //        PurchaseesModel.Medicine = dropMedicine.SelectedItem.ToString();
        //        PurchaseesModel.Quntity = Convert.ToInt32(lblAllQty.Text);
        //        var isSave = _purchaseManager.UpdateQty(PurchaseesModel);
        //        if (isSave)
        //        {
        //            string successMessage = "Update Successfully";
        //            lblMessage.Text = successMessage;
        //            lblMessage.ForeColor = Color.Green;
        //            AddPurchaseItems();
        //            remove();
        //            GridviewRowSum();
        //            return;
        //        }
        //        string failMessage = "Fild Not Saved ";
        //        lblMessage.Text = failMessage;
        //    }

        //    catch (Exception exception)
        //    {
        //        lblMessage.Text = exception.Message;
        //    }
        //}

        //public void remove()
        //{
        //    lblPrice.Text = "";
        //    lblQuantity.Text = "";
        //    lblAllQty.Text = "";
        //}

        //public void RefreshField()
        //{
        //    txtCode.Text = "";
        //    txtDate.Text = "";
        //    txtQuantity.Text = "";
        //}

        //protected void dropMedicine_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        lblMessage.Text = "";
        //        if (dropMedicine.SelectedValue != null)
        //        {
        //            var item = new PurchaseesModelsd();
        //            string Medicine = (dropMedicine.SelectedItem.ToString());
        //            var reader = _purchaseManager.GetPricee(Medicine);
        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    lblPrice.Text = Convert.ToInt32(reader["BuyingPrice"]).ToString();
        //                }
        //            }
        //        }
        //        PurchaseesModelsd stock = new PurchaseesModelsd();

        //        string Quantuity = (dropMedicine.SelectedItem.ToString());
        //        var reader1 = _purchaseManager.GetPricee(Quantuity);
        //        if (reader1.HasRows)
        //        {
        //            while (reader1.Read())
        //            {
        //                var courseNames = reader1["Quantity"].ToString();
        //                if (String.IsNullOrEmpty(courseNames))
        //                {
        //                    lblQuantity.Text = 0.ToString();
        //                    return;
        //                }
        //                lblQuantity.Text = courseNames;
        //            }
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        lblMessage.Text = exception.Message;
        //    }
        //}

        //protected void dropCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        dropCategory.DataSource = null;
        //        dropMedicine.DataSource = null;
        //        lblMessage.Text = "";
        //        if (dropMedicine.SelectedValue != null)
        //        {
        //            var item = new SealsModels();
        //            int Id = Convert.ToInt32(dropCategory.SelectedValue);
        //            var items = _sealsManager.GetCatToMedicine(Id);
        //            dropMedicine.DataSource = items;
        //            dropMedicine.DataTextField = "Name";
        //            dropMedicine.DataValueField = "Id";
        //            dropMedicine.SelectedIndex = -1;
        //            dropMedicine.DataBind();
        //        }
        //    }
        //    catch (Exception en)
        //    {
        //        lblMessage.Text = en.Message;
        //    }
        //}

        //protected void txtdiscount_TextChanged(object sender, EventArgs e)
        //{
        //    txtGranf.Text = Convert.ToString(Convert.ToInt32(txtGranf.Text) - Convert.ToInt32(txtDis.Text));
        //}

        //protected void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dropSupplyer.SelectedValue == "" || txtCode.Text == "" || lblAmmount.Text == "" || txtDis.Text == "" || dropMathod.SelectedValue == "" || txtGranf.Text == "" || dropStatus.SelectedValue == "")
        //        {
        //            string validationMessage = "Please fillup Required fields";
        //            lblTotalMessage.Text = validationMessage;
        //            return;
        //        }
        //        var AddPurchaseess = new AddPurchaseess();

        //        AddPurchaseess.SupplyerName = dropSupplyer.SelectedItem.ToString();
        //        AddPurchaseess.Code = txtCode.Text;
        //        AddPurchaseess.Total = Convert.ToInt32(lblAmmount.Text);
        //        AddPurchaseess.Discount = Convert.ToInt32(txtDis.Text);
        //        AddPurchaseess.PaymentMathod = dropMathod.SelectedItem.ToString();
        //        AddPurchaseess.GrandTotal = Convert.ToInt32(txtGranf.Text);
        //        AddPurchaseess.Statas = dropStatus.SelectedValue;
        //        var isSave = _purchaseManager.AddPerSave(AddPurchaseess);
        //        if (isSave)
        //        {
        //            string successMessage = " Saved Successfully";
        //            lblTotalMessage.Text = successMessage;
        //            lblTotalMessage.ForeColor = Color.Yellow;
        //            Response.Redirect("PerchasesView");
        //            clear();
        //            return;
        //        }
        //        string failMessage = "Fild Not Saved ";
        //        lblTotalMessage.Text = failMessage;
        //    }

        //    catch (Exception exception)
        //    {
        //        lblTotalMessage.Text = exception.Message;
        //    }
        //}

        //public void clear()
        //{
        //    txtCode.Text = "";
        //    txtDate.Text = "";
        //    txtDis.Text = "";
        //    txtGranf.Text = "";
        //    txtQuantity.Text = "";
        //    lblMessage.Text = "";
        //}
    }
}
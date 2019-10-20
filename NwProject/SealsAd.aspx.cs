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
    public partial class SealsAd : System.Web.UI.Page
    {
        SealsManager _sealsManager = new SealsManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                DropSupplyerview();
                CategoryView();
                //MedicineView();
                dropBank.Visible = false;
                txt2.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
                lblHeader.Visible = false;
                lblBankName.Visible = false;
                lblAccountHolder.Visible = false;
                lblAccountNumber.Visible = false;
                lblBankAddress.Visible = false;
                lblEDate.Visible = false;
                txtEDate.Visible = false;
                tym.Visible = false;
                btnAAAA.Visible = false;
            }
        }

        public void MedicineView()
        {
            try
            {
                var subject = _sealsManager.GetMedicine();
                dropMedicine.DataSource = subject;
                dropMedicine.DataTextField = "Name";
                dropMedicine.DataValueField = "Id";
                dropMedicine.DataBind();
            }
            catch (Exception e)
            {
                lblMessage.Text = e.Message;
            }
        }
        DataTable dt;
        Int64 Total;

        public void CategoryView()
        {
            try
            {
                var subject = _sealsManager.GetCategory();
                dropCategory.DataSource = subject;
                dropCategory.DataTextField = "Name";
                dropCategory.DataValueField = "Id";
                dropCategory.DataBind();
            }
            catch (Exception e)
            {
                lblMessage.Text = e.Message;
            }
        }

        public void DropSupplyerview()
        {
            try
            {
                //var subject = _sealsManager.GetSupplyer();
                //dropSupplyer.DataSource = subject;
                //dropSupplyer.DataTextField = "Name";
                //dropSupplyer.DataValueField = "Id";
                //dropSupplyer.DataBind();
                //dropSupplyer.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                lblMessage.Text = e.Message;
            }
        }
        public void AddPurchaseItems()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("price", typeof(int));
            dataTable.Columns.Add("Total", typeof(int));
            DataRow dr = null;
            var data = (DataTable)ViewState["Details"];
            if (data != null)
            {
                for (int i = 0; i < 1; i++)
                {
                    dataTable = (DataTable)ViewState["Details"];
                    if (dataTable.Rows.Count > 0)
                    {
                        dr = dataTable.NewRow();
                        dr["Name"] = dropMedicine.SelectedItem.ToString();
                        dr["Quantity"] = txtQuantity.Text;
                        dr["price"] = lblPrice.Text;
                        Total = Convert.ToInt64(lblPrice.Text) * Convert.ToInt64(txtQuantity.Text);
                        dr["Total"] = Total.ToString();
                        dataTable.Rows.Add(dr);
                        GridView1.DataSource = dataTable;
                        GridView1.DataBind();
                    }
                    else
                    {
                        dr = dataTable.NewRow();
                        dr["Name"] = dropMedicine.SelectedItem.ToString();
                        dr["Quantity"] = txtQuantity.Text;
                        dr["price"] = lblPrice.Text;
                        Total = Convert.ToInt64(lblPrice.Text) * Convert.ToInt64(txtQuantity.Text);
                        dr["Total"] = Total.ToString();
                        dataTable.Rows.Add(dr);
                        GridView1.DataSource = dataTable;
                        GridView1.DataBind();
                    }
                }
            }
            else
            {

                dr = dataTable.NewRow();
                dr["Name"] = dropMedicine.SelectedItem.ToString();
                dr["Quantity"] = txtQuantity.Text;
                dr["price"] = lblPrice.Text;
                Total = Convert.ToInt64(lblPrice.Text) * Convert.ToInt64(txtQuantity.Text);
                dr["Total"] = Total.ToString();
                dataTable.Rows.Add(dr);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
            ViewState["Details"] = dataTable;

        }
        public void GridviewRowSum()
        {
            decimal SubTotal = 0;
            foreach (GridViewRow row in GridView1.Rows)
            {
                SubTotal = SubTotal + Convert.ToDecimal(row.Cells[3].Text);
            }
            lblAmmount.Text = SubTotal.ToString();
            txtGranf.Text = SubTotal.ToString();


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblAllQty.Text = Convert.ToString(Convert.ToInt32(lblQuantity.Text) - Convert.ToInt32(txtQuantity.Text));
            try
            {
                if (Convert.ToInt32(lblQuantity.Text) > 0)
                {
                    var PurchaseesModel = new PurchaseesModelsd();

                    PurchaseesModel.Medicine = dropMedicine.SelectedItem.ToString();
                    PurchaseesModel.Quntity = Convert.ToInt32(lblAllQty.Text);
                    var isSave = _sealsManager.UpdateQty(PurchaseesModel);
                    if (isSave)
                    {
                        string successMessage = "Added Successfully";
                        lblMessage.Text = successMessage;
                        lblMessage.ForeColor = Color.Green;
                        AddPurchaseItems();
                        remove();
                        GridviewRowSum();
                        return;
                    }
                    string failMessage = "Fild Not Saved ";
                    lblMessage.Text = failMessage;
                }
                else
                {
                    lblMessage.Text = "Please Stock In Medicine";
                }
            }

            catch (Exception exception)
            {
                lblMessage.Text = exception.Message;
            }
        }

        public void remove()
        {
            lblPrice.Text = "";
            lblQuantity.Text = "";
            lblAllQty.Text = "";
        }

        public void RefreshField()
        {
            txtCode.Text = "";
            txtDate.Text = "";
            txtQuantity.Text = "";
        }

        protected void dropMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";
                if (dropMedicine.SelectedValue != null)
                {
                    var item = new SealsModels();
                    string Medicine = (dropMedicine.SelectedItem.ToString());
                    var reader = _sealsManager.GetPricee(Medicine);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lblPrice.Text = Convert.ToInt32(reader["SellingPrice"]).ToString();
                        }
                    }
                }
                SealsModels stock = new SealsModels();

                string Quantuity = (dropMedicine.SelectedItem.ToString());
                var reader1 = _sealsManager.GetPricee(Quantuity);
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        var courseNames = reader1["Quantity"].ToString();
                        if (String.IsNullOrEmpty(courseNames))
                        {
                            lblQuantity.Text = 0.ToString();
                            return;
                        }
                        lblQuantity.Text = courseNames;
                    }
                }
            }
            catch (Exception exception)
            {
                lblMessage.Text = exception.Message;
            }
        }

        protected void dropCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dropCategory.DataSource = null;
                dropMedicine.DataSource = null;
                lblMessage.Text = "";
                if (dropMedicine.SelectedValue != null)
                {
                    var item = new SealsModels();
                    int Id = Convert.ToInt32(dropCategory.SelectedValue);
                    var items = _sealsManager.GetCatToMedicine(Id);
                    dropMedicine.DataSource = items;
                    dropMedicine.DataTextField = "Name";
                    dropMedicine.DataValueField = "Id";
                    dropMedicine.SelectedIndex = -1;
                    dropMedicine.DataBind();
                    dropMedicine.Items.Insert(0, new ListItem("Select Medicine", "0"));
                }
            }
            catch (Exception en)
            {
                lblMessage.Text = en.Message;
            }
        }

        protected void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            txtGranf.Text = Convert.ToString(Convert.ToInt32(txtGranf.Text) - Convert.ToInt32(txtDis.Text));
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text == "" || txtCode.Text == "" || lblAmmount.Text == "" || txtDis.Text == "" || dropMathod.SelectedValue == "" || txtGranf.Text == "" || dropStatus.SelectedValue == "")
                {
                    string validationMessage = "Please fillup Required fields";
                    lblTotalMessage.Text = validationMessage;
                    return;
                }
                var SealsModels = new SealsModels();

                SealsModels.CustomerName = TxtName.Text;
                SealsModels.Code = txtCode.Text;
                SealsModels.Date = Convert.ToDateTime(txtDate.Text).ToShortDateString();
                SealsModels.Total = Convert.ToInt32(lblAmmount.Text);
                SealsModels.Discount = Convert.ToInt32(txtDis.Text);
                SealsModels.PaymentMathod = dropMathod.SelectedItem.ToString();
                SealsModels.GrandTotal = Convert.ToInt32(txtGranf.Text);
                SealsModels.Statas = dropStatus.SelectedValue;
                var isSave = _sealsManager.AddPerSave(SealsModels);
                if (isSave)
                {
                    string successMessage = " Saved Successfully";
                    lblTotalMessage.Text = successMessage;
                    lblTotalMessage.ForeColor = Color.Yellow;
                    Response.Redirect("ShalseViews");
                    clear();
                    return;
                }
                string failMessage = "Fild Not Saved ";
                lblTotalMessage.Text = failMessage;
            }

            catch (Exception exception)
            {
                lblTotalMessage.Text = exception.Message;
            }
        }

        public void clear()
        {
            txtCode.Text = "";
            txtDate.Text = "";
            txtDis.Text = "";
            txtGranf.Text = "";
            txtQuantity.Text = "";
            lblMessage.Text = "";
        }

        protected void dropMathod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(dropMathod.SelectedValue);
                if (value == 1)
                {
                    dropBank.Visible = false;
                    txt2.Visible = false;
                    txt3.Visible = false;
                    txt4.Visible = false;
                    lblHeader.Visible = false;
                    lblBankName.Visible = false;
                    lblAccountHolder.Visible = false;
                    lblAccountNumber.Visible = false;
                    lblBankAddress.Visible = false;
                    txtEDate.Visible = false;
                    lblEDate.Visible = false;
                    tym.Visible = false;
                    btnAAAA.Visible = false;
                }
                else if (value == 2)
                {
                    dropBank.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    lblHeader.Visible = true;
                    lblBankName.Visible = true;
                    lblAccountHolder.Visible = true;
                    lblAccountNumber.Visible = true;
                    lblBankAddress.Visible = true;
                    lblEDate.Visible = true;
                    txtEDate.Visible = true;
                    tym.Visible = true;
                    btnAAAA.Visible = true;
                }
                else
                {
                    dropBank.Visible = false;
                    txt2.Visible = false;
                    txt3.Visible = false;
                    txt4.Visible = false;
                    lblHeader.Visible = false;
                    lblBankName.Visible = false;
                    lblAccountHolder.Visible = false;
                    lblAccountNumber.Visible = false;
                    lblBankAddress.Visible = false;
                    lblEDate.Visible = false;
                    txtEDate.Visible = false;
                    tym.Visible = false;
                    btnAAAA.Visible = false;
                }
            }
            catch (Exception en)
            {
                lblMessage.Text = en.Message;
            }
        }

        protected void btnAAAA_Click(object sender, EventArgs e)
        {
            dropBank.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
            lblHeader.Visible = false;
            lblBankName.Visible = false;
            lblAccountHolder.Visible = false;
            lblAccountNumber.Visible = false;
            lblBankAddress.Visible = false;
            lblEDate.Visible = false;
            txtEDate.Visible = false;
            tym.Visible = false;
            btnAAAA.Visible = false;
        }
    }
}
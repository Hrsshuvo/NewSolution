using NewP.Core.Model;
using Np.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NwProject
{
    public partial class Medicine : System.Web.UI.Page
    {
        MedicineManager _medicineManager = new MedicineManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LodeDepartment();
                LoadShalf();
            }
        }

        public void LoadShalf()
        {
            try
            {
                var subject = _medicineManager.GetShalf();
                drop_Shalf.DataSource = subject;
                drop_Shalf.DataTextField = "Name";
                drop_Shalf.DataValueField = "Id";
                drop_Shalf.DataBind();
                drop_Shalf.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                lblMessage.Text = e.Message;
            }
        }
        public void LodeDepartment()
        {
            try
            {
                var subject = _medicineManager.GetCategory();
                dropCategory.DataSource = subject;
                dropCategory.DataTextField = "Name";
                dropCategory.DataValueField = "Id";
                dropCategory.DataBind();
                dropCategory.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                lblMessage.Text = e.Message;
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dropCategory.SelectedValue == "" || drop_Shalf.SelectedValue == "" || txtName.Text == "" || txtBatchNo.Text == "" || txtBatchNo.Text == "" || txtBuingPrice.Text == "" || txtSellingPrice.Text == "")
                {
                    string validationMessage = "Please fillup Required fields";
                    lblMessage.Text = validationMessage;
                    return;
                }
                var isUserExist = _medicineManager.IsUserNameExist(txtName.Text);
                if (isUserExist)
                {
                    var validationMessage = "Roll Already Exist";
                    lblMessage.Text = validationMessage;
                    return;
                }

                var MedicineModel = new MedicineModels();

                MedicineModel.Category = dropCategory.SelectedValue;
                MedicineModel.Shalf = drop_Shalf.SelectedValue;
                MedicineModel.Name = txtName.Text;
                MedicineModel.BatchNo = txtBatchNo.Text;
                MedicineModel.BuyingPrice = Convert.ToInt32(txtBuingPrice.Text);
                MedicineModel.SellingPrice = Convert.ToInt32(txtSellingPrice.Text);
                MedicineModel.Quantity = Convert.ToInt32(txtQty.Text);
                var isSave = _medicineManager.CatSave(MedicineModel);
                if (isSave)
                {
                    RefreshField();
                    string successMessage = " Saved Successfully";
                    lblMessage.Text = successMessage;
                    lblMessage.ForeColor = Color.Green;
                    return;
                }
                string failMessage = "Fild Not Saved ";
                lblMessage.Text = failMessage;
            }

            catch (Exception exception)
            {
                lblMessage.Text = exception.Message;
            }
        }
        public void RefreshField()
        {
            dropCategory.ClearSelection();
            drop_Shalf.ClearSelection();
            txtName.Text = "";
            txtName.Text = "";
            txtBatchNo.Text = "";
            txtBuingPrice.Text = "";
            txtSellingPrice.Text = "";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MedicineViews");
        }
    }
}
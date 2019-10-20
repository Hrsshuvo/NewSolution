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
    public partial class Supply : System.Web.UI.Page
    {
        SupplyManager _supplyManager = new SupplyManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtEmail.Text == ""||txtPhone.Text==""||txtAddress.Text==""||txtNotrs.Text=="")

                {

                    string validationMessage = "Please fillup Required fields";

                    lblMessage.Text = validationMessage;

                    return;
                }
                var IsUserNameExist = _supplyManager.IsUserNameExist(txtName.Text);

                if (IsUserNameExist)
                {
                    var validationMessage = "Shalf Already Exist";
                    lblMessage.Text = validationMessage;
                    return;
                }
                var SupplyModel = new SupplyModelss();
                SupplyModel.Name = txtName.Text;
                SupplyModel.Email = txtEmail.Text;
                SupplyModel.Phone = txtPhone.Text;
                SupplyModel.Address = txtAddress.Text;
                SupplyModel.Notes = txtNotrs.Text;
                var isSave = _supplyManager.Save(SupplyModel);
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
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtNotrs.Text = "";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SupplyView");
        }
    }
}
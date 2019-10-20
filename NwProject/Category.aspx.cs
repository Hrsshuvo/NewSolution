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
    public partial class Category : System.Web.UI.Page
    {
        readonly ShalfManager _shalfManager = new ShalfManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtDescription.Text == "")

                {

                    string validationMessage = "Please fillup Required fields";

                    lblMessege.Text = validationMessage;

                    return;
                }
                var IsUserNameExists = _shalfManager.IsUserNameExists(txtName.Text);

                if (IsUserNameExists)
                {
                    var validationMessage = "Shalf Already Exist";
                    lblMessege.Text = validationMessage;
                    return;
                }
                var ShalfModel = new CategoryModel();
                ShalfModel.Name = txtName.Text;
                ShalfModel.Description = txtDescription.Text;
                var isSave = _shalfManager.CatSave(ShalfModel);
                if (isSave)

                {
                    string successMessage = " Saved Successfully";
                    lblMessege.Text = successMessage;
                    lblMessege.ForeColor = Color.Green;
                    RefreshField();
                    Response.Redirect("ViewCategory");
                    return;
                }
                string failMessage = "Fild Not Saved ";
                lblMessege.Text = failMessage;
            }
            catch (Exception exception)
            {
                lblMessege.Text = exception.Message;
            }
        }
        public void RefreshField()
        {
            txtName.Text = "";
            txtDescription.Text = "";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCategory");
        }
    }
}
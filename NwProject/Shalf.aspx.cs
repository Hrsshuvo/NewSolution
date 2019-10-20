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
    public partial class Shalf : System.Web.UI.Page
    {
        readonly ShalfManager _shalfManager = new ShalfManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtShalfName.Text == "" || txtShalfNumber.Text == "")

                {

                    string validationMessage = "Please fillup Required fields";

                    lblMessage.Text = validationMessage;

                    return;
                }
                var IsUserNameExist = _shalfManager.IsUserNameExist(txtShalfName.Text);

                if (IsUserNameExist)
                {
                    var validationMessage = "Shalf Already Exist";
                    lblMessage.Text = validationMessage;
                    return;
                }
                var IsNumberExist = _shalfManager.IsNumberExist(txtShalfNumber.Text);

                if (IsNumberExist)

                {
                    var validationMessage = "Shalf Number Already Exist";
                    lblMessage.Text = validationMessage;
                    return;
                }
                var ShalfModel = new ShalfModel();
                ShalfModel.Name = txtShalfName.Text;
                ShalfModel.NumericNumber = txtShalfNumber.Text;
                var isSave = _shalfManager.Save(ShalfModel);
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
            txtShalfName.Text = "";
            txtShalfNumber.Text = "";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShalfViews");
        }
    }
}
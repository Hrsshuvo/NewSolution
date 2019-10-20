using Np.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NwProject
{
    public partial class LoginASS : System.Web.UI.Page
    {
        LoginManager _loginManager = new LoginManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "" || txtPass.Text == "")
                {
                    string validationMessage = "Please fillup Required fields";
                    lblMessege.Text = validationMessage;
                    return;
                }

                var email = txtEmail.Text;
                var password = txtPass.Text;
                var isLogin = _loginManager.Login(email, password);
                if (!isLogin)
                {
                    string message = "Log in fail...Please give valid info";
                    lblMessege.Text = message;
                    return;
                }

                Response.Redirect("Dashboard");
            }
            catch (Exception exception)
            {
                lblMessege.Text = exception.Message;
            }
        }
    }
}
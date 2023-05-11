using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginApp.Auth
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnSubmitButtonClick(object sender, EventArgs e)
        {
            if (Authenticate())
            {
                Response.Redirect("../Index.aspx");
            }
            else
                 this.Show($"Invalid username or password.");
        }
        private bool Authenticate()
        {

            var domain = "qaad.swacorp.com";
            //var domain = "devad.swacorp.com";
            using (var context = new PrincipalContext(ContextType.Domain, domain))
            {
                return context.ValidateCredentials(SwaIdTextBox.Text.Trim(), WsaPasswordTextBox.Text.Trim(), ContextOptions.Negotiate);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        if (UsernameTextBox.Text.Equals("admin") && PasswordTextBox.Text.Equals("1111"))
        {
            FormsAuthentication.RedirectFromLoginPage(UsernameTextBox.Text, false);
            Response.Redirect("Default.aspx");
        }
        else
        {
            ResultLabel.Text = "Try again";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace Movie_Cruiser
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Chandrika" && TextBox2.Text == "123456789")
            {
                Session["UserName"] = TextBox1.Text;
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
            }
        }
    }
}
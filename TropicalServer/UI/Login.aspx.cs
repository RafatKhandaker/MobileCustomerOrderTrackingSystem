using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TropicalServer.BLL;

namespace TropicalServer.UI
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            init_Params();   
        }

        private void init_Params()
        {
            passwordtextbox.Attributes["type"] = "password";
            if (Request.Cookies["rememberMe"] != null)
            {
                useridtextbox.Text = Request.Cookies["userName"].Value;
                if (Request.Cookies["passWord"] != null)
                {
                    passwordtextbox.Text = Request.Cookies["passWord"].Value;
                }
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            if ( new LoginBLL().CheckLoginCred( useridtextbox.Text, passwordtextbox.Text ) )   
            {
                StoreSession();
                Response.Redirect("Products.aspx", false);
                return;
            }
            Response.Redirect("Error.aspx", false);
        }

        protected void remMeChBx_CheckedChanged(object sender, EventArgs e)
        {
            remMeChBx.Checked = true;
            Response.Cookies["rememberMe"].Value = "Yes";
        }

        private void StoreSession()
        {
            Response.Cookies["userName"].Value = useridtextbox.Text;
            Response.Cookies["userName"].Expires = DateTime.Now.AddDays(1);

            Response.Cookies["passWord"].Value = passwordtextbox.Text;
            Response.Cookies["passWord"].Expires = DateTime.Now.AddDays(1);

            HttpCookie aCookie = new HttpCookie("lastVisit");
            aCookie.Value = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(aCookie);
        }

    }
}
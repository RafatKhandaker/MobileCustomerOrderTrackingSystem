using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TropicalServer.MasterPage
{
    public partial class TropicalServer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pre_init();
        }

        private void pre_init() {
            string currentPage = Request.Url.Segments[Request.Url.Segments.Length -1].ToString();

            switch ( currentPage )
            {
                case ( "Login.aspx" ) :
                    NavigationMenu.Visible = false;
                    break;
                default:
                    return;
            }
        }

        private void init_params()
        {
        }
   

    }
}
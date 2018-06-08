using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TropicalServer.BLL;

namespace TropicalServer.UI
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            init_params();
        }

        private void init_params()
        {
            ProductGroup.DataSource = new ProductsBLL().getCustomerGroups();
            ProductGroup.DataBind();

            ProductsTable.DataSource = new ProductsBLL().getCustomerProducts();
            ProductsTable.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
          
        }

        protected void ProductsTable_SelectedIndexChanging(object source, GridViewSelectEventArgs e)
        {

        }

        protected void ProductGroup_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
         
          ProductsTable.DataSource = new ProductsBLL().getCustomerProducts(((LinkButton)e.CommandSource).Text);
          ProductsTable.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using TropicalServer.BLL;

namespace TropicalServer.UI
{
    public partial class Orders : System.Web.UI.Page
    {
        private int pageIndex = 0;
        private readonly int pageMax = new OrdersBLL().GetMaxPageIndex();

        protected void Page_Load(object sender, EventArgs e)
        {
            init_param();    
        }

        private void init_param()
        {
            OrdersTable.DataSource = ( new OrdersBLL().GetCustomerOrders() );
            OrdersTable.DataBind();
        }
    
        protected void prevBtn_Click(object sender, EventArgs e)
        {
            if (pageIndex <= 0) { return; }
           
            OrdersTable.DataSource = (new OrdersBLL().GetCustomerOrders(--pageIndex));
            OrdersTable.DataBind();
        }

        protected void nextBtn_Click(object sender, EventArgs e)
        {
            if (pageIndex >= pageMax) { return; }

            OrdersTable.DataSource = (new OrdersBLL().GetCustomerOrders(++pageIndex));
            OrdersTable.DataBind();

        }

        protected void viewBtn_Click(object sender, EventArgs e)
        {

        }

        protected void editBtn_Click(object sender, EventArgs e)
        {

        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
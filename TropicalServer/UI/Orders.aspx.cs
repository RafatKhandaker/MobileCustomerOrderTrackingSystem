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
            if (Request.Cookies["userName"] == null || Request.Cookies["passWord"] == null)
            {
                Server.Transfer("~/UI/Login.aspx");
            }

            init_param();    
        }

        private void init_param()
        {
            OrdersTable.DataSource = ( new OrdersBLL().GetCustomerOrders() );
            OrdersTable.DataBind();
            var x = OrdersTable.Columns;
            OrdersTable.Columns[8].Visible = false; 
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

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            OrdersTable.DeleteRow(OrdersTable.SelectedIndex);
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            OrdersTable.Columns[8].Visible = true;
        }

        protected void fOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void fCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void fCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void fSalesManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TropicalServer.BLL
{
    public class OrdersBLL
    {
        public DataSet GetCustomerOrders()
        {
            return ( new DAL.OrdersDAL().GetCustomerOrders() );
        }

        public DataSet GetCustomerOrders( int pageIndex )
        {
            return (new DAL.OrdersDAL().GetCustomerOrders( pageIndex ) );
        }

        public int GetMaxPageIndex()
        {
            return (new DAL.OrdersDAL().GetOrdersPageCount());
        }
    }
}

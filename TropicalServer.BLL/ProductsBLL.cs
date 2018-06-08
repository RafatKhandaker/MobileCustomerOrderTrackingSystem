using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TropicalServer.DAL;

namespace TropicalServer.BLL
{
    public class ProductsBLL
    {
        public DataSet getCustomerProducts()
        {
            return new ProductsDAL().GetCustomerProducts();
        }

        public DataSet getCustomerProducts( Object sender )
        {
            return new ProductsDAL().GetCustomerProducts(sender);
        }


        public DataSet getCustomerGroups()
        {
            return new ProductsDAL().getCustomerGroups();
        }

    }
}

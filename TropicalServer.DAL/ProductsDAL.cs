using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TropicalServer.DAL
{
    public class ProductsDAL
    {
        private string connString = Convert.ToString(ConfigurationManager.AppSettings["TropicalServerConnectionString"]);

        public DataSet GetCustomerProducts()
        {
            using (SqlConnection connection = new SqlConnection(this.connString))
            {
                try
                {
                    connection.Open();

                    SqlParameter[] parameters = new SqlParameter[1];
                    DataSet ds = new DataSet();

                    parameters[0] = new SqlParameter("@INPUT", SqlDbType.Int);
                    parameters[0].Value = DBNull.Value;

                    SqlCommand command = new SqlCommand("GetProductsTable", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(parameters[0]);

                    SqlDataAdapter adp = new SqlDataAdapter(command);

                    adp.Fill(ds);

                    connection.Close();
                    return ds;

                }
                catch (SqlException ex)
                {
                    connection.Close();
                    throw new Exception("Error occured while retrieving customer order list - " + ex.Message.ToString());
                }
            }
        }

        public DataSet GetCustomerProducts(Object prodName)
        {
            using (SqlConnection connection = new SqlConnection(this.connString))
            {
                try
                {
                    connection.Open();

                    SqlParameter[] parameters = new SqlParameter[1];
                    DataSet ds = new DataSet();

                    parameters[0] = new SqlParameter("@INPUT", SqlDbType.VarChar);
                    parameters[0].Value = prodName;

                    SqlCommand command = new SqlCommand("GetProductsTable", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(parameters[0]);

                    SqlDataAdapter adp = new SqlDataAdapter(command);

                    adp.Fill(ds);

                    connection.Close();

                    return ds;

                }
                catch (SqlException ex)
                {
                    connection.Close();
                    throw new Exception("Error occured while retrieving customer order list - " + ex.Message.ToString());
                }
            }
        }

        public DataSet getCustomerGroups()
        {
            using (SqlConnection connection = new SqlConnection(this.connString))
            {
                try
                {
                    connection.Open();
                   
                    DataSet ds = new DataSet();
     
                    SqlCommand command = new SqlCommand("GetProductGroups", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adp = new SqlDataAdapter(command);
                    adp.Fill(ds);

                    connection.Close();

                    return ds;

                }
                catch (SqlException ex)
                {
                    connection.Close();
                    throw new Exception("Error occured while retrieving customer order list - " + ex.Message.ToString());
                }
            }
        }

    }
}

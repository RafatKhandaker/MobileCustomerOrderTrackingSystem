using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace TropicalServer.DAL
{
    public class OrdersDAL
    {
        private string connString = Convert.ToString(ConfigurationManager.AppSettings["TropicalServerConnectionString"]);

        public DataSet GetCustomerOrders()
        {
            using (SqlConnection connection = new SqlConnection(this.connString))
            {
                try
                {
                    connection.Open();

                    var parameter = new SqlParameter("@INDEX", DbType.Int16);
                    parameter.Value = DBNull.Value;

                    var command = new SqlCommand("GetOrdersTable", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(parameter);

                    var adp = new SqlDataAdapter(command);
                    var ds = new DataSet();

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

        public DataSet GetCustomerOrders(int pageIndex)
        {
            using (SqlConnection connection = new SqlConnection(this.connString))
            {
                try
                {
                    connection.Open();

                    var parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@INDEX", SqlDbType.Int);
                    parameters[0].Value = pageIndex;

                    var command = new SqlCommand("GetOrdersTable", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(parameters[0]);

                    var adp = new SqlDataAdapter(command);
                    var ds = new DataSet();
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

        public int GetOrdersPageCount()
        {
            using (SqlConnection connection = new SqlConnection(this.connString))
            {
                try
                {
                    connection.Open();


                    var command = new SqlCommand("GetOrdersPageCount", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    var adp = new SqlDataAdapter(command);
                    var ds = new DataSet();
                    adp.Fill(ds);

                    connection.Close();

                    return int.Parse(ds.Tables[0].Rows[0]["TotalPageCount"].ToString());
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

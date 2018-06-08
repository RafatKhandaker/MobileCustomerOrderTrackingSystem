using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TropicalServer.DAL
{
    public class LoginDAL
    {
        private string connString = Convert.ToString(ConfigurationManager.AppSettings["TropicalServerConnectionString"]);

        public DataSet GetLoginCred(string userID, string passID)
        {
            using (SqlConnection connection = new SqlConnection(this.connString))
            {
                try
                {
                    connection.Open();

                    SqlParameter[] parameters = new SqlParameter[2];

                    parameters[0] = new SqlParameter("@user", SqlDbType.NVarChar);
                    parameters[1] = new SqlParameter("@pass", SqlDbType.NVarChar);

                    parameters[0].Value = (userID);
                    parameters[1].Value = (passID);
                    SqlCommand command = new SqlCommand("CheckUserIdQuery", connection);

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(parameters[0]);
                    command.Parameters.Add(parameters[1]);

                    SqlDataAdapter adp = new SqlDataAdapter(command);

                    DataSet ds = new DataSet();
                    adp.Fill(ds);

                    return ds;

                }
                catch (SqlException ex)
                {
                    throw new Exception("Error occured while retrieving User Login - " + ex.Message.ToString());
                }
            }
        }
    }
}

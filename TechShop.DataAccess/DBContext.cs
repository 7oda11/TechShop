using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.DataAccess
{
    public class DBContext
    {
        SqlConnection conn;
    
        public DBContext(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        
        }
        public DataTable ExecuteQuery(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int ExecuteNonQuery(string commandText)
        {
            SqlCommand command =new SqlCommand(commandText, conn);
            int affectedRows = 0;
            try
            {
                conn.Open();
                 affectedRows = command.ExecuteNonQuery();
                
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return affectedRows;
        }

    }
}

    using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TechShop.DataAccess;

namespace TechShop.BusinessLogic
{
    
    public class UserService
    {
        DBContext dbContext;
        public UserService(string connectionString)
        {
            dbContext = new DBContext(connectionString);
        }
        public int addUser(string username, string password, string email,int age,string address,string role = "User")
        {
            string query = $"insert into Users (Username,Password,Email,Age,Address,Role)values('{username}','{password}','{email}',{age},'{address}','{role}')";
            int rowAffected=dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }
        public bool authenticateUser(string userName,string password )
        {
            string query = $"select [Username],[Password] from Users where Password='{password}' and Username='{userName}'and Role='User'";
            DataTable dataTable=dbContext.ExecuteQuery(query);
           

            return dataTable.Rows.Count > 0;
        }
        public bool authenticateAdmin(string userName, string password)
        {
            string query = $"select [Username],[Password] from Users where Password='{password}' and Username='{userName}'and Role='Admin'";
            DataTable dataTable = dbContext.ExecuteQuery(query);
           

            return dataTable.Rows.Count > 0;
        }
        public DataTable authenticateAdminData(string userName, string password)
        {
            string query = $"select [UserId],[Username],[Password],[Email],[Age],[Address],[Role] from Users where  Username='{userName}'and Role='Admin'";
            DataTable dataTable = dbContext.ExecuteQuery(query);


            return dataTable;
        }
        
        public DataTable authenticateUserData(string userName, string password)
        {
            string query = $"select [UserId],[Username],[Password],[Email],[Age],[Address],[Role] from Users where  Username='{userName}'and Role='User'";
            DataTable dataTable = dbContext.ExecuteQuery(query);


            return dataTable;
        }
        public DataTable getAllUsers(int id)
        {
            string query = $"select [UserId],[Username],[Password],[Email],[Age],[Address],[Role] from Users where UserId!={id}";
            DataTable dataTable = new DataTable();
            dataTable= dbContext.ExecuteQuery(query);
            return dataTable;
        }
        public int updateUser(int userId, string userName, string password, string email, int age, string address, string role)
        {
            string query = $"UPDATE Users SET UserName = '{userName}', Password = '{password}', Email = '{email}', Age = {age}, Address = '{address}', Role = '{role}' WHERE UserID = {userId}";
            int rowAffected= dbContext.ExecuteNonQuery(query);
            return rowAffected;

            
        }
        public int deleteUser(int userId)
        {
            string query = $"DELETE FROM Users WHERE UserID = {userId}";

            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int updateUserProfile(int userId, string userName,  string email, int age, string address)
        {
            string query = $"UPDATE Users SET UserName = '{userName}', Email = '{email}', Age = {age}, Address = '{address}' WHERE UserID = {userId}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;


        }
        public int UpdateUserPassword(int id,string userName, string password) {
            string query = $"UPDATE Users SET UserName = '{userName}', Password = '{password}' WHERE UserID = {id}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

    }
}

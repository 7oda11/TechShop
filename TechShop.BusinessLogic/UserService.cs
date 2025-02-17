using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}

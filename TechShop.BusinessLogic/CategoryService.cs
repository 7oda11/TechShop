using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.DataAccess;

namespace TechShop.BusinessLogic
{
    public class CategoryService
    {
        DBContext dbContext;
        public CategoryService(string connectionString)
        {
            dbContext=new DBContext(connectionString);
        }
        public DataTable getAllCategoriesData()
        {
            string query = "select [CategoryId],[CategoryName] from Categories";
            DataTable dt = new DataTable();
            dt=dbContext.ExecuteQuery(query);
            return dt;
        }
        public int addCategory(string categoryName)
        {
            string query = $"insert into Categories ([CategoryName]) values('{categoryName}')";
            int rowAffected=dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int updateCategory(int id, string categoryName)
        {
            string query = $"update Categories set CategoryName='{categoryName}' where CategoryId={id}";
            int rowAffected= dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int deleteCategory(int id)
        {
            string query = $"delete from Categories where CategoryId={id}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        
        }
    }
}

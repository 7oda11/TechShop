using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.DataAccess;

namespace TechShop.BusinessLogic
{
   
    public class ProductService
    {
        DBContext dbContext;
        public ProductService(string connectionString)
        {
            dbContext = new DBContext(connectionString);
        }
        public DataTable getAllProducts()
        {
            string query = "select [ProductId],[ProductName],[Price],[CategoryName] from Products p join Categories c on(p.CategoryId=c.CategoryId)";
            DataTable dataTable = new DataTable();
            dataTable=dbContext.ExecuteQuery(query);
            return dataTable;
        }
        public DataTable getCategories()
        {
            string query = "select [CategoryId],[CategoryName] from Categories";
            DataTable dataTable = new DataTable();
            dataTable=dbContext.ExecuteQuery(query);
            return dataTable;
        }
        public int addProduct(string productName,decimal price,int category_id)
        {
            string query = $"insert into Products ([ProductName],[Price],[CategoryId]) values('{productName}',{price},{category_id})";
            int rowAffected=dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int updateProduct(string productName,decimal price,int category_id,int id)
        {
            string query = $"UPDATE Products SET ProductName = '{productName}', Price = {price}, CategoryID = {category_id} WHERE ProductID = {id}";
            int rowAffected= dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int deleteProduct(int id)
        {
            string query = $"delete from Products where[ProductId]={id}";
            int rowAffected=dbContext.ExecuteNonQuery (query);
            return rowAffected;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.DataAccess;

namespace TechShop.BusinessLogic
{
    public class FavoriteService
    {
        DBContext dbContext;

        public FavoriteService(string connectionString)
        {
            dbContext=new DBContext(connectionString);
        }
        public int addFav(int productID,int UserID)
        {
            string query = $"insert into Favorites([UserId],ProductId) values ({UserID},{productID})";
            int rowAffected=dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int deleteFav(int productID, int UserID)
        {
            string query = $"delete from Favorites where ProductId={productID} and UserId={UserID}";
            int rowAffected= dbContext.ExecuteNonQuery(query);
            return rowAffected;
        
        }
    }
}

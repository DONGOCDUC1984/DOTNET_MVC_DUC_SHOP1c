using Dapper;
using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation
{
    public class CategoryRepository : IGenericRepository<Category>
    {
        private IDbConnection db;
        public CategoryRepository(IConfiguration configuration)
        {
            db = new SqlConnection(
              configuration.GetConnectionString("DefaultConnection"));
        }
        // Get list of Categories
        public async Task<List<Category>> GetList()
        {
            var sql = "SELECT * FROM Categories";
            var data = (await db.QueryAsync<Category>(sql)).ToList();
            return data;
        }
        // Get Category By Id
        public async Task<Category> GetById(int id)
        {
            var sql = "SELECT * FROM Categories where Id = @Id ";
            var data = (await db.QueryAsync<Category>(sql, new { @Id = id }))
                      .FirstOrDefault();
            return data;
        }
        // Add or Update
        public async Task<bool> AddUpdate(Category category)
        {
            try
            {
                string sql;
                if (category.Id == 0)
                {
                    sql = "Insert into Categories (Name) values (@Name) ";
                }
                else
                {
                    sql = "Update Categories Set Name=@Name where Id = @Id ";
                    
                }
                await db.ExecuteAsync(sql, category);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
            
        }
        // Delete Category
        public async Task<bool> Delete(int id)
        {
            try
            {
                var sql = "Delete FROM Categories where Id = @Id ";
                await db.ExecuteAsync(sql, new { @Id = id });
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public Task<List<Category>> GetListByUserId()
        {
            throw new System.NotImplementedException();
        }
    }
}

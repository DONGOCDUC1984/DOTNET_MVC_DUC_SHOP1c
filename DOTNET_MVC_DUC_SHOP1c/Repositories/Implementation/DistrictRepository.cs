using Dapper;
using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation
{
    public class DistrictRepository : IGenericRepository<District>
    {
        private IDbConnection db;
        public DistrictRepository(IConfiguration configuration)
        {
            db = new SqlConnection(
              configuration.GetConnectionString("DefaultConnection"));
        }
        // Get List of Districts
        public async Task<List<District>> GetList()
        {
            var sql = "Select D.Id,D.Name, D.ProvinceCityId,P.Name as ProvinceCityName " +
                " from Districts as D " +
                " Join ProvinceCities as P " +
                " on D.ProvinceCityId=P.Id";
            var data = (await db.QueryAsync<District>(sql)).ToList();
            return data;
        }
        // Get District By Id
        public async Task<District> GetById(int id)
        {
            var sql = "Select D.Id,D.Name, D.ProvinceCityId,P.Name as ProvinceCityName " +
                " from Districts as D " +
                " Join ProvinceCities as P " +
                " on D.ProvinceCityId=P.Id " +
                " where D.Id = @Id ";
            var data = (await db.QueryAsync<District>(sql, new { @Id = id }))
                      .FirstOrDefault();
            return data;
        }
        // Add or Update District
        public async Task<bool> AddUpdate(District district)
        {
            try
            {
                string sql;
                if (district.Id == 0)
                {
                    sql = "Insert into Districts (Name,ProvinceCityId) values (@Name,@ProvinceCityId) ";
                }
                else
                {
                    sql = "Update Districts Set Name=@Name, ProvinceCityId=@ProvinceCityId " +
                        " where Id = @Id ";

                }
                await db.ExecuteAsync(sql, district);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }
        // Delete District
        public async Task<bool> Delete(int id)
        {
            try
            {
                var sql = "Delete FROM Districts where Id = @Id ";
                await db.ExecuteAsync(sql, new { @Id = id });
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public Task<List<District>> GetListByUserId()
        {
            throw new System.NotImplementedException();
        }
    }
}

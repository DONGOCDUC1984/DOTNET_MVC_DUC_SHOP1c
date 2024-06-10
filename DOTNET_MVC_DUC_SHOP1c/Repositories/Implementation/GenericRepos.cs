using DOTNET_MVC_DUC_SHOP1c.Data;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation
{
    public class GenericRepos<T> : IGenericRepos<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        DbSet<T> dbSet;
        public GenericRepos(ApplicationDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }
        public async Task<List<T>> GetList()
        {
            var data = await dbSet.ToListAsync();
            return data;
        }
        public async Task<bool> Add(T t)
        {
            try
            {
                await dbSet.AddAsync(t);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(T t)
        {
            try
            {
                dbSet.Update(t);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                var data = await dbSet.FindAsync(id);
                dbSet.Remove(data);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<T> GetById(int id)
        {
            var data = await dbSet.FindAsync(id);
            return data;
        }
        public async Task<List<T>> GetListByUserId()
        {
            throw new System.NotImplementedException();
        }
    }
}

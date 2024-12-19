using System.Collections.Generic;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Repositories.Interface
{
    public interface IGenericRepos<T> where T : class
    {
        Task<List<T>> GetList();
        Task<bool> Add(T t);
        Task<bool> Update(T t);
        Task<bool> Delete(int id);
        Task<T> GetById(int id);
        Task<List<T>> GetListByUserId();
    }

}

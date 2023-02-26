using EmployeeManagement.API.Models;
using System.Linq.Expressions;

namespace EmployeeManagement.API.IRepository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetFilteredAsync(Expression<Func<T, bool>>[] filtersfilters, int? skip, int? take, params Expression<Func<T, object>>[] includes);
        Task<List<T>> GetAsync(int? skip, int? take, params Expression<Func<T, object>>[] includes);
        Task<T?> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes);
        Task<int> InsertAsync(T entity);
        void Update(T entity);
        void Delete(T enitity);
        Task SaveChangesAsync();
    }
}

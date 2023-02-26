using EmployeeManagement.API.Data;
using EmployeeManagement.API.Models;
using EmployeeManagement.Infrastructure;
using System.Linq.Expressions;

namespace EmployeeManagement.API.IRepository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(T enitity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAsync(int? skip, int? take, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetFilteredAsync(Expression<Func<T, bool>>[] filtersfilters, int? skip, int? take, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

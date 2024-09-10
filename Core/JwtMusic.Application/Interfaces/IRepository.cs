using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JwtMusic.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity);

        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
    }
}

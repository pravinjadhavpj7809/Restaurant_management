using System.Linq.Expressions;
namespace TequliasRestaurant.Models
{
    public interface IRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllByIdAsync<TKey>(TKey id, string propertyName, QueryOption<T> options);
        Task<T> GetByIdAsync(int id, QueryOption<T> option);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);


    }
}

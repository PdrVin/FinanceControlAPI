using Domain.Entities.Base;

namespace Domain.Interfaces.Base;

public interface IRepository<T> where T : IEntity
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task SaveAsync(T entity);
    Task SaveRangeAsync(IEnumerable<T> entities);
    void Update(T entity);
    void Delete(Guid id);
    Task<int> CountAsync();
}

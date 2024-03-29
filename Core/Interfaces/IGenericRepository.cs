using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
      Task<T> GetByIDAsync(int id);
      Task<IReadOnlyList<T>> ListAllAsync();
    }
}
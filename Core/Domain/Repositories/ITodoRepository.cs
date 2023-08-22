using Core.Domain.Entities;

namespace Core.Domain.Repositories
{
    public interface ITodoRepository
    {
        Task<List<TodoEntity>> GetAsync();
    }
}

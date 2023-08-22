using Core.Domain.Entities;
using Core.Domain.Repositories;
using Core.DTO.Response;
using Core.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Services.Implementations
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        public TodoService(IServiceProvider provider)
        {
            _todoRepository = provider.GetRequiredService<ITodoRepository>();
        }
        public async Task<List<TodoReponse>> GetAsync()
        {
            List<TodoEntity> todoEntities = await _todoRepository.GetAsync();
            return todoEntities.Select(todoEntity => (new TodoReponse
            {
                Id = todoEntity.Id,
                Title = todoEntity.Title,
                Description = todoEntity.Description,
                IsCompleted = todoEntity.IsCompleted,
                UserId = todoEntity.UserId,
            })).ToList();
        }
    }
}

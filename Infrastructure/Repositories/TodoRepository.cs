using Core.Domain.Entities;
using Core.Domain.Repositories;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private TodoDbContext _dbContext;
        public TodoRepository(TodoDbContext dbContext)
        {
            _dbContext = dbContext;   
        }

        public async Task<List<TodoEntity>> GetAsync()
        {
            return await _dbContext.Todos.ToListAsync();
        }
    }
}

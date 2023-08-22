using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DbContexts
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

        public DbSet<TodoEntity> Todos { get; set; }
    }
}

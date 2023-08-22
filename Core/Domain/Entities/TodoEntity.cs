using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Entities
{
    [Table("Todos", Schema = "dbo")]
    public class TodoEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public string UserId { get; set; }
    }
}

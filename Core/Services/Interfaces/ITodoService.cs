using Core.DTO.Response;

namespace Core.Services.Interfaces
{
    public interface ITodoService
    {
        Task<List<TodoReponse>> GetAsync();
    }
}

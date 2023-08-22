using Application.Models;
using Core.DTO.Response;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(IServiceProvider provider)
        {
            _todoService = provider.GetRequiredService<ITodoService>();
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var response = new ApiResponse();
            try
            {
                List<TodoReponse> todos = await _todoService.GetAsync();
                response.Body = todos;
            }
            catch (Exception ex)
            {
                response.Code = 500;
                response.Message = ex.Message;
            }
            return Ok(response);
        }
    }
}

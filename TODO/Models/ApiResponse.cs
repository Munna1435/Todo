namespace Application.Models
{
    public class ApiResponse
    {
        public int Code { get; set; } = 200;
        public string Message { get; set; } = "success";
        public object Body { get; set; }
    }
}

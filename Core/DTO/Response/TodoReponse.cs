﻿namespace Core.DTO.Response
{
    public class TodoReponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public string UserId { get; set; }
    }
}

using System;

namespace ConsoleApp.DTO
{
    public class TaskCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int IdProject { get; set; }
        public int IdTeamMember { get; set; }
        public TaskTypeDto TaskTypeDto { get; set; }
    }
}
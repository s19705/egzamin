using System;
using System.Collections.Generic;

namespace ConsoleApp.DTO
{
    public class ProjectDto
    {
        public int IdProject { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public ICollection<ProjectTaskDto> ProjectTasksDto { get; set; }
    }
}
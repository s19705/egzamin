using Microsoft.EntityFrameworkCore;
using ConsoleApp.DTO;
using ConsoleApp.Entities;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly S19705Context _context;

        public TaskService(S19705Context context)
        {
            _context = context;
        }
        public async Task<bool> AddTask(TaskCreateDto taskCreateDto)
        {
            var task = await _context.Tasks.AnyAsync(t => t.Name == taskCreateDto.Name);
            if (task)
            {
                return false;
            }
            var task_type = await _context.TaskTypes.FirstOrDefaultAsync(e => e.IdTaskType == taskCreateDto.TaskTypeDto.IdTaskType);
            if (task_type == null)
            {
                await _context.AddAsync(new TaskType
                {
                    IdTaskType = taskCreateDto.TaskTypeDto.IdTaskType,
                    Name = taskCreateDto.TaskTypeDto.Name
                });
            }
            await _context.AddAsync(new TaskCreateDto
            {
                Id = taskCreateDto.Id,
                Name = taskCreateDto.Name,
                Description = taskCreateDto.Description,
                Deadline = taskCreateDto.Deadline,
                IdProject = taskCreateDto.IdProject,
                IdTeamMember = taskCreateDto.IdTeamMember
            });
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
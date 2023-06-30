using Microsoft.EntityFrameworkCore;
using ConsoleApp.DTO;
using ConsoleApp.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public class ProjectService : IProjectService
        {
            private readonly S19705Context _context;

            public ProjectService(S19705Context context)
            {
                _context = context;
            }
            public async Task<ProjectDto> GetProject(int IdProject)
            {
                return await _context.Projects.Select(a => new ProjectDto
                {
                    IdProject = a.IdProject,
                    Name = a.Name,
                    Deadline = a.Deadline,

                    ProjectTasksDto = a.Tasks.Select(p => new ProjectTaskDto
                    {
                        Name = p.Name,
                        Deadline = p.Deadline
                    }).OrderBy(p => p.Deadline).ToList()
                }).FirstOrDefaultAsync(a => a.IdProject == IdProject);
            }
        }
}
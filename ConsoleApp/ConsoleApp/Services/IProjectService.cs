using ConsoleApp.DTO;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public interface IProjectService
    {
        Task<ProjectDto> GetProject(int IdProject);
    }
}
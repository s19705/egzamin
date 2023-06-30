using ConsoleApp.DTO;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public interface ITaskService
    {
        Task<bool> AddTask(TaskCreateDto taskCreateDto);
    }
}
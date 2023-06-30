using Microsoft.AspNetCore.Mvc;
using ConsoleApp.DTO;
using ConsoleApp.Services;
using System.Net;
using System.Threading.Tasks;

namespace ConsoleApp.Controllers
{
    [ApiController]
    [Route("api/task")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _serivce;

        public TaskController(ITaskService taskService)
        {
            _serivce = taskService;
        }
        
        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] TaskCreateDto taskCreateDto)
        {
            var isTaskAdded = await _serivce.AddTask(taskCreateDto);
            if (!isTaskAdded)
            {
                return BadRequest("Task cannot be added");
            }
            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}

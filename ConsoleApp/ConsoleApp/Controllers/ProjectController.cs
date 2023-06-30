using Microsoft.AspNetCore.Mvc;
using ConsoleApp.Services;
using System.Threading.Tasks;

namespace ConsoleApp.Controllers
{
    [ApiController]
    [Route("api/project")]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _serivce;

        public ProjectController(IProjectService projectService)
        {
            _serivce = projectService;
        }
        
        [HttpGet("{IdProject}")]
        public async Task<IActionResult> GetProject([FromRoute] int IdProject)
        {
            var project = await _serivce.GetProject(IdProject);

            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }
    }
}

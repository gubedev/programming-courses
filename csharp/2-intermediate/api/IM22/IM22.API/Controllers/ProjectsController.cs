using IM22.API.Requests;
using IM22.Library;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IM22.API.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectService _projectService;
        public ProjectsController(ProjectService projectService)
        {
            _projectService = projectService ?? throw new ArgumentNullException(nameof(projectService));
        }
        // GET api/projects
        [HttpGet]
        public IActionResult Fetch()
        {
            var data = _projectService.FetchProjects();
            return Ok(new { Data = data, Count = data.Length});
        }
        // GET api/projects/120000
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // debo llamar project service para que realice una búsqueda. Si existe, retorno el project que encontro.
            // si no existe, debo retornar NoContent();
            //
            return Ok(new { Id = id });
        }
        // POST api/projects
        [HttpPost]
        public IActionResult CreateProject([FromBody] CreateProjectRequest request)
        {
            var project = _projectService.CreateProject(request.Name);

            return CreatedAtAction("Get", new { id = project.Name }, project);

            #region ejemplo de como crear una respuesta al vuelo

            //return Ok(new { Message = "Project creaded successfully" });

            #endregion
        }

        #region otra forma de hacer un get con parametros

        // api/projects?name=NAME

        //[HttpGet]
        //public IActionResult GetParamAsync([FromQuery] int name)
        //{
        //    hacer algo y retornar
        //}

        #endregion
    }
}

using System;

namespace IM22.Library
{
    public class ProjectService
    {
        private readonly IProjectData _projectData;
        private readonly ILogger _logger;

        public ProjectService(IProjectData projectData, ILogger logger)
        {
            // ?? null coalescing operator
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
            //
            _projectData = projectData ?? throw new ArgumentNullException(nameof(projectData));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Project CreateProject(string name)
        {
            // aca debo verificar si existe un project con el nombre : name

            var project = new Project(name);
            try
            {
                _logger.LogInfo($"try to save project {name}");
                _projectData.SaveProject(project);
                _logger.LogInfo($"save project {name} successfully");
                return project;
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while creating the project {name}. {ex.Message}", LogErrorLevel.SEVERAL);
                throw;
            }
        }

        public Project[] FetchProjects()
        {
            return _projectData.FetchProjects();
        }
    }
}

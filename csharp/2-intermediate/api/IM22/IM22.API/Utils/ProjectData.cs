using IM22.Library;
using System;

namespace IM22.API.Utils
{
    internal class ProjectData : IProjectData
    {
        private Project[] _projects;
        public ProjectData()
        {
            _projects = new Project[10];
            for (int i = 0; i < 10; i++)
            {
                _projects[i] = new Project($"Project {i}");
            }
        }
        public Project[] FetchProjects()
        {
            return _projects;
        }
        public void SaveProject(Project project)
        {
            Array.Resize<Project>(ref _projects, _projects.Length + 1);
            _projects[_projects.Length - 1] = project;
        }
    }
}
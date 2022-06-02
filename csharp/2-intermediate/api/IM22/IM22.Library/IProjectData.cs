namespace IM22.Library
{
    public interface IProjectData
    {
        void SaveProject(Project project);
        Project[] FetchProjects();
    }
}

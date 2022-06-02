namespace IM22.Library
{
    public class Project
    {
        private string _name;

        public Project(string name)
        {
            _name = name;
        }

        public string Name { get => _name; }
    }
}

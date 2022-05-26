using System;

namespace ArraysAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] emptyIntArrays = new int[3];
            int[] filledIntArrays = { 1, 2, 3, 4 };
            
            for (int i = 0; i < filledIntArrays.Length; i++)
            {
                // basic string concat
                var message = "show int array element "  + filledIntArrays[i] + " index " + i;
                Console.WriteLine(message);
            }
            
            for (int i = filledIntArrays.Length - 1; i >= 0; i--)
            {
                // string format showcase  
                var message = string.Format("(reverse) show int array element {0} index {1}", filledIntArrays[i], i);
                Console.WriteLine(message);
            }

            foreach (int element in filledIntArrays)
            {
                // $ - string interpolation showcase
                // reference : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
                var message = $"show int array element {element}";
                Console.WriteLine(message);
            }

            var csharpProject = new Projet()
            {
                Name = "CSHARP Project"
            };

            var sqlProject = new Projet()
            {
                Name = "SQL Project"
            };

            Projet awsProject = new Projet()
            {
                Name = "AWS Project"
            };

            awsProject.AddIssue
            (
                new Issue()
                {
                    Id = 1,
                    Title = "Configurar Bucket",
                }
            );

            awsProject.AddIssue
            (
                new Issue()
                {
                    Id = 1,
                    Title = "Agregar nuevo usuario",
                }
            );

            var projectsArray = new Projet[] { csharpProject, sqlProject, awsProject };

            foreach (Projet element in projectsArray)
            {
                var message = @"project name {0} 
                                issues count {1}
                              ";
                Console.WriteLine(string.Format(message, element.Name, element.Issues.Length));
            }

            Console.ReadLine();
        }
    }

    class Projet
    {
        private Issue[] _issues = new Issue[] { };
        public string Name { get; set; }
        public Issue[] Issues { get => _issues; }
        public void AddIssue(Issue issue)
        {
            if (_issues.Length != 0)
            {
                // búsqueda rustica :-)
                var foundedIssue = FindIssue(issue.Id);
                if (foundedIssue == null)
                {
                    Console.WriteLine(string.Format("Cannot add issue {0} there is already an issue with that id", issue.Id));
                    return;
                }
            }
           
            Array.Resize<Issue>(ref _issues, _issues.Length + 1);
            _issues[_issues.Length - 1] = issue;
        }
        private Issue FindIssue(int id)
        {
            foreach(Issue issue in _issues)
            {
                if (issue.Id == id) return issue;
            }

            return null;
        }
    }

    class Issue
    {
        private Status _status = Status.PENDING;
        private DateTime _createdAt = DateTime.Now;
        /// <summary>
        /// Issue Id - autonumeric
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Id of reponsible user
        /// </summary>
        public int? ResponsibleId { get; set; }
        /// <summary>
        /// Id of informer user
        /// </summary>
        public int InformerId { get; set; }
        /// <summary>
        /// Creation date time
        /// </summary>
        public DateTime CreatedAt { get => _createdAt; }
        /// <summary>
        /// Current status of issue
        /// </summary>
        public Status CurrentStatus { get => _status; }
        /// <summary>
        /// Update progress of issue
        /// </summary>
        /// <param name="status"></param>
        public void UpdateProgress(Status status)
        {
            if (_status == Status.LOCKED) throw new ApplicationException("No es posible actualizar el estado de un issue que esta bloqueado");
            if (_status == Status.FINSIHED) throw new ApplicationException("No es posible actualizar el estado de un issue que esta finalizado");
            _status = status;
        }

        /// <summary>
        /// Unlock 
        /// </summary>
        public void Unlock(string message, int unlockedUserId)
        {
            var formattedMessage = $"issue was unlock by {unlockedUserId} at {DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}";
            Console.WriteLine(formattedMessage);
            Console.WriteLine(message);
        }
    }

    enum Status
    {
        PENDING = 0,
        IN_PROCESS = 1,
        LOCKED = 2,
        FINSIHED = 3
    }

    interface IAuditLogger
    {
        void Log(string message);
    }

    class DataBaseLogger : IAuditLogger
    {
        public void Log(string message)
        {
           
        }
    }

    class FileLogger : IAuditLogger
    {
        public void Log(string message)
        {

        }
    }
}

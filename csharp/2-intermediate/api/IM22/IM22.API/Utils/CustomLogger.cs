using IM22.Library;

namespace IM22.API.Utils
{
    public class CustomLogger : ILogger
    {
        public void LogError(string message, LogErrorLevel errorLevel)
        {
            System.Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}

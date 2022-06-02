namespace IM22.Library
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message, LogErrorLevel errorLevel);
    }
}

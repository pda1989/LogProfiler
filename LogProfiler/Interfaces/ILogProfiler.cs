namespace LogProfiler.Interfaces
{
    public interface ILogProfiler
    {
        void Debug(string message, params string[] args);
        void Error(string message, params string[] args);
        void Information(string message, params string[] args);
        void Verbose(string message, params string[] args);
        void Warning(string message, params string[] args);
    }
}

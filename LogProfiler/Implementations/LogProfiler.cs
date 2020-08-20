using LogProfiler.Interfaces;

namespace LogProfiler.Implementations
{
    public class LogProfiler : ILogProfiler
    {
        public static ILogProfilerFactory Factory => new LogProfilerFactory();

        public LogProfiler()
        {
        }

        public void Debug(string message, params string[] args)
        {
            throw new System.NotImplementedException();
        }

        public void Error(string message, params string[] args)
        {
            throw new System.NotImplementedException();
        }

        public void Information(string message, params string[] args)
        {
            throw new System.NotImplementedException();
        }

        public void Verbose(string message, params string[] args)
        {
            throw new System.NotImplementedException();
        }

        public void Warning(string message, params string[] args)
        {
            throw new System.NotImplementedException();
        }
    }
}

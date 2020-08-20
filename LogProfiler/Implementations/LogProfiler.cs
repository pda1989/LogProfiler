using LogProfiler.Enumerations;
using LogProfiler.Interfaces;

namespace LogProfiler.Implementations
{
    public class LogProfiler : ILogProfiler
    {
        private readonly ILogger _logger;

        public static ILogProfilerFactory Factory => new LogProfilerFactory();

        public LogProfiler(ILogger logger)
        {
            _logger = logger;
        }

        public void Debug(string message, params string[] args)
        {
            _logger.Write(LogLevel.Debug, message, args);
        }

        public void Error(string message, params string[] args)
        {
            _logger.Write(LogLevel.Error, message, args);
        }

        public void Information(string message, params string[] args)
        {
            _logger.Write(LogLevel.Information, message, args);
        }

        public void Verbose(string message, params string[] args)
        {
            _logger.Write(LogLevel.Verbose, message, args);
        }

        public void Warning(string message, params string[] args)
        {
            _logger.Write(LogLevel.Warning, message, args);
        }
    }
}

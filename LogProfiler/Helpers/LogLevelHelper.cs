using LogProfiler.Enumerations;
using Serilog.Events;

namespace LogProfiler.Helpers
{
    internal static class LogLevelHelper
    {
        internal static LogEventLevel ToSerilogLevel(this LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Verbose:
                    return LogEventLevel.Verbose;
                case LogLevel.Debug:
                    return LogEventLevel.Debug;
                case LogLevel.Information:
                    return LogEventLevel.Information;
                case LogLevel.Error:
                    return LogEventLevel.Error;
                case LogLevel.Warning:
                    return LogEventLevel.Warning;
                default:
                    return LogEventLevel.Information;
            }
        }
    }
}
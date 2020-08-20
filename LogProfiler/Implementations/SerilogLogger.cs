using System;
using LogProfiler.Enumerations;
using LogProfiler.Helpers;
using Serilog;

namespace LogProfiler.Implementations
{
    public class SerilogLogger : Interfaces.ILogger
    {
        public SerilogLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
        }

        public void Write(
            LogLevel logLevel,
            string messageTemplate,
            params string[] propertyValues)
        {
            Log.Write(logLevel.ToSerilogLevel(), messageTemplate, propertyValues);
        }

        public void Write(
            LogLevel logLevel,
            Exception exception,
            string messageTemplate,
            params string[] propertyValues)
        {
            Log.Write(logLevel.ToSerilogLevel(), exception, messageTemplate, propertyValues);
        }
    }
}

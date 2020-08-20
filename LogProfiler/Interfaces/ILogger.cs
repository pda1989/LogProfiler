using System;
using LogProfiler.Enumerations;

namespace LogProfiler.Interfaces
{
    public interface ILogger
    {
        void Write(LogLevel logLevel, string messageTemplate, params string[] propertyValues);

        void Write(LogLevel logLevel, Exception exception, string messageTemplate, params string[] propertyValues);
    }
}

using System;
using LogProfiler.Interfaces;

namespace LogProfiler.Implementations
{
    public class LogProfilerFactory : ILogProfilerFactory
    {
        public ILogProfiler Create()
        {
            return new LogProfiler();
        }
    }
}

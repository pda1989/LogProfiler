using System;
namespace LogProfiler.Interfaces
{
    public interface ILogProfilerFactory
    {
        ILogProfiler Create();
    }
}

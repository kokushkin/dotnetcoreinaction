using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACControllerMine
{
    public class RobustLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state) =>
        throw new NotImplementedException();

        public bool IsEnabled(LogLevel logLevel) =>
        logLevel > LogLevel.Debug;

        public void Log<TState>(LogLevel logLevel, EventId eventId,
        TState state, Exception exception,
        Func<TState, Exception, string> formatter)
        {
            Console.WriteLine(string.Join(" ",
            DateTime.Now, logLevel,
            formatter(state, exception)));
        }
    }
}

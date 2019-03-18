using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACControllerMine
{
    public class RobustLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName) =>
           new RobustLogger();

        public void Dispose() { }
    }
}

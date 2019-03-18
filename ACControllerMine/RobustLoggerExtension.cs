using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACControllerMine
{
    public static class RobustLoggerExtension
    {
        public static LoggerFactory AddRobust(
        this LoggerFactory factory)
        {
            factory.AddProvider(new RobustLoggerProvider());
            return factory;
        }
    }
}

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ACControllerMine
{
    public class LoggerEventListener : EventListener
    {
        private readonly ILogger logger;
        public LoggerEventListener(ILogger logger) =>
        this.logger = logger;
        protected override void OnEventWritten(
        EventWrittenEventArgs eventData) =>
        logger.LogInformation(eventData.Message, eventData.Payload[0]);
    }
}

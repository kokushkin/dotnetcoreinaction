using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ACControllerMine
{
    public class ConsoleEventListener : EventListener
    {
        protected override void OnEventWritten(
            EventWrittenEventArgs eventData) =>
            Console.WriteLine(eventData.Message,
            eventData.Payload[0]);
    }
}

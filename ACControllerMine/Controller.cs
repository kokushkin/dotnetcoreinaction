using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ACControllerMine
{
    public class Controller : IDisposable
    {
        readonly LoggerFactory loggerFactory;
        readonly ResourceManagerStringLocalizerFactory resourceFactory;
        readonly Telemetry telemetry;

        internal static readonly ACControllerEventSource Events =
            new ACControllerEventSource();

        readonly LoggerEventListener listener;

        public Controller()
        {
            loggerFactory = new LoggerFactory()
            .AddRobust();
            var locOptions = new LocalizationOptions()
            { ResourcesPath = "resources" };
            var options = Options.Create<LocalizationOptions>(locOptions);
            resourceFactory = new
                ResourceManagerStringLocalizerFactory(
                options, loggerFactory);
            listener = new LoggerEventListener(
                loggerFactory.CreateLogger<Telemetry>());
            listener.EnableEvents(Controller.Events, EventLevel.Verbose);
            telemetry = new Telemetry();
        }

        public void Test()
        {
            telemetry.LogStatus();
        }

        public void Dispose() =>
            listener.Dispose();
    }
}

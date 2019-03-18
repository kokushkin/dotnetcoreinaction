using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACControllerMine
{
    public class Controller
    {
        readonly LoggerFactory loggerFactory;
        readonly ResourceManagerStringLocalizerFactory resourceFactory;
        readonly Telemetry telemetry;

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
            telemetry = new Telemetry(
                loggerFactory.CreateLogger<Telemetry>(),
                resourceFactory.Create(typeof(Telemetry)));
        }
        public void Test()
        {
            telemetry.LogStatus();
        }
    }
}

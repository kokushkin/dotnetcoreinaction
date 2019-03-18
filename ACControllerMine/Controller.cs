using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACControllerMine
{
    public class Controller
    {
        readonly LoggerFactory loggerFactory;
        readonly Telemetry telemetry;
        public Controller()
        {
            loggerFactory = new LoggerFactory()
            .AddRobust();
            telemetry = new Telemetry(
            loggerFactory.CreateLogger<Telemetry>());
        }
        public void Test()
        {
            telemetry.LogStatus();
        }
    }
}

using System.Reflection;
using System.Resources;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace ACControllerMine
{
    public class Telemetry
    {
        //private readonly ILogger logger;
        //private readonly IStringLocalizer localizer;

        //public Telemetry(ILogger logger,
        //    IStringLocalizer localizer)
        //    {
        //        this.logger = logger;
        //        this.localizer = localizer;
        //    }

        //public void LogStatus()
        //{
        //    logger.LogInformation(
        //    resMan.GetString("ExhaustAirTemp") +
        //    TempControl.ExhaustAirTemp + " C");
        //    logger.LogInformation(
        //    resMan.GetString("CoolantTemp") +
        //    TempControl.CoolantTemp + " C");
        //    logger.LogInformation(
        //    resMan.GetString("OutsideAirTemp") +
        //    TempControl.OutsideAirTemp + " C");
        //}

        public void LogStatus()
        {
            Controller.Events.ExhaustAirTemp(TempControl.ExhaustAirTemp);
            Controller.Events.CoolantTemp(TempControl.CoolantTemp);
            Controller.Events.OutsideAirTemp(TempControl.OutsideAirTemp);

            //logger.LogInformation(localizer["Exhaust Air Temp: {0} C"],
            //TempControl.ExhaustAirTemp);
            //logger.LogInformation(localizer["Coolant Temp: {0} C"],
            //TempControl.CoolantTemp);
            //logger.LogInformation(localizer["Outside Air Temp: {0} C"],
            //TempControl.OutsideAirTemp);
        }
    }
}

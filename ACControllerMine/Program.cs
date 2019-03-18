using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace ACControllerMine
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo
            .CreateSpecificCulture("es-MX");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            var resMan = new ResourceManager(
            "ACControllerMine.strings",
            typeof(Program).GetTypeInfo().Assembly);
            Console.WriteLine(
            resMan.GetString("ExhaustAirTemp") +
            TempControl.ExhaustAirTemp);
        }
    }
}

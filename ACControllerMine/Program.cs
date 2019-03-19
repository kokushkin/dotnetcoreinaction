using System;
using System.Diagnostics.Tracing;
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
            using (var listener =
                new ConsoleEventListener())
            {
                listener.EnableEvents(Controller.Events,
                EventLevel.Verbose);
                var controller = new Controller();
                controller.Test();
            }
        }
    }
}

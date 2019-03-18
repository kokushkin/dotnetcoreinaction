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
                .CreateSpecificCulture("ar-SA");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            var controller = new Controller();
            controller.Test();
        }
    }
}

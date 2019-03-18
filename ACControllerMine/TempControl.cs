using System;
using System.Collections.Generic;
using System.Text;

namespace ACControllerMine
{
    public class TempControl
    {
        public static double ExhaustAirTemp { get; internal set; }
        public static double CoolantTemp { get; internal set; }
        public static double OutsideAirTemp { get; internal set; }
    }
}

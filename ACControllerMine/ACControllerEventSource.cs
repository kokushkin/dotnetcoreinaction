﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ACControllerMine
{
    [EventSource(LocalizationResources =
    "ACControllerMine.resources.EventSource")]
    public class ACControllerEventSource : EventSource
    {
        [Event(1)]
        public void ExhaustAirTemp(double temp) =>
        WriteEvent(1, temp);
        [Event(2)]
        public void CoolantTemp(double temp) =>
        WriteEvent(2, temp);

        [Event(3)]
        public void OutsideAirTemp(double temp) =>
        WriteEvent(3, temp);
    }
}    

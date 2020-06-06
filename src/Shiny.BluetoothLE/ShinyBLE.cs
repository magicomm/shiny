﻿using System;
using Shiny.BluetoothLE.Central;


namespace Shiny
{
    public static class ShinyBLE
    {
        public static ICentralManager Central { get; } = ShinyHost.Resolve<ICentralManager>();
    }
}

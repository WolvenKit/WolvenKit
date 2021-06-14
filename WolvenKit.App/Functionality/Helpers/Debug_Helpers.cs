using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Functionality.Helpers
{
    public static partial class VMHelpers
    {
        public static bool InDebug { get; set; } = false;
    }

    public static class WolvenDBG
    {
        public static bool EnableTheming { get; set; } = true;

        public static bool EnableDebugLogging { get; set; } = false;
    }
}

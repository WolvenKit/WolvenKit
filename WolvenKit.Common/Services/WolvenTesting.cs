using System;

namespace WolvenKit.Common.Services
{
    public static class WolvenTesting
    {
        public static bool IsTesting =>
            Environment.GetEnvironmentVariable("WOLVENKIT_ENVIRONMENT", EnvironmentVariableTarget.Process) == "Testing";
    }
}

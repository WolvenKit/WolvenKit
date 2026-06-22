using System;
using System.Linq;

namespace WolvenKit.App.Helpers;

public static class TestHelper
{
    public static bool InActiveTest = AppDomain.CurrentDomain
        .GetAssemblies()
        .Any(a => a.GetName().Name == "xunit.core");
}

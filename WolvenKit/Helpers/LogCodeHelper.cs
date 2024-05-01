using System;
using System.Collections.Generic;

namespace WolvenKit.Helpers;

public static class LogCodeHelper
{
    private static readonly Dictionary<int, string> s_mapping = new();
    
    static LogCodeHelper()
    {
        s_mapping.Add(0, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/error-codes#what-to-do-with-an-error");
        
        // 1: Core stuff

        // 2: Types stuff
        s_mapping.Add(0x2000, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/error-codes#id-0x2000-type-not-supported-8192");

        // 3: modKit stuff

        // 4: project stuff
        s_mapping.Add(0x4001, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/settings#additional-mod-directory");
        s_mapping.Add(0x4002, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/settings#game-executable-.exe-path");
        s_mapping.Add(0x4003, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/usage/wolvenkit-projects");
        
    }

    public static Uri GetUrl(int id)
    {
        if (s_mapping.TryGetValue(id, out var url))
        {
            return new Uri(url);
        }
        return null;
    }
}
using System;
using System.Collections.Generic;

namespace WolvenKit.Helpers;

public static class LogCodeHelper
{
    private static readonly Dictionary<int, string> s_mapping = new();
    
    static LogCodeHelper()
    {
        s_mapping.Add(0x4001, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/settings#additional-mod-directory");
        s_mapping.Add(0x4002, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/settings#game-executable-.exe-path");
        s_mapping.Add(0x4003, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/usage/wolvenkit-projects");
        
        s_mapping.Add(9999, "https://wiki.redmodding.org/cyberpunk-2077-modding/for-mod-creators/3d-modelling/mesh-sculpting-techniques");
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
using System;
using System.Collections.Generic;

namespace WolvenKit.Helpers;

public static class LogCodeHelper
{
    private static readonly Dictionary<int, string> s_mapping = new();
    
    static LogCodeHelper()
    {
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
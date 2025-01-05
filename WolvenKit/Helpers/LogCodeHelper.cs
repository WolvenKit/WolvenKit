using System;
using System.Collections.Generic;
using WolvenKit.Core;

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
        s_mapping.Add(0x2001,
            "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/textures-and-luts/images-importing-editing-exporting#invalid-color-space");
        s_mapping.Add(0x2002,
            "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/textures-and-luts/images-importing-editing-exporting#must-have-dimensions-in-powers-of-2");
        s_mapping.Add(0x2003,
            "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/textures-and-luts/images-importing-editing-exporting#all-images-must-be-the-same-size");
        s_mapping.Add(0x2004, // morphtarget: no chunks
            "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/npcs/a-new-head-for-v#step-6-optional-disabling-the-character-creator");
        s_mapping.Add(0x2005, // mesh: bone mismatch
            "https://wiki.redmodding.org/cyberpunk-2077-modding/for-mod-creators-theory/3d-modelling/troubleshooting-your-mesh-edits#bones-not-found-in-import-mesh-es");

        // 3: modKit stuff
        s_mapping.Add(0x3003,
            "https://wiki.redmodding.org/cyberpunk-2077-modding/for-mod-creators/core-mods-explained/archivexl/archivexl-resource-patching");

        // 4: project stuff
        s_mapping.Add(0x4001, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/settings#additional-mod-directory");
        s_mapping.Add(0x4002, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/settings#game-executable-.exe-path");
        s_mapping.Add(0x4003, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/usage/wolvenkit-projects");

        // 5: everything else
        s_mapping.Add(0x5000, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/error-codes#id-0x5000-invalid-settings");
        s_mapping.Add(0x5001, "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/error-codes#id-0x5001-invalid-game-file-executable");
        s_mapping.Add(0x5002, Constants.IssueTrackerUrl);
        
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
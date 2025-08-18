using System.Collections.Generic;

namespace WolvenKit.RED4.CR2W.JSON;

public static class RedJsonPatches
{
    public static Dictionary<string, string> RenamedProperties = new()
    {
        { "physicsMaterialLibraryResource.unk1", "materialNames" },
        { "physicsMaterialLibraryResource.unk2", "materialValues" }
    };
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public static class TypeHelper
{
    private static Assembly? s_red4Assembly;


    // If the assembly is null, return an empty list. Should never happen, but better safe than sorry.
    private static Assembly? GetTypeAssembly()
    {
        s_red4Assembly ??= AppDomain.CurrentDomain.GetAssemblies()
            .FirstOrDefault(a => (a.FullName ?? "").StartsWith("WolvenKit.RED4,"));
        return s_red4Assembly;
    }

    // Fine-tune these as we learn what works or doesn't work
    private static readonly List<Type> s_entityInstanceDataTypes =
    [
        typeof(entIComponent),
        typeof(entEntity),
    ];

    public static IEnumerable<TypeEntry> GetEntityInstanceDataTypes() =>
        GetTypeAssembly()?.GetTypes()
            .Where(t => t is { IsPublic: true, Namespace: "WolvenKit.RED4.Types" })
            .Where(t => s_entityInstanceDataTypes.Any(type => type.IsAssignableFrom(t)))
            .Select(type => new TypeEntry(type.Name, "", type)) ?? [];

    public static List<TypeEntry> GetCKeyValueEntryTypes() =>
    [
        new TypeEntry("Scalar", "A regular number", typeof(CFloat)),
        new TypeEntry("Texture", "Reference to xbm file", typeof(CResourceReference<ITexture>)),
        new TypeEntry("MultilayerMask", "Reference to mlmask file", typeof(CResourceReference<Multilayer_Mask>)),
        new TypeEntry("MultilayerSetup", "Reference to mlsetup file", typeof(CResourceReference<Multilayer_Setup>)),
        new TypeEntry("Color", "Color description", typeof(CColor)),
        new TypeEntry("Gradient", "Reference to gradient file", typeof(CResourceReference<CGradient>)),
        new TypeEntry("Vector", "", typeof(Vector4)),
        new TypeEntry("Cube", "Reference to cube xbm", typeof(CResourceReference<ITexture>)),
        new TypeEntry("CpuNameU64", "For all params in dynamic materials' @context", typeof(CName)),
        new TypeEntry("FoliageParameters", "Reference to fp file", typeof(CResourceReference<CFoliageProfile>)),
        new TypeEntry("HairParameters", "Reference to hp file", typeof(CResourceReference<CHairProfile>)),
        new TypeEntry("SkinParameters", "Reference to sp file", typeof(CResourceReference<CSkinProfile>)),
        //new("StructBuffer", "", null), // still not sure what this does
        new TypeEntry("TerrainSetup", "Reference to terrainsetup file", typeof(CResourceReference<CTerrainSetup>)),
        new TypeEntry("DynamicTexture", "Reference to dtex file", typeof(CResourceReference<ITexture>)),
        new TypeEntry("TextureArray", "Reference to texarray file", typeof(CResourceReference<ITexture>))
    ];
}
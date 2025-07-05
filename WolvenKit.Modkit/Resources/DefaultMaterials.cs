using System.Collections.Generic;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.Resources;

public enum MaterialResourcePathKey
{
    Albedo,
    BaseColor,
    MultilayerSetup,
    MultilayerMask,
    GlobalNormal,
    Normal,
    NormalMap,
}

public abstract class DefaultMaterials
{
    public static Dictionary<MaterialResourcePathKey, string> FilePaths = new()
    {
        { MaterialResourcePathKey.Albedo, @"base\gameplay\gui\widgets\vehicle\makigai\uvchecker.xbm" },
        { MaterialResourcePathKey.BaseColor, @"base\gameplay\gui\widgets\vehicle\makigai\uvchecker.xbm" },
        { MaterialResourcePathKey.MultilayerSetup, @"engine\materials\defaults\multilayer_default.mlsetup" },
        { MaterialResourcePathKey.MultilayerMask, @"engine\\materials\\defaults\\multilayer_default.mlmask" },
        { MaterialResourcePathKey.GlobalNormal, @"engine\textures\small_flat_normal.xbm" },
        { MaterialResourcePathKey.Normal, @"engine\textures\small_flat_normal.xbm" },
        { MaterialResourcePathKey.NormalMap, @"engine\textures\small_flat_normal.xbm" },
    };

    public static CResourceReference<IMaterial> GetResourceReference(MaterialResourcePathKey key) => new(FilePaths[key]);


    public const string DefaultMiPath =
        @"base\environment\architecture\common\int\int_nkt_jp_corridor_a\materials\debug_to_replace.mi";


    public static readonly CR2WFile DefaultMaterialTemplateFile = new() { MetaData = { FileName = DefaultMiPath } };

    public static readonly IMaterial DefaultMaterialInstance =
        new CMaterialInstance() { BaseMaterial = new CResourceReference<IMaterial>(DefaultMiPath) };
}
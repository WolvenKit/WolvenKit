using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Extensions.red4;

public partial class UiExtensions
{
    public static IEnumerable<string> GetHiddenIfDefaultFieldNames(this appearanceAppearanceResource _)
    {
        return GetHiddenIfDefaultFieldNames().Concat(["censorshipMapping"]);
    }

    public static IEnumerable<string> GetHiddenFieldNames(this appearanceAppearanceResource _)
    {
        return GetHiddenFieldNames().Concat([
                "alternateAppearanceMapping",
                "alternateAppearanceSettingName",
                "alternateAppearanceSuffixes",
                "baseEntity",
                "baseEntityType",
                "baseType",
                "DismEffects",
                "DismWoundConfig",
                "forceCompileProxy",
                "generatePlayerBlockingCollisionForProxy",
                "proxyPolyCount",
                "Wounds",
            ]);
    }
}
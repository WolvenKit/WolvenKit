using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Extensions.red4;

public partial class UiExtensions
{
    public static IEnumerable<string> GetHiddenIfDefaultFieldNames(this appearanceAppearanceDefinition c)
    {
        return UiExtensions.GetHiddenIfDefaultFieldNames().Concat(["looseDependencies"]);
    }

    public static IEnumerable<string> GetHiddenFieldNames(this appearanceAppearanceDefinition c)
    {
        return UiExtensions.GetHiddenFieldNames().Concat(
        [
            "censorFlags",
            "cookedDataPathOverride",
            "forcedLodDistance",
            "hitRepresentationOverrides",
            "parametersBuffer",
            "parentAppearance",
        ]);
    }
}
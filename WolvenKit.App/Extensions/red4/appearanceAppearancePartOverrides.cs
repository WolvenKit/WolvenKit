using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Extensions.red4;

public partial class UiExtensions
{
    public static IEnumerable<string> GetHiddenFieldNames(this appearanceAppearancePartOverrides _)
    {
        // .app file: appearance definition: parts override - ArchiveXL will handle this
        return GetHiddenFieldNames().Concat(["partResource"]);
    }
}
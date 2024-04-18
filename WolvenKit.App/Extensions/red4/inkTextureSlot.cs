using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Extensions.red4;

public partial class UiExtensions
{
    public static IEnumerable<string> GetHiddenFieldNames(this inkTextureSlot _)
    {
        return GetHiddenFieldNames().Concat(["slices"]);
    }
}


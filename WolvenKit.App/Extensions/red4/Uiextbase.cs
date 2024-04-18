using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Extensions.red4;

public  static partial class UiExtensions
{
    public static IEnumerable<string> GetHiddenFieldNames() => [
        "cookingPlatform",
        "topology",
        "topologyData",
        "topologyDataStride",
        "topologyMetadata",
        "topologyMetadataStride",
        "version",
        "vertexBufferSize"
    ];

    public static IEnumerable<string> GetHiddenIfDefaultFieldNames() => [];

    public static bool IsReadonlyClass() => false;

    public static IEnumerable<string> GetReadonlyFieldNames() => [
        "saveDateTime", "resourceVersion", "cookingPlatform", "renderBuffer"
    ];
}

public partial class UiExtensions
{
    public static IEnumerable<string> GetHiddenFieldNames(this RedBaseClass c)
    {
        dynamic d = c;
        return d.GetHiddenFieldNames();
    }

    public static IEnumerable<string> GetHiddenIfDefaultFieldNames(this RedBaseClass c)
    {
        dynamic d = c;
        return d.GetHiddenIfDefaultFieldNames();
    }

    public static bool IsReadonlyClass(this RedBaseClass c)
    {
        dynamic d = c;
        return d.IsReadonlyClass();
    }

    public static IEnumerable<string> GetReadonlyFieldNames(this RedBaseClass c)
    {
        dynamic d = c;
        return d.GetReadonlyFieldNames();
    }
}

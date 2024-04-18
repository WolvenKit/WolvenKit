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
        try
        {
            dynamic d = c;
            return d.GetHiddenFieldNames();
        }
        catch (System.Exception)
        {
            return GetHiddenFieldNames();
        }
    }

    public static IEnumerable<string> GetHiddenIfDefaultFieldNames(this RedBaseClass c)
    {
        try
        {
            dynamic d = c;
            return d.GetHiddenIfDefaultFieldNames();
        }
        catch (System.Exception)
        {
            return GetHiddenIfDefaultFieldNames();
        }
    }

    public static bool IsReadonlyClass(this RedBaseClass c)
    {
        try
        {
            dynamic d = c;
            return d.IsReadonlyClass();
        }
        catch (System.Exception)
        {
            return IsReadonlyClass();
        }
    }

    public static IEnumerable<string> GetReadonlyFieldNames(this RedBaseClass c)
    {
        try
        {
            dynamic d = c;
            return d.GetReadonlyFieldNames();
        }
        catch (System.Exception)
        {
            return GetReadonlyFieldNames();
        }
        
    }
}

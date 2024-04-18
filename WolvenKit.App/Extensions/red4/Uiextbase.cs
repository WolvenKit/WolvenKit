using System;
using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Extensions.red4;

public static partial class UiExtensions
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
    
    public static IEnumerable<string> GetHiddenFieldNames(RedBaseClass c)
    {
        return c switch
        {
            appearanceAppearanceDefinition a => a.GetHiddenFieldNames(),
            appearanceAppearancePartOverrides a => a.GetHiddenFieldNames(),
            appearanceAppearanceResource a => a.GetHiddenFieldNames(),
            appearancePartComponentOverrides a => a.GetHiddenFieldNames(),
            CMesh a => a.GetHiddenFieldNames(),
            entEntityTemplate a => a.GetHiddenFieldNames(),
            entGarmentSkinnedMeshComponent a => a.GetHiddenFieldNames(),
            entMeshComponent a => a.GetHiddenFieldNames(),
            entSkinnedMeshComponent a => a.GetHiddenFieldNames(),
            inkTextureAtlas a => a.GetHiddenFieldNames(),
            inkTextureSlot a => a.GetHiddenFieldNames(),
            rendRenderMeshBlobHeader a => a.GetHiddenFieldNames(),
            _ => GetHiddenFieldNames(),
        };
    }

    public static IEnumerable<string> GetHiddenIfDefaultFieldNames(RedBaseClass c)
    {
        return c switch
        {
            appearanceAppearanceDefinition a => a.GetHiddenIfDefaultFieldNames(),
            appearanceAppearanceResource a => a.GetHiddenIfDefaultFieldNames(),
            CMesh a => a.GetHiddenIfDefaultFieldNames(),
            _ => GetHiddenIfDefaultFieldNames(),
        };
    }

    public static bool IsReadonlyClass(RedBaseClass c)
    {
        return c switch
        {
            rendRenderTextureBlobMemoryLayout a => a.IsReadonlyClass(),
            rendRenderTextureBlobMipMapInfo a => a.IsReadonlyClass(),
            rendRenderTextureBlobPlacement a => a.IsReadonlyClass(),
            rendRenderTextureBlobSizeInfo a => a.IsReadonlyClass(),
            rendRenderTextureBlobTextureInfo a => a.IsReadonlyClass(),
            _ => IsReadonlyClass(),
        };
    }

    public static IEnumerable<string> GetReadonlyFieldNames(RedBaseClass c)
    {
        return c switch
        {
            CBitmapTexture a => a.GetReadonlyFieldNames(),
            CMesh a => a.GetReadonlyFieldNames(),
            _ => GetReadonlyFieldNames(),
        };
    }
}

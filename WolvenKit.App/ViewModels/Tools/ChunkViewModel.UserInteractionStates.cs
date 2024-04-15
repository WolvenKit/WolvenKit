using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

// ReSharper disable once CheckNamespace
namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    // Types that should never be changed by the user 
    private static readonly List<Type> s_globalReadonlyTypes =
    [
        typeof(SerializationDeferredDataBuffer),
        typeof(rendRenderTextureBlobMemoryLayout),
        typeof(rendRenderTextureBlobPlacement),
        typeof(rendRenderTextureBlobMipMapInfo),
        typeof(rendRenderTextureBlobTextureInfo),
        typeof(rendRenderTextureBlobSizeInfo),
    ];

    // Properties (by name) that should never be changed by the user
    private static readonly List<string> s_globalReadonlyFields =
    [
        "saveDateTime", "resourceVersion", "cookingPlatform", "renderBuffer"
    ];

    // Fields (by parent class) that should be marked as read-only
    private static readonly Dictionary<Type, List<string>> s_readonlyFields = new()
    {
        { typeof(CBitmapTexture), ["width", "height"] }, // xbm
        { typeof(CMesh), ["geometryHash", "consoleBias"] }, // mesh
    };

    private void CalculateIsReadOnly()
    {
        if (IsReadOnly)
        {
            return;
        }
        if (Parent?.IsReadOnly is true || s_globalReadonlyFields.Contains(Name) || s_globalReadonlyTypes.Contains(ResolvedData.GetType()))
        {
            IsReadOnly = true;
            return;
        }

        if (Parent is not null && s_readonlyFields.TryGetValue(Parent.ResolvedData.GetType(), out var hiddenFields))
        {
            IsReadOnly = hiddenFields.Contains(Name);
        }
    }

    private void CalculateUserInteractionStates()
    {
        // Either a root field, or a field that isn't initialized yet
        if (Parent is null || ResolvedData is RedDummy)
        {
            return;
        }

        CalculateIsReadOnly();
        CalculateConditionalHiding();
    }

    public bool ExcludeFromSimpleView()
    {
        CalculateConditionalHiding();
        return IsHiddenByNoobFilter;
    }

    /// <summary>
    /// Should this property be hidden from the default view (because the user has toggled the noob filter)?
    /// TODO: Not implemented yet
    /// </summary>
    private void CalculateConditionalHiding()
    {
        // If we're in simple view, hide all "unnecessary" properties from the user
        if (Tab?.IsSimpleViewEnabled != true)
        {
            IsHiddenByNoobFilter = false;
            return;
        }

        // DataBuffers should always be hidden
        if (PropertyType.IsAssignableTo(typeof(DataBuffer)))
        {
            IsHiddenByNoobFilter = true;
            return;
        }

        if (Parent is null)
        {
            return;
        }

        if (Parent.ResolvedData is not RedBaseClass baseClass)
        {
            return;
        }

        if (baseClass.GetHiddenFieldNames().ToList().Contains(Name))
        {
            IsHiddenByNoobFilter = true;
            return;
        }

        // Some fields should be hidden if they are empty, or false 
        if (baseClass.GetHiddenIfDefaultFieldNames().ToList().Contains(Name))
        {
            if ((IsArray && Properties.Count == 0) // empty array
            || (ResolvedData is CBool boolValue && boolValue == false) //false boolean
            || (ResolvedData is CName cname && (cname.GetResolvedText() ?? "").ToLower().Replace("none", "") == "") // empty cname
               )
            {
                IsHiddenByNoobFilter = true;
            }
        }
    }
}
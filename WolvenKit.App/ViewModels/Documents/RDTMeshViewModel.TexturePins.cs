using System.Collections.Generic;
using System.Linq;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.SharpDX.Core.Utilities;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Documents.Multilayer;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Keeps the GPU textures of generated appearances loaded. Helix frees a texture once no shown
/// material uses it, so switching back to an appearance re-decoded and re-uploaded all of its
/// PNGs; a reference held here keeps them on the GPU until the tab closes or the cache is cleared.
/// </summary>
public partial class RDTMeshViewModel
{
    private readonly Dictionary<Appearance, List<ShaderResourceViewProxy>> _texturePins = new();
    private EffectsManager? _texturePinsManager;

    /// <summary>Holds the textures of the appearance's materials (again: drops its old ones).</summary>
    private void PinAppearanceTextures(Appearance app)
    {
        if (EffectsManager is not { IsDisposed: false } effects)
        {
            return;
        }

        if (!ReferenceEquals(effects, _texturePinsManager))
        {
            // Pins of a previous (disposed) effects manager are gone with it.
            _texturePins.Clear();
            _texturePinsManager = effects;
        }

        var textures = new HashSet<TextureModel>();
        foreach (var sm in app.Models.SelectMany(m => m.Meshes))
        {
            if (sm.Material is not PBRMaterial pbr)
            {
                continue;
            }

            foreach (var map in new[] { pbr.AlbedoMap, pbr.NormalMap, pbr.RoughnessMetallicMap, pbr.EmissiveMap })
            {
                if (map != null)
                {
                    textures.Add(map);
                }
            }

            if (pbr is MultilayerPBRMaterial { MultilayerData: { } data })
            {
                textures.UnionWith(data.Textures.Where(t => t != null));
            }
        }

        // Register the new set before releasing the old one: shared textures never drop to zero.
        var pins = new List<ShaderResourceViewProxy>(textures.Count);
        foreach (var texture in textures)
        {
            if (effects.MaterialTextureManager.Register(texture) is { } proxy)
            {
                pins.Add(proxy);
            }
        }

        if (_texturePins.Remove(app, out var old))
        {
            Release(old);
        }

        _texturePins[app] = pins;
    }

    /// <summary>Lets Helix free the held textures (cache cleared, tab closed).</summary>
    private void ReleaseTexturePins()
    {
        if (_texturePinsManager is { IsDisposed: false })
        {
            foreach (var pins in _texturePins.Values)
            {
                Release(pins);
            }
        }

        _texturePins.Clear();
        _texturePinsManager = null;
    }

    private static void Release(List<ShaderResourceViewProxy> pins)
    {
        foreach (var pin in pins)
        {
            pin.Dispose();
        }

        pins.Clear();
    }
}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Models;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>What the sector variant list offers.</summary>
public enum SectorVariantMode
{
    /// <summary>Every node range: the old behaviour (variants drawn over each other).</summary>
    All,

    /// <summary>The always-loaded range and the variants the game enables by default (known in block previews).</summary>
    Default,

    /// <summary>The always-loaded range only.</summary>
    Persistent,

    /// <summary>The always-loaded range and one variant.</summary>
    Single,
}

public sealed record SectorVariantOption(string Name, SectorVariantMode Mode, int Range = -1)
{
    public override string ToString() => Name;
}

/// <summary>
/// Sector previews: variants and proxy meshes.
/// A sector's nodeData is split into ranges (variantIndices): one always loaded, the others are
/// variants a quest switches on and off (intact / destroyed building, decorations...). They were all
/// drawn at once, over each other. The variant list picks which ranges show, like the appearance of
/// a mesh or an entity. Proxy meshes (low detail stand-ins for content of other sectors) are hidden
/// unless "Show proxy meshes" is on; foliage can be hidden with "Show foliage" (dense sectors).
/// </summary>
public partial class RDTMeshViewModel
{
    [ObservableProperty] private ObservableCollection<SectorVariantOption> _sectorVariants = new();
    [ObservableProperty] private SectorVariantOption? _selectedSectorVariant;
    [ObservableProperty] private bool _hasSectorVariants;
    [ObservableProperty] private bool _showSectorProxies;
    [ObservableProperty] private bool _showSectorFoliage = true;
    [ObservableProperty] private bool _colorSectorAreas = true;

    /// <summary>Area volumes without the colour by type.</summary>
    private static readonly SharpDX.Color4 s_plainAreaColor = new(1f, 1f, 1f, 0.1f);

    // filled while RenderSector runs, then kept on the SectorGroup
    private List<(Element3D Element, int[] NodeDataIndices)>? _sectorPlacements;
    private List<Element3D>? _sectorProxyGroups;
    private List<Element3D>? _sectorFoliageGroups;
    private List<(PBRMaterial Material, SharpDX.Color4 Color)>? _sectorAreaMaterials;

    private SectorGroup? _soloSector;

    partial void OnSelectedSectorVariantChanged(SectorVariantOption? value) => ApplySectorVisibility();

    partial void OnShowSectorProxiesChanged(bool value) => ApplySectorVisibility();

    partial void OnShowSectorFoliageChanged(bool value) => ApplySectorVisibility();

    partial void OnColorSectorAreasChanged(bool value) => ApplySectorVisibility();

    private void BeginSectorRegistry()
    {
        _sectorPlacements = new();
        _sectorProxyGroups = new();
        _sectorFoliageGroups = new();
        _sectorAreaMaterials = new();
    }

    private void EndSectorRegistry(SectorGroup element, worldStreamingSector data, int nodeDataCount)
    {
        element.NodeDataCount = nodeDataCount;
        element.Placements = _sectorPlacements ?? new();
        element.ProxyGroups = _sectorProxyGroups ?? new();
        element.FoliageGroups = _sectorFoliageGroups ?? new();
        element.AreaMaterials = _sectorAreaMaterials ?? new();
        element.RangeStarts = data.VariantIndices.Select(x => (int)x).ToArray();
        element.PersistentRange = data.PersisentNodeIndex;
        _sectorPlacements = null;
        _sectorProxyGroups = null;
        _sectorFoliageGroups = null;
        _sectorAreaMaterials = null;
    }

    /// <summary>A scene element placed by these nodeData entries (it shows when any of them does).</summary>
    private void RegisterSectorPlacement(Element3D element, params int[] nodeDataIndices)
    {
        if (nodeDataIndices.Length > 0)
        {
            _sectorPlacements?.Add((element, nodeDataIndices));
        }
    }

    private void RegisterSectorProxy(Element3D group) => _sectorProxyGroups?.Add(group);

    private void RegisterSectorFoliage(Element3D group) => _sectorFoliageGroups?.Add(group);

    /// <summary>An area volume material and its colour by type; returns the colour to start with.</summary>
    private SharpDX.Color4 RegisterSectorAreaMaterial(PBRMaterial material, SharpDX.Color4 color)
    {
        _sectorAreaMaterials?.Add((material, color));
        return ColorSectorAreas ? color : s_plainAreaColor;
    }

    /// <summary>Single sector: its variants, numbered (their names live in the block).</summary>
    private void FillSoloSectorVariants(SectorGroup sector)
    {
        var options = new ObservableCollection<SectorVariantOption>();
        var variantRanges = Enumerable.Range(0, sector.RangeStarts.Length).Where(r => r != sector.PersistentRange).ToList();

        if (variantRanges.Count > 0)
        {
            options.Add(new SectorVariantOption("All variants", SectorVariantMode.All));
            options.Add(new SectorVariantOption("No variants (always loaded nodes only)", SectorVariantMode.Persistent));
            var number = 0;
            foreach (var range in variantRanges)
            {
                number++;
                var name = sector.Variants.TryGetValue(range, out var v) && !string.IsNullOrEmpty(v.Name)
                    ? v.Name
                    : $"Variant {number}";
                options.Add(new SectorVariantOption($"{name} ({RangeSize(sector, range)} nodes)", SectorVariantMode.Single, range));
            }
        }

        SectorVariants = options;
        HasSectorVariants = options.Count > 0;
        // keep the old look until a variant is picked: the default variants are not known here
        SelectedSectorVariant = options.FirstOrDefault();
    }

    /// <summary>Block: the variants differ per sector, so the list offers the modes; Default uses the block's flags.</summary>
    private void FillBlockSectorVariants()
    {
        SectorVariants = new ObservableCollection<SectorVariantOption>
        {
            new("Default variants", SectorVariantMode.Default),
            new("All variants", SectorVariantMode.All),
            new("No variants (always loaded nodes only)", SectorVariantMode.Persistent),
        };
        HasSectorVariants = true;
        SelectedSectorVariant = SectorVariants[0];
    }

    private static int RangeSize(SectorGroup sector, int range)
    {
        var start = sector.RangeStarts[range];
        var end = sector.NodeDataCount;
        foreach (var other in sector.RangeStarts)
        {
            if (other > start && other < end)
            {
                end = other;
            }
        }

        return System.Math.Max(0, end - start);
    }

    /// <summary>Applies the variant choice and the proxy switch to the sector(s) shown.</summary>
    private void ApplySectorVisibility()
    {
        if (_soloSector != null)
        {
            ApplySectorVisibility(_soloSector);
        }

        foreach (var sector in Sectors)
        {
            if (sector.Element != null)
            {
                ApplySectorVisibility(sector.Element);
            }
        }
    }

    private void ApplySectorVisibility(SectorGroup sector)
    {
        var option = SelectedSectorVariant;

        foreach (var (element, indices) in sector.Placements)
        {
            var visible = option is null || indices.Any(i => IsRangeShown(sector, sector.RangeOf(i), option));
            if (element.IsRendering != visible)
            {
                element.IsRendering = visible;
            }
        }

        foreach (var group in sector.ProxyGroups)
        {
            group.IsRendering = ShowSectorProxies;
        }

        foreach (var group in sector.FoliageGroups)
        {
            group.IsRendering = ShowSectorFoliage;
        }

        foreach (var (material, color) in sector.AreaMaterials)
        {
            var wanted = ColorSectorAreas ? color : s_plainAreaColor;
            if (material.AlbedoColor != wanted)
            {
                material.AlbedoColor = wanted;
            }
        }
    }

    private static bool IsRangeShown(SectorGroup sector, int range, SectorVariantOption option)
    {
        if (range < 0 || range == sector.PersistentRange)
        {
            return true;
        }

        return option.Mode switch
        {
            SectorVariantMode.All => true,
            SectorVariantMode.Persistent => false,
            SectorVariantMode.Single => range == option.Range,
            // without the block's flags nothing is known to be off
            SectorVariantMode.Default => !sector.Variants.TryGetValue(range, out var v) || v.EnabledByDefault,
            _ => true,
        };
    }
}

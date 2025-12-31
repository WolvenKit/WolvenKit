using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// A simple "search and replace" dialog. Needs to register in GenericHost via AddTransient.
/// </summary>
public partial class AddSectorVariantDialogViewModel() : ObservableObject
{
    private readonly Cp77Project? _currentProject = null;
    private readonly StreamingSectorTools? _sectorTools = null;
    public string SectorRelativePath { get; set; } = "";

    [ObservableProperty] private string? _newVariantNameOrPrefix = "";

    [ObservableProperty] private string? _templateVariant = "";

    [ObservableProperty] private string? _searchInAppearances = "";
    [ObservableProperty] private string? _replaceInAppearances = "";

    /*
     * Read from streaming sector: appearances of sector nodes
     */
    [ObservableProperty] private bool _showNodeAppearanceDropdown = false;
    [ObservableProperty] private Dictionary<string, string> _sectorNodeAppearances = [];

    public Dictionary<worldNodeData, worldNode?> DataNodes { get; set; } = [];
    public List<string> NewAppearances { get; set; } = [];

    [ObservableProperty] private Dictionary<string, string> _variantNames = [];

    private readonly Dictionary<string, worldStreamingSectorVariant> _variantsByName = [];
    private readonly Dictionary<string, string> _sectorPathsByName = [];

    public AddSectorVariantDialogViewModel(worldStreamingBlock block, Cp77Project project,
        StreamingSectorTools sectorTools) : this()
    {
        _currentProject = project;
        _sectorTools = sectorTools;

        foreach (var descriptor in block.Descriptors.ToList())
        {
            var descriptorPath = descriptor.Data.DepotPath.ToString() ?? "";
            foreach (var variant in descriptor.Variants.OrderBy(x => x.RangeIndex).ToList())
            {
                if (variant.Name.ToString() is not string s || string.IsNullOrEmpty(s))
                {
                    continue;
                }

                _variantsByName.Add(s, variant);
                _sectorPathsByName.Add(s, descriptorPath);
            }
        }

        _variantNames = _variantsByName.Keys.ToDictionary(k => k, v => v);
    }

    public void ReadStreamingSector()
    {
        ShowNodeAppearanceDropdown = false;

        if (_currentProject is null || _sectorTools is null ||
            string.IsNullOrEmpty(TemplateVariant) ||
            !_variantsByName.TryGetValue(TemplateVariant, out var variant) ||
            string.IsNullOrEmpty(variant.NodeRef) ||
            !_sectorPathsByName.TryGetValue(TemplateVariant, out var relativePath) ||
            string.IsNullOrEmpty(relativePath) || !_currentProject.ModFiles.Contains(relativePath))
        {
            return;
        }

        SectorRelativePath = relativePath;

        // Read sector node appearances
        var absolutePath = _currentProject.GetAbsolutePath(relativePath);

        DataNodes = _sectorTools.GetDataNodes(variant.RangeIndex, absolutePath);
        var nodeAppearances = DataNodes.Values.OfType<IRedMeshNode>().Select(n => n.MeshAppearance.ToString() ?? "")
            .Where(s => !string.IsNullOrEmpty(s)).Distinct().ToList();

        switch (nodeAppearances.Count)
        {
            case 0:
                return;
            case 1:
                SearchInAppearances = nodeAppearances.First();
                return;
            default:
                ShowNodeAppearanceDropdown = true;
                SectorNodeAppearances = nodeAppearances.ToDictionary(x => x, x => x);
                break;
        }
    }

    public void GenerateResults()
    {
        NewAppearances = (ReplaceInAppearances ?? "").Split("\n").Select(s => s.Trim())
            .Where(s => !string.IsNullOrEmpty(s)).ToList();

        if (NewAppearances.Count == 0 || string.IsNullOrEmpty(SearchInAppearances) ||
            string.IsNullOrEmpty(TemplateVariant))
        {
            return;
        }

        ReadStreamingSector();
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(TemplateVariant):
                ReadStreamingSector();
                break;
            case nameof(ReplaceInAppearances):
                ReadNewAppearanceNames();
                break;
            default:
                break;
        }

        base.OnPropertyChanged(e);
    }

    private void ReadNewAppearanceNames()
    {
        NewAppearances ??= [];
        NewAppearances.Clear();
        if (string.IsNullOrEmpty(ReplaceInAppearances))
        {
            return;
        }

        foreach (var s1 in ReplaceInAppearances.Split("\n").Select(s => s.Trim()))
        {
            NewAppearances.Add(s1);
        }
    }
}

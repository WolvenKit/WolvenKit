using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// The "Objects" tab of a sector: every object of the sector on its own row (one per nodeData entry), grouped by
/// variant and by kind, with the class, the indices, the flags and whether it's hidden. Cooked nodes (game 2.5) are
/// unpacked, so an object inside one is found by name like any other.
/// </summary>
public partial class RDTSectorObjectsViewModel : RedDocumentTabViewModel
{
    public const string AllCategories = "All categories";

    public const string AllTargetGroups = "All groups";

    private readonly worldStreamingSector _sector;

    public RDTSectorObjectsViewModel(worldStreamingSector sector, RedDocumentViewModel file) : base(file, "Objects")
    {
        _sector = sector;
        Categories = [AllCategories, .. SectorObjectList.CategoryNames];
        TargetGroups = [AllTargetGroups, .. SectorTargetGroups.Names];
    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

    /// <summary>Asks the document to show this node in the data tab.</summary>
    public event EventHandler<int>? NodeOpenRequested;

    /// <summary>Asks the document to show this object (node index, nodeData index) in the sector preview.</summary>
    public event EventHandler<(int NodeIndex, int NodeDataIndex)>? PreviewOpenRequested;

    /// <summary>Raised when the rows to show change, so the view refreshes its filter.</summary>
    public event EventHandler? FilterChanged;

    [ObservableProperty] private IReadOnlyList<SectorObject> _objects = [];

    [ObservableProperty] private string _summary = "";

    [ObservableProperty] private string _filterText = "";

    [ObservableProperty] private bool _onlyCooked;

    [ObservableProperty] private bool _onlyHidden;

    [ObservableProperty] private string _selectedCategory = AllCategories;

    /// <summary>RedHotTools' target group (Mesh, Collision, Area...).</summary>
    [ObservableProperty] private string _selectedTargetGroup = AllTargetGroups;

    [ObservableProperty] private SectorObject? _selectedObject;

    [ObservableProperty] private bool _onlyInXl;

    /// <summary>Result of the last .xl check, shown under the summary; empty without one.</summary>
    [ObservableProperty] private string _xlSummary = "";

    [ObservableProperty] private bool _hasXl;

    // the sector's block of the checked .xl: applied again each time the list is built
    private XlSectorBlock? _xlBlock;
    private string _xlFileName = "";

    public IReadOnlyList<string> Categories { get; }

    public IReadOnlyList<string> TargetGroups { get; }

    /// <summary>While searching, the groups open by themselves.</summary>
    public bool IsFiltering => FilterText.Trim().Length > 0;

    // an object picked in the preview, selected the next time the list is built
    private int? _pendingNodeDataIndex;

    partial void OnFilterTextChanged(string value)
    {
        OnPropertyChanged(nameof(IsFiltering));
        FilterChanged?.Invoke(this, EventArgs.Empty);
    }

    partial void OnOnlyCookedChanged(bool value) => FilterChanged?.Invoke(this, EventArgs.Empty);

    partial void OnOnlyHiddenChanged(bool value) => FilterChanged?.Invoke(this, EventArgs.Empty);

    partial void OnOnlyInXlChanged(bool value) => FilterChanged?.Invoke(this, EventArgs.Empty);

    partial void OnSelectedCategoryChanged(string value) => FilterChanged?.Invoke(this, EventArgs.Empty);

    partial void OnSelectedTargetGroupChanged(string value) => FilterChanged?.Invoke(this, EventArgs.Empty);

    /// <summary>Reads the sector again each time the tab is shown: edits made in the data tab show up.</summary>
    public override void OnSelected()
    {
        base.OnSelected();
        Refresh();
    }

    [RelayCommand]
    private void Refresh()
    {
        // ticked instances / actors survive a refresh (the list is read again each time the tab is shown)
        var ticked = Objects
            .SelectMany(o => o.Elements.Where(e => e.IsChecked).Select(e => (o.NodeDataIndex, e.Index)))
            .ToHashSet();

        var objects = SectorObjectList.Build(_sector);
        if (ticked.Count > 0)
        {
            foreach (var o in objects)
            {
                foreach (var e in o.Elements)
                {
                    e.IsChecked = ticked.Contains((o.NodeDataIndex, e.Index));
                }
            }
        }

        ApplyXl(objects);
        Objects = objects;

        var cooked = objects.Count(o => o.IsCooked);
        var variants = objects.Select(o => o.Variant).Distinct().Count();
        var hidden = objects.Count(o => o.IsHidden);
        if (_pendingNodeDataIndex is { } pending)
        {
            _pendingNodeDataIndex = null;
            if (objects.FirstOrDefault(o => o.NodeDataIndex == pending) is { } picked)
            {
                // shows the one row, its groups open
                FilterText = $"#{picked.NodeDataIndex}";
                SelectedObject = picked;
            }
        }

        Summary = string.Format(CultureInfo.CurrentCulture,
            "{0} nodes → {1} objects · {2} in cooked nodes · {3} node range(s){4}",
            _sector.Nodes.Count, objects.Count, cooked, variants, hidden > 0 ? $" · {hidden} hidden" : "");
        FilterChanged?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>Whether a row passes the search and the filters.</summary>
    public bool Matches(SectorObject item)
    {
        if (OnlyCooked && !item.IsCooked)
        {
            return false;
        }

        if (OnlyHidden && !item.IsHidden)
        {
            return false;
        }

        if (OnlyInXl && item.XlMark is null)
        {
            return false;
        }

        if (SelectedCategory != AllCategories && !item.Categories.Contains(SelectedCategory, StringComparison.Ordinal))
        {
            return false;
        }

        if (SelectedTargetGroup != AllTargetGroups && item.TargetGroup != SelectedTargetGroup)
        {
            return false;
        }

        var text = FilterText.Trim();
        if (text.Length == 0)
        {
            return true;
        }

        // every word somewhere in the row: "hedge 1057", "decal variant 7"; "#157" is exactly nodeData entry 157
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).All(word =>
            word.Length > 1 && word[0] == '#' && int.TryParse(word.AsSpan(1), NumberStyles.None, CultureInfo.InvariantCulture, out var entry)
                ? item.NodeDataIndex == entry
                : Contains(item.Name, word) || Contains(item.Resource, word) || Contains(item.Appearance, word) ||
            Contains(item.ClassName, word) || Contains(item.Group, word) || Contains(item.DebugName, word) ||
            Contains(item.VariantName, word) || Contains(item.Categories, word) || Contains(item.Where, word));
    }

    private static bool Contains(string? text, string word) =>
        text?.Contains(word, StringComparison.OrdinalIgnoreCase) == true;

    /// <summary>Shows the object's node in the data tab.</summary>
    [RelayCommand]
    private void OpenInData(SectorObject? item)
    {
        if ((item ?? SelectedObject) is { } target)
        {
            NodeOpenRequested?.Invoke(this, target.NodeIndex);
        }
    }

    /// <summary>
    /// Checks an ArchiveXL file's removals against this sector, as ArchiveXL would: the rows it removes are marked,
    /// those it no longer matches (another class, another count) are flagged, and a report lists every problem.
    /// </summary>
    [RelayCommand]
    private void CheckXl()
    {
        var dialog = new Microsoft.Win32.OpenFileDialog
        {
            Title = "Check an ArchiveXL removal against this sector",
            Filter = "ArchiveXL files (*.xl)|*.xl|YAML files (*.yaml;*.yml)|*.yaml;*.yml|All files (*.*)|*.*",
        };
        if (dialog.ShowDialog() != true)
        {
            return;
        }

        List<XlSectorBlock> blocks;
        try
        {
            blocks = SectorXlCheck.Parse(System.IO.File.ReadAllText(dialog.FileName));
        }
        catch (Exception e)
        {
            Interactions.ShowMessageBox($"The file couldn't be read as YAML:\n{e.Message}", "Check .xl", WMessageBoxButtons.Ok, WMessageBoxImage.Error);
            return;
        }

        if (SectorXlCheck.FindBlock(blocks, RelativeFilePath) is not { } block)
        {
            Interactions.ShowMessageBox(
                $"{System.IO.Path.GetFileName(dialog.FileName)} has no removals for {RelativeFilePath} " +
                $"({blocks.Count} sector(s) in the file).", "Check .xl", WMessageBoxButtons.Ok, WMessageBoxImage.Information);
            return;
        }

        _xlBlock = block;
        _xlFileName = System.IO.Path.GetFileName(dialog.FileName);
        Refresh();

        var problems = SectorXlCheck.Check(block, Objects).Problems;
        if (problems.Count > 0)
        {
            var shown = string.Join("\n", problems.Take(25));
            var more = problems.Count > 25 ? $"\n… and {problems.Count - 25} more" : "";
            Interactions.ShowMessageBox($"{_xlFileName}:\n\n{shown}{more}", "Check .xl", WMessageBoxButtons.Ok, WMessageBoxImage.Warning);
        }
    }

    /// <summary>Forgets the checked .xl.</summary>
    [RelayCommand]
    private void ClearXl()
    {
        _xlBlock = null;
        _xlFileName = "";
        OnlyInXl = false;
        Refresh();
    }

    private void ApplyXl(IReadOnlyList<SectorObject> objects)
    {
        HasXl = _xlBlock is not null;
        if (_xlBlock is not { } block)
        {
            XlSummary = "";
            return;
        }

        var result = SectorXlCheck.Check(block, objects);
        foreach (var (index, deletion) in result.Valid)
        {
            var o = objects[index];
            if (deletion.Elements.Count > 0)
            {
                foreach (var element in o.Elements)
                {
                    element.IsChecked = deletion.Elements.Contains(element.Index);
                }

                var what = deletion.ElementKind == SectorElementKind.Actor ? "actors" : "instances";
                o.XlMark = $"removes {what} {string.Join(", ", deletion.Elements)}";
            }
            else
            {
                o.XlMark = "removed";
            }

            // a sector the file no longer fits is skipped as a whole
            o.XlProblem = result.SectorRejected;
        }

        foreach (var (index, problem) in result.RowProblems)
        {
            objects[index].XlMark = "⚠ " + problem;
            objects[index].XlProblem = true;
        }

        XlSummary = string.Format(CultureInfo.CurrentCulture, "{0}: {1} removal(s), {2} match, {3} don't{4}",
            _xlFileName, block.Deletions.Count, result.Valid.Count, result.Problems.Count - (result.SectorRejected ? 1 : 0),
            result.SectorRejected ? " · expectedNodes differs: ArchiveXL skips the whole sector" : "");
    }

    /// <summary>The object picked in the sector preview: selected when this tab is shown.</summary>
    public void SelectWhenShown(int nodeDataIndex) => _pendingNodeDataIndex = nodeDataIndex;

    /// <summary>Shows the object in the sector preview.</summary>
    [RelayCommand]
    private void ShowInPreview(SectorObject? item)
    {
        if ((item ?? SelectedObject) is { } target)
        {
            PreviewOpenRequested?.Invoke(this, (target.NodeIndex, target.NodeDataIndex));
        }
    }

    /// <summary>
    /// An ArchiveXL removal (see <see cref="SectorObjectList.BuildXlRemoval"/>) of the selected rows and of every row
    /// with instances or actors ticked.
    /// </summary>
    public void CopyXlRemoval(IEnumerable<SectorObject> selected)
    {
        var items = selected.Union(Objects.Where(o => o.Elements.Any(e => e.IsChecked))).ToList();
        if (items.Count == 0)
        {
            return;
        }

        Clipboard.SetText(SectorObjectList.BuildXlRemoval(RelativeFilePath, Objects.Count, items));
    }

    /// <summary>
    /// An ArchiveXL mutation (see <see cref="SectorObjectList.BuildXlMutation"/>) of the selected rows, with their
    /// current transforms to edit.
    /// </summary>
    public void CopyXlMutation(IEnumerable<SectorObject> selected)
    {
        var items = selected.ToList();
        if (items.Count == 0)
        {
            return;
        }

        Clipboard.SetText(SectorObjectList.BuildXlMutation(RelativeFilePath, Objects.Count, items));
    }

    /// <summary>Class, indices, resource and position: what an .xl removal or a bug report needs.</summary>
    [RelayCommand]
    private void CopySummary(SectorObject? item)
    {
        if ((item ?? SelectedObject) is { } target)
        {
            Clipboard.SetText(target.Summary);
        }
    }
}

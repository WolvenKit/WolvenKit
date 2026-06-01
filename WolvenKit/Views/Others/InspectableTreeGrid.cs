using System.Collections;
using System.Collections.Generic;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Syncfusion.UI.Xaml.TreeGrid;

namespace WolvenKit.Views.Others;

/// <summary>
/// A thin <see cref="SfTreeGrid"/> subclass that exposes a leaf-node count
/// through the standard UIA <b>Grid</b> pattern so FlaUI can read it via
/// <c>element.Patterns.Grid.Pattern.RowCount</c>.
///
/// <para>
/// <b>RowCount</b> returns the number of <em>leaf</em> nodes (i.e. files, not
/// folders) by recursively walking the bound item tree using the grid's own
/// <see cref="SfTreeGrid.ChildPropertyName"/>. This means the value FlaUI reads
/// is directly comparable to the file count selected in the Asset Browser,
/// without needing to filter folder nodes on the test side.
/// </para>
///
/// Replace <c>syncfusion:SfTreeGrid</c> with <c>others:InspectableTreeGrid</c>
/// in XAML wherever a test needs to inspect the file count.
/// </summary>
public class InspectableTreeGrid : SfTreeGrid
{
    protected override AutomationPeer OnCreateAutomationPeer() =>
        new InspectableTreeGridAutomationPeer(this);
}

internal sealed class InspectableTreeGridAutomationPeer
    : FrameworkElementAutomationPeer, IGridProvider
{
    private readonly InspectableTreeGrid _grid;

    public InspectableTreeGridAutomationPeer(InspectableTreeGrid grid) : base(grid)
    {
        _grid = grid;
    }

    protected override string GetClassNameCore() => nameof(SfTreeGrid);
    protected override AutomationControlType GetAutomationControlTypeCore() =>
        AutomationControlType.Tree;

    public override object GetPattern(PatternInterface patternInterface) =>
        patternInterface == PatternInterface.Grid
            ? this
            : base.GetPattern(patternInterface);

    // ── IGridProvider ─────────────────────────────────────────────────────────

    /// <summary>
    /// Count of leaf nodes (files) in the bound tree. Walks the hierarchy
    /// recursively using <see cref="SfTreeGrid.ChildPropertyName"/> so it stays
    /// correct regardless of which folders happen to be expanded in the UI.
    /// </summary>
    public int RowCount
    {
        get
        {
            if (_grid.ItemsSource is not IEnumerable roots)
            {
                return 0;
            }

            return CountLeaves(roots, _grid.ChildPropertyName);
        }
    }

    public int ColumnCount => _grid.Columns.Count;

    /// <summary>Not needed for count-only tests.</summary>
    public IRawElementProviderSimple? GetItem(int row, int column) => null;

    // ── Helpers ───────────────────────────────────────────────────────────────

    private static int CountLeaves(IEnumerable items, string childPropertyName)
    {
        int count = 0;

        foreach (var item in items)
        {
            var children = GetChildren(item, childPropertyName);

            if (children == null)
            {
                // Leaf node — this is a file.
                count++;
            }
            else
            {
                int childCount = CountLeaves(children, childPropertyName);
                if (childCount == 0)
                {
                    // Children collection exists but is empty — treat as leaf.
                    count++;
                }
                else
                {
                    count += childCount;
                }
            }
        }

        return count;
    }

    private static IEnumerable? GetChildren(object item, string childPropertyName)
    {
        var prop = item.GetType().GetProperty(childPropertyName);
        if (prop == null)
        {
            return null;
        }

        return prop.GetValue(item) as IEnumerable;
    }
}

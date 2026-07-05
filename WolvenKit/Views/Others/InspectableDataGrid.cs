#nullable enable
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Syncfusion.UI.Xaml.Grid;

namespace WolvenKit.Views.Others;

/// <summary>
/// A thin <see cref="SfDataGrid"/> subclass that exposes its logical row count
/// through the standard UIA <b>Grid</b> pattern so FlaUI can read it via
/// <c>element.Patterns.Grid.Pattern.RowCount</c>.
///
/// Syncfusion's Coded UI plugin is unmaintained and cannot be built against
/// modern SDKs. Overriding <see cref="OnCreateAutomationPeer"/> bypasses it
/// entirely — no extra plugin required on either the app or test side.
///
/// Replace <c>syncfusion:SfDataGrid</c> with <c>others:InspectableDataGrid</c>
/// in XAML wherever a test needs to inspect the row count.
/// </summary>
public class InspectableDataGrid : SfDataGrid
{
    static InspectableDataGrid()
    {
        // Help Syncfusion defaults reach the subclass.
#pragma warning disable WPF0018
        DefaultStyleKeyProperty.OverrideMetadata(
            typeof(InspectableDataGrid),
            new FrameworkPropertyMetadata(typeof(SfDataGrid)));
#pragma warning restore WPF0018
    }

    protected override AutomationPeer OnCreateAutomationPeer() =>
        new InspectableDataGridAutomationPeer(this);
}

internal sealed class InspectableDataGridAutomationPeer
    : FrameworkElementAutomationPeer, IGridProvider
{
    private readonly InspectableDataGrid _grid;

    public InspectableDataGridAutomationPeer(InspectableDataGrid grid) : base(grid)
    {
        _grid = grid;
    }

    protected override string GetClassNameCore() => nameof(SfDataGrid);
    protected override AutomationControlType GetAutomationControlTypeCore() =>
        AutomationControlType.DataGrid;

    public override object? GetPattern(PatternInterface patternInterface) =>
        patternInterface == PatternInterface.Grid
            ? this
            : base.GetPattern(patternInterface);

    // ── IGridProvider ─────────────────────────────────────────────────────────

    /// <summary>
    /// Number of logical (post-filter/sort) rows. Reads from
    /// <c>SfDataGrid.View.Records</c> so it stays correct when filters are active.
    /// </summary>
    public int RowCount
    {
        get
        {
            if (_grid.View?.Records is { } records)
            {
                return records.Count;
            }

            if (_grid.ItemsSource is System.Collections.ICollection col)
            {
                return col.Count;
            }

            return 0;
        }
    }

    public int ColumnCount => _grid.Columns.Count;

    /// <summary>
    /// Returns null — individual cell providers are not needed for our tests.
    /// Implement if you need FlaUI to traverse individual cells.
    /// </summary>
    public IRawElementProviderSimple? GetItem(int row, int column) => null;
}

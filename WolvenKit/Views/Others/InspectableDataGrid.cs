using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Syncfusion.UI.Xaml.Grid;

namespace WolvenKit.Views.Others;

/// <summary>
/// A thin <see cref="SfDataGrid"/> subclass that exposes its logical row count
/// through the standard UIA <b>Value</b> and <b>Table</b> patterns.
///
/// Syncfusion's Coded UI plugin is unmaintained and cannot be built against
/// modern SDKs. By overriding <see cref="OnCreateAutomationPeer"/> we bypass
/// that entirely: FlaUI (or any UIA client) can read the count via:
/// <code>
///   int count = int.Parse(element.Patterns.Value.Pattern.Value.ValueOrDefault);
/// </code>
///
/// Replace <c>syncfusion:SfDataGrid</c> with <c>others:InspectableDataGrid</c>
/// in XAML wherever a test needs to inspect the row count.
/// </summary>
public class InspectableDataGrid : SfDataGrid
{
    protected override AutomationPeer OnCreateAutomationPeer() =>
        new InspectableDataGridAutomationPeer(this);
}

internal sealed class InspectableDataGridAutomationPeer
    : FrameworkElementAutomationPeer, IValueProvider, ITableProvider
{
    private readonly InspectableDataGrid _grid;

    public InspectableDataGridAutomationPeer(InspectableDataGrid grid) : base(grid)
    {
        _grid = grid;
    }

    protected override string GetClassNameCore() => nameof(SfDataGrid);
    protected override AutomationControlType GetAutomationControlTypeCore() =>
        AutomationControlType.DataGrid;

    public override object GetPattern(PatternInterface patternInterface) =>
        patternInterface is PatternInterface.Value or PatternInterface.Table
            ? this
            : base.GetPattern(patternInterface);

    // ── IValueProvider ────────────────────────────────────────────────────────
    // The Value is a plain integer string — easy to parse in FlaUI without any
    // Syncfusion dependencies on the test side.

    public bool IsReadOnly => true;

    /// <summary>
    /// Returns the number of logical (filtered/sorted) rows as a string.
    /// Reads from <c>SfDataGrid.View.Records</c> so it reflects the current
    /// filter state, not the raw ItemsSource count.
    /// </summary>
    public string Value
    {
        get
        {
            // View.Records is the live, post-filter/sort record list.
            if (_grid.View?.Records is { } records)
            {
                return records.Count.ToString();
            }

            // Fallback: raw ItemsSource count (no filtering applied).
            if (_grid.ItemsSource is System.Collections.ICollection col)
            {
                return col.Count.ToString();
            }

            return "0";
        }
    }

    public void SetValue(string value) =>
        throw new InvalidOperationException("InspectableDataGrid row count is read-only.");

    // ── ITableProvider ────────────────────────────────────────────────────────
    // Implementing Table lets UIA clients discover the count via the Table
    // pattern as well (e.g. element.Patterns.Table.Pattern.RowCount).

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

    public RowOrColumnMajor RowOrColumnMajor => RowOrColumnMajor.RowMajor;

    public IRawElementProviderSimple[] GetRowHeaders() =>
        Array.Empty<IRawElementProviderSimple>();

    public IRawElementProviderSimple[] GetColumnHeaders() =>
        Array.Empty<IRawElementProviderSimple>();
}

using System;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WolvenKit.UITests.Helpers;

/// <summary>
/// Helper providing access to the custom Inspectable*Grid controls (via their
/// AutomationIds) and the item counts they expose through the UIA Grid pattern.
/// This encapsulates the special behavior of InspectableDataGrid / InspectableTreeGrid
/// so tests can easily get file/row counts without duplicating the peer checks.
/// </summary>
public sealed class InspectableGridHelpers
{
    private readonly AutomationElement _mainWindow;
    private readonly ConditionFactory _cf;
    private readonly WaitForElement _waitForElement;

    public delegate AutomationElement WaitForElement(
        Func<AutomationElement?> finder,
        string label = "element",
        int timeoutMs = 30_000);

    public InspectableGridHelpers(
        AutomationElement mainWindow,
        ConditionFactory cf,
        WaitForElement waitForElement)
    {
        _mainWindow = mainWindow ?? throw new ArgumentNullException(nameof(mainWindow));
        _cf = cf ?? throw new ArgumentNullException(nameof(cf));
        _waitForElement = waitForElement ?? throw new ArgumentNullException(nameof(waitForElement));
    }

    /// <summary>
    /// The right-hand file list in the Asset Browser. Backed by InspectableDataGrid
    /// so its Grid.RowCount reflects the logical (post filter/sort) row count.
    /// </summary>
    public AutomationElement AssetBrowserRightFileView
    {
        get
        {
            return _waitForElement(() => _mainWindow
                    .FindFirstDescendant(_cf
                        .ByAutomationId("RightFileView")),
                label: "Asset Browser right file list");
        }
    }

    /// <summary>
    /// The hierarchical tree in the Project Explorer. Backed by InspectableTreeGrid
    /// whose custom automation peer reports leaf (file) count via Grid.RowCount
    /// by walking ChildPropertyName regardless of expansion state.
    /// </summary>
    public AutomationElement ProjectExplorerTreeGrid
    {
        get
        {
            return _waitForElement(() => _mainWindow
                    .FindFirstDescendant(_cf
                        .ByAutomationId("ProjectExplorerTreeGrid")),
                label: "Project Explorer Tree Grid");
        }
    }

    /// <summary>
    /// Returns the row count via the Grid pattern. Includes the assertion that
    /// the Grid pattern is supported (i.e. the Inspectable* wrapper is in use).
    /// </summary>
    public int GetRowCount(AutomationElement gridElement, string elementDescription)
    {
        Assert.IsTrue(gridElement.Patterns.Grid.IsSupported,
            $"{elementDescription} does not support the Grid pattern. " +
            "Ensure the corresponding XAML uses others:InspectableDataGrid / others:InspectableTreeGrid and the app has been rebuilt.");

        return gridElement.Patterns.Grid.Pattern.RowCount;
    }

    /// <summary>
    /// Count of files shown in the Asset Browser's right-hand list (via InspectableDataGrid).
    /// </summary>
    public int CountAssetBrowserFiles() => GetRowCount(AssetBrowserRightFileView, "RightFileView");

    /// <summary>
    /// Returns the leaf (file) node count from the Project Explorer tree via the
    /// Grid pattern exposed by <c>InspectableTreeGrid</c>'s custom automation peer.
    /// The peer walks the bound item hierarchy using <c>ChildPropertyName</c> and
    /// counts only nodes that have no children, so the result directly equals the
    /// number of files — no UIA tree traversal or expand-all required.
    /// </summary>
    public int CountProjectExplorerFiles() => GetRowCount(ProjectExplorerTreeGrid, "ProjectExplorerTreeGrid");
}

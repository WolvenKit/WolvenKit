using System;
using System.Linq;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.Tools;
using FlaUI.Core.WindowsAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WolvenKit.UITests.Helpers;

/// <summary>
/// FlaUI actions for the Asset Browser: left-tree navigation, select-all,
/// context-menu "Add selected items to project", and PE file-count waits.
/// Composed by tests that share the anim_motion_database seed path.
/// </summary>
public sealed class AssetBrowserUiActions
{
    // Path segments to navigate in the Asset Browser's left tree.
    // The first segment is the root archive node name as shown in the tree.
    private static readonly string[] AnimMotionDatabasePath =
    [
        "Archive",
        "base",
        "animations",
        "anim_motion_database"
    ];

    private readonly WolvenKitTestFixture _fixture;
    private readonly Window _mainWindow;
    private readonly InspectableGridHelpers _grids;
    private readonly InspectableGridHelpers.WaitForElement _waitForElement;

    public AssetBrowserUiActions(
        WolvenKitTestFixture fixture,
        Window mainWindow,
        InspectableGridHelpers grids,
        InspectableGridHelpers.WaitForElement waitForElement)
    {
        _fixture = fixture ?? throw new ArgumentNullException(nameof(fixture));
        _mainWindow = mainWindow ?? throw new ArgumentNullException(nameof(mainWindow));
        _grids = grids ?? throw new ArgumentNullException(nameof(grids));
        _waitForElement = waitForElement ?? throw new ArgumentNullException(nameof(waitForElement));
    }

    public AutomationElement LeftNavigation =>
        _waitForElement(() => _mainWindow
                .FindFirstDescendant(_fixture.Automation.ConditionFactory
                    .ByAutomationId("LeftNavigation")),
            label: "Asset Browser left navigation");

    /// <summary>
    /// Navigate to anim_motion_database, select all files, add them to the
    /// project, and wait until Project Explorer reflects the add.
    /// </summary>
    /// <returns>Selected row count from the Asset Browser right file list.</returns>
    public int AddAnimMotionDatabaseFilesToProject()
    {
        NavigateLeftTree(LeftNavigation, AnimMotionDatabasePath);
        ClickSelectAllHeader();

        // RowCount from InspectableDataGrid's Grid pattern (View.Records.Count).
        var rightView = _grids.AssetBrowserRightFileView;
        int selectedCount = _grids.GetRowCount(rightView, "RightFileView");

        Mouse.MoveTo(_grids.AssetBrowserRightFileView.BoundingRectangle.Center());
        Mouse.RightClick();
        Task.Delay(250).Wait();
        ClickContextMenuItem("Add selected items to project");

        WaitForProjectExplorerFileCount(expectedMinimumCount: selectedCount, timeoutMs: 120_000);
        return selectedCount;
    }

    /// <summary>
    /// Expands tree nodes one level at a time to reach the target folder.
    /// Each element in <paramref name="pathSegments"/> is matched against the
    /// displayed Name of tree items (case-insensitive).
    /// </summary>
    public void NavigateLeftTree(AutomationElement treeRoot, string[] pathSegments)
    {
        var cf = _fixture.Automation.ConditionFactory;
        AutomationElement current = treeRoot;

        foreach (var segment in pathSegments)
        {
            // Tree items inside Syncfusion SfTreeGrid are typically exposed as
            // ControlType.DataItem or ControlType.TreeItem depending on the UIA provider.
            var target = _waitForElement(() =>
            {
                var byName = current.FindFirstDescendant(cf.ByName(segment));
                if (byName != null)
                {
                    return byName;
                }

                var allItems = current.FindAllDescendants(
                    cf.ByControlType(ControlType.DataItem)
                    .Or(cf.ByControlType(ControlType.TreeItem)));

                return allItems.FirstOrDefault(el =>
                    string.Equals(el.Name, segment, StringComparison.OrdinalIgnoreCase));
            }, label: $"tree node '{segment}'");

            target.Click();
            Task.Delay(50).Wait();
            Keyboard.Pressing(VirtualKeyShort.RIGHT);
            Task.Delay(50).Wait();
            Keyboard.Release(VirtualKeyShort.RIGHT);
            Task.Delay(50).Wait();

            WolvenKitTestFixture.WaitUntil(
                () => current.FindAllDescendants(
                          cf.ByControlType(ControlType.DataItem)
                          .Or(cf.ByControlType(ControlType.TreeItem))).Length > 1,
                timeoutMs: 5_000);
        }
    }

    public void ClickSelectAllHeader()
    {
        var cf = _fixture.Automation.ConditionFactory;
        var checkBox = _grids.AssetBrowserRightFileView
            .FindFirstDescendant(cf.ByClassName("HeaderRowControl"))
            .FindFirstDescendant(cf.ByControlType(ControlType.CheckBox));
        Mouse.Click(checkBox.BoundingRectangle.Center());
        Task.Delay(100).Wait();
    }

    public void ClickContextMenuItem(string headerText)
    {
        var cf = _fixture.Automation.ConditionFactory;

        // Context menus appear on the desktop, not necessarily inside the main window.
        var contextMenu = _waitForElement(
            () => _fixture.Automation.GetDesktop()
                      .FindFirstDescendant(cf.ByControlType(ControlType.Menu)),
            label: "right-click context menu",
            timeoutMs: 5_000);

        var menuItem = contextMenu.FindFirstDescendant(cf.ByName(headerText))
            ?? throw new InvalidOperationException(
                $"Context menu item '{headerText}' not found. " +
                "Ensure a project is open so that the 'Add selected items to project' item is visible.");

        menuItem.Click();
    }

    /// <summary>
    /// Polls the Project Explorer tree until at least <paramref name="expectedMinimumCount"/>
    /// file nodes are visible, or until the timeout elapses.
    /// </summary>
    public void WaitForProjectExplorerFileCount(int expectedMinimumCount, int timeoutMs)
    {
        bool reached = WolvenKitTestFixture.WaitUntil(
            () => _grids.CountProjectExplorerFiles() >= expectedMinimumCount,
            timeoutMs: timeoutMs,
            pollIntervalMs: 1_000);

        if (!reached)
        {
            int actual = _grids.CountProjectExplorerFiles();
            Assert.Fail(
                $"Timed out waiting for Project Explorer to show {expectedMinimumCount} files. " +
                $"Currently shows {actual}.");
        }
    }
}

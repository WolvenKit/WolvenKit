using System;
using System.IO;
using System.Linq;
using System.Threading;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.UITests.Helpers;

namespace WolvenKit.UITests.Tests;

/// <summary>
/// End-to-end FlaUI test that:
///   1. Creates a new WolvenKit project in a temp directory.
///   2. Opens the Asset Browser and navigates to Archive/base/animations/anim_motion_database/.
///   3. Selects all files via the header checkbox in the right-hand file list.
///   4. Right-clicks and chooses "Add selected items to project".
///   5. Waits for the Project Explorer to reflect the added files.
///   6. Asserts that the number of files visible in the Project Explorer tree
///      matches the number that were selected.
///
/// Prerequisites:
///   • WolvenKit must have been configured (CP77 executable path set in Settings)
///     so that the Asset Browser can load game archives.
///   • Either set the WOLVENKIT_EXE environment variable, or build the WolvenKit
///     project first so the executable exists at the default output location.
///
/// The test is intentionally slow: archive loading + file extraction take time.
/// </summary>
[TestClass]
public class AssetBrowserAddToProjectTest
{
    // Path segments to navigate in the Asset Browser's left tree.
    // The first segment is the root archive node name as shown in the tree.
    private static readonly string[] s_leftTreePath =
    [
        "Archive",
        "base",
        "animations",
        "anim_motion_database"
    ];

    private WolvenKitTestFixture _fixture = null!;
    private Window _mainWindow = null!;
    private string _projectDir = null!;

    [TestInitialize]
    public void Setup()
    {
        _fixture = new WolvenKitTestFixture();
        _mainWindow = _fixture.Start(startupTimeoutSeconds: 90);
        _projectDir = Path.Combine(_fixture.TempRoot, "TestProject");
        Directory.CreateDirectory(_projectDir);
    }

    [TestCleanup]
    public void Teardown()
    {
        _fixture.Dispose();
    }

    [TestMethod]
    [Timeout(300_000)] // 5 minutes — archive loading is the bottleneck
    public void AddAnimMotionDatabaseFiles_CountMatchesProjectExplorer()
    {
        // ── 1. Create a new project ──────────────────────────────────────────
        CreateNewProject(projectName: "UITestProject", projectPath: _projectDir, modName: "UITestMod");

        // ── 2. Wait for the Asset Browser to finish loading archives ─────────
        WaitForAssetBrowserReady();

        // ── 3. Navigate the left tree to the target folder ───────────────────
        var leftNavigation = FindAssetBrowserLeftNavigation();
        NavigateLeftTree(leftNavigation, s_leftTreePath);

        // ── 4. Select all files via the header checkbox ───────────────────────
        var rightFileView = FindAssetBrowserRightFileView();
        int selectedCount = SelectAllAndGetCount(rightFileView);

        Assert.IsTrue(selectedCount > 0,
            "Expected at least one file in anim_motion_database, but the grid appeared empty.");

        // ── 5. Right-click and add selected files to the project ──────────────
        rightFileView.RightClick();
        ClickContextMenuItem("Add selected items to project");

        // ── 6. Wait for the Project Explorer to reflect the added files ───────
        WaitForProjectExplorerFileCount(expectedMinimumCount: selectedCount, timeoutMs: 120_000);

        // ── 7. Count files visible in the Project Explorer tree ───────────────
        int projectExplorerFileCount = CountProjectExplorerFiles();

        // ── 8. Assert counts match ────────────────────────────────────────────
        Assert.AreEqual(selectedCount, projectExplorerFileCount,
            $"Asset Browser selected {selectedCount} files, but Project Explorer shows {projectExplorerFileCount}.");
    }

    // ── Helpers ───────────────────────────────────────────────────────────────

    private void CreateNewProject(string projectName, string projectPath, string modName)
    {
        var cf = _fixture.Automation.ConditionFactory;

        // File → New Project
        var fileMenu = _mainWindow.FindFirstDescendant(cf.ByAutomationId("MenuItemFile"))
            ?? throw new InvalidOperationException("Could not find the File menu.");
        fileMenu.Click();

        var newProjectItem = WaitForElement(() =>
            _mainWindow.FindFirstDescendant(cf.ByAutomationId("MenuItemNewProject")));
        newProjectItem.Click();

        // Fill in the Project Wizard dialog (it may open as a child of the main window or as a separate dialog).
        var wizard = WaitForElement(() =>
            _fixture.Automation.GetDesktop()
                .FindFirstDescendant(cf.ByName("Project Wizard")));

        SetTextBox(wizard, "ProjectNameTextBox", projectName);
        SetTextBox(wizard, "ProjectPathTextBox", projectPath);
        SetTextBox(wizard, "ModNameTextBox", modName);

        var okButton = wizard.FindFirstDescendant(cf.ByAutomationId("OkButton"))
            ?? throw new InvalidOperationException("Could not find the wizard OK button.");
        okButton.Click();

        // Wait until the wizard closes (the project is created and loaded).
        bool wizardClosed = WolvenKitTestFixture.WaitUntil(
            () => _fixture.Automation.GetDesktop()
                      .FindFirstDescendant(cf.ByName("Project Wizard")) == null,
            timeoutMs: 30_000);

        Assert.IsTrue(wizardClosed, "The Project Wizard did not close within 30 seconds after clicking Create.");
    }

    private void WaitForAssetBrowserReady()
    {
        // The Asset Browser shows a "Loading Asset Browser..." overlay while archives
        // are being indexed. We wait until that overlay disappears.
        // If the overlay is not found at all the browser is already ready.
        var cf = _fixture.Automation.ConditionFactory;

        bool ready = WolvenKitTestFixture.WaitUntil(
            () =>
            {
                var loadingLabel = _mainWindow.FindFirstDescendant(
                    cf.ByName("Loading Asset Browser..."));
                return loadingLabel == null || !loadingLabel.IsAvailable;
            },
            timeoutMs: 120_000);

        Assert.IsTrue(ready, "Asset Browser did not finish loading within 120 seconds.");
    }

    private AutomationElement FindAssetBrowserLeftNavigation()
    {
        var cf = _fixture.Automation.ConditionFactory;
        return WaitForElement(
            () => _mainWindow.FindFirstDescendant(cf.ByAutomationId("LeftNavigation")),
            label: "Asset Browser left navigation tree");
    }

    private AutomationElement FindAssetBrowserRightFileView()
    {
        var cf = _fixture.Automation.ConditionFactory;
        return WaitForElement(
            () => _mainWindow.FindFirstDescendant(cf.ByAutomationId("RightFileView")),
            label: "Asset Browser right file view");
    }

    /// <summary>
    /// Expands tree nodes one level at a time to reach the target folder.
    /// Each element in <paramref name="pathSegments"/> is matched against the
    /// displayed Name of tree items (case-insensitive).
    /// </summary>
    private void NavigateLeftTree(AutomationElement treeRoot, string[] pathSegments)
    {
        var cf = _fixture.Automation.ConditionFactory;
        AutomationElement current = treeRoot;

        foreach (var segment in pathSegments)
        {
            // Tree items inside Syncfusion SfTreeGrid are typically exposed as
            // ControlType.DataItem or ControlType.TreeItem depending on the UIA provider.
            var target = WaitForElement(() =>
            {
                // Try by Name first (fastest), then scan children.
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

            // Click to select and expand this node, which populates its children
            // in the virtualized tree.
            target.Click();

            // Give the tree time to expand and populate children.
            WolvenKitTestFixture.WaitUntil(
                () => current.FindAllDescendants(
                          cf.ByControlType(ControlType.DataItem)
                          .Or(cf.ByControlType(ControlType.TreeItem))).Length > 1,
                timeoutMs: 5_000);
        }
    }

    /// <summary>
    /// Clicks the "Select All" checkbox in the SfDataGrid header column, then
    /// returns the total row count exposed by the grid's Table UIA pattern.
    /// Falls back to Ctrl+A if the header checkbox cannot be located.
    /// </summary>
    private int SelectAllAndGetCount(AutomationElement grid)
    {
        var cf = _fixture.Automation.ConditionFactory;

        // The GridCheckBoxSelectorColumn header is a CheckBox in the header row.
        // Syncfusion exposes header cells as ControlType.Custom or Header type.
        bool headerClicked = TryClickSelectAllHeader(grid);

        if (!headerClicked)
        {
            // Fall back: focus the grid and press Ctrl+A.
            grid.Click();
            Keyboard.TypeSimultaneously(VirtualKeyShort.CONTROL, VirtualKeyShort.KEY_A);
            Thread.Sleep(500); // let the selection apply
        }

        // Read the total row count from the UIA Table pattern (works even with
        // data virtualization because Syncfusion reports the full logical count).
        if (grid.Patterns.Table.IsSupported)
        {
            int rowCount = grid.Patterns.Table.Pattern.RowCount;
            if (rowCount > 0)
            {
                return rowCount;
            }
        }

        // Fallback: count visible DataItem children (may undercount with virtualization).
        var visibleRows = grid.FindAllDescendants(cf.ByControlType(ControlType.DataItem));
        return visibleRows.Length;
    }

    /// <summary>
    /// Attempts to find and click the select-all checkbox in the SfDataGrid column header.
    /// Returns true if the click succeeded.
    /// </summary>
    private static bool TryClickSelectAllHeader(AutomationElement grid)
    {
        try
        {
            // The header row is typically the first row-level element of the grid.
            // The GridCheckBoxSelectorColumn header checkbox is a CheckBox child.
            var header = grid.FindFirstDescendant(el =>
                el.ControlType == ControlType.Header
                || el.ControlType == ControlType.HeaderItem);

            if (header == null)
            {
                return false;
            }

            var checkBox = header.FindFirstChild(el =>
                el.ControlType == ControlType.CheckBox);

            if (checkBox == null)
            {
                return false;
            }

            checkBox.AsCheckBox().Click();
            Thread.Sleep(300);
            return true;
        }
        catch
        {
            return false;
        }
    }

    private void ClickContextMenuItem(string headerText)
    {
        var cf = _fixture.Automation.ConditionFactory;

        // Context menus appear on the desktop, not necessarily inside the main window.
        var contextMenu = WaitForElement(
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
    private void WaitForProjectExplorerFileCount(int expectedMinimumCount, int timeoutMs)
    {
        bool reached = WolvenKitTestFixture.WaitUntil(
            () => CountProjectExplorerFiles() >= expectedMinimumCount,
            timeoutMs: timeoutMs,
            pollIntervalMs: 1_000);

        if (!reached)
        {
            int actual = CountProjectExplorerFiles();
            Assert.Fail(
                $"Timed out waiting for Project Explorer to show {expectedMinimumCount} files. " +
                $"Currently shows {actual}.");
        }
    }

    /// <summary>
    /// Counts leaf (file) nodes in the Project Explorer hierarchical tree.
    /// Folder nodes are skipped by checking whether the element has children that
    /// are also TreeItem/DataItem (which folders do, but files don't).
    /// </summary>
    private int CountProjectExplorerFiles()
    {
        var cf = _fixture.Automation.ConditionFactory;

        var treeGrid = _mainWindow.FindFirstDescendant(
            cf.ByAutomationId("ProjectExplorerTreeGrid"));

        if (treeGrid == null)
        {
            return 0;
        }

        var allNodes = treeGrid.FindAllDescendants(
            cf.ByControlType(ControlType.TreeItem)
            .Or(cf.ByControlType(ControlType.DataItem)));

        // A leaf node is one that has no TreeItem/DataItem children of its own.
        return allNodes.Count(node =>
        {
            var children = node.FindAllChildren(
                cf.ByControlType(ControlType.TreeItem)
                .Or(cf.ByControlType(ControlType.DataItem)));
            return children.Length == 0;
        });
    }

    // ── Generic wait helper ───────────────────────────────────────────────────

    private static AutomationElement WaitForElement(
        Func<AutomationElement?> finder,
        string label = "element",
        int timeoutMs = 15_000)
    {
        AutomationElement? result = null;

        bool found = WolvenKitTestFixture.WaitUntil(
            () =>
            {
                result = finder();
                return result != null && result.IsAvailable;
            },
            timeoutMs: timeoutMs);

        if (!found || result == null)
        {
            throw new InvalidOperationException(
                $"Timed out waiting for {label} to appear (waited {timeoutMs / 1000} s).");
        }

        return result;
    }

    private static void SetTextBox(AutomationElement parent, string automationId, string text)
    {
        var cf = parent.Automation.ConditionFactory;
        var textBox = parent.FindFirstDescendant(cf.ByAutomationId(automationId))
            ?? throw new InvalidOperationException($"TextBox '{automationId}' not found in dialog.");

        textBox.AsTextBox().Text = string.Empty;
        textBox.AsTextBox().Enter(text);
    }
}

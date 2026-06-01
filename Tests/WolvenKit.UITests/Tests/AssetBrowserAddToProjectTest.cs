using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.Tools;
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
    private FlaUI.Core.AutomationElements.Window _mainWindow = null!;
    private string _projectDir = null!;

    private ConditionFactory _cf
    {
        get
        {
            return _fixture.Automation.ConditionFactory;
        }
    }

    private AutomationElement _assetBrowserRightFileView
    {
        get
        {
            return WaitForElement(() => _mainWindow
                .FindFirstDescendant(_cf
                    .ByAutomationId("RightFileView")),
            label: "Asset Browser right file list");
        }
    }

    private AutomationElement _assetBrowserLeftNavigation
    {
        get
        {
            return WaitForElement(() => _mainWindow
                    .FindFirstDescendant(_cf
                        .ByAutomationId("LeftNavigation")),
                label: "Asset Browser left navigation");
        }
    }

    private AutomationElement _projectExplorerTreeGrid
    {
        get
        {
            return WaitForElement(() => _mainWindow
                    .FindFirstDescendant(_cf
                        .ByAutomationId("ProjectExplorerTreeGrid")),
                label: "Project Explorer Tree Grid");
        }
    }

    private AutomationElement _projectExplorerView
    {
        get
        {
            return WaitForElement(() => _mainWindow
                    .FindFirstDescendant(_cf
                        .ByAutomationId("Project Explorer View")),
                label: "Project Explorer View");
        }
    }

    [TestInitialize]
    public void Setup()
    {
        _fixture = new WolvenKitTestFixture();
        _mainWindow = _fixture.Start(startupTimeoutSeconds: 90);

        // Create the temp dir for project files.
        _projectDir = Path.Combine(_fixture.TempRoot, "TestProject");
        // e.g. C:\lib\WolvenKit\Tests\WolvenKit.UITests\bin\x64\obj\
        //         UITestTemp\d2ee145c598747f5835796331dad35f5\TestProject
        Directory.CreateDirectory(_projectDir);
    }

    [TestCleanup]
    public void Teardown()
    {
        _fixture.Dispose();
    }

    [TestMethod]
    [Timeout(300_000)] // 5 minutes — archive loading is the bottleneck
    public void  AddAnimMotionDatabaseFiles_CountMatchesProjectExplorer()
    {
        // ── 1. Create a new project ──────────────────────────────────────────
        CreateNewProject(projectName: "UITestProject", projectPath: _projectDir, modName: "UITestMod");

        // ── 2. Wait for the Asset Browser to finish loading archives ─────────
        WaitForAssetBrowserReady();

        // ── 3. Navigate the left tree to the target folder ───────────────────
        var leftNavigation = _assetBrowserLeftNavigation;
        NavigateLeftTree(leftNavigation, s_leftTreePath);

        // ── 4. Select all files via the header checkbox ───────────────────────
        ClickSelectAllHeader();

        // Read the row count via the Grid pattern exposed by InspectableDataGrid's
        // custom automation peer. RowCount comes from View.Records.Count, which is
        // Syncfusion's live post-filter list — no Coded UI plugin required.
        var rightView = _assetBrowserRightFileView;
        Assert.IsTrue(rightView.Patterns.Grid.IsSupported,
            "RightFileView does not support the Grid pattern. " +
            "Ensure AssetBrowserView.xaml uses others:InspectableDataGrid and the app has been rebuilt.");

        int selectedCount = rightView.Patterns.Grid.Pattern.RowCount;

        // ── 5. Right-click and add selected files to the project ──────────────
        Mouse.MoveTo(_assetBrowserRightFileView.BoundingRectangle.Center());
        Mouse.RightClick();
        Task.Delay(250).Wait();
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

        var newProjectItem = WaitForElement(() =>
            _mainWindow.FindFirstDescendant(cf.ByAutomationId("NewProjectButton")));
        newProjectItem.Click();

        // Fill in the Project Wizard dialog (it may open as a child of the main window or as a separate dialog).
        var wizard = WaitForElement(() =>
            _fixture.Automation.GetDesktop()
                .FindFirstDescendant(cf.ByClassName("ProjectWizardView")));

        SetTextBox(wizard, "ProjectNameTextBox", projectName);
        Task.Delay(500).Wait();
        SetTextBox(wizard, "ProjectPathTextBox", projectPath);
        Task.Delay(2000).Wait();
        SetTextBox(wizard, "ModNameTextBox", modName);
        Task.Delay(500).Wait();

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
                var progressStatus = _mainWindow.FindFirstDescendant(
                    cf.ByAutomationId("ProgressStatus").And(cf.ByText("Ready")));
                return progressStatus != null;
            },
            timeoutMs: 120_000);

        Assert.IsTrue(ready, "Asset Browser did not finish loading within 120 seconds.");
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

            // Click to select and press right arrow to expand this folder.
            target.Click();
            Task.Delay(50).Wait();
            Keyboard.Pressing(VirtualKeyShort.RIGHT);
            Task.Delay(50).Wait();
            Keyboard.Release(VirtualKeyShort.RIGHT);
            Task.Delay(50).Wait();

            // Give the tree time to expand and populate children.
            WolvenKitTestFixture.WaitUntil(
                () => current.FindAllDescendants(
                          cf.ByControlType(ControlType.DataItem)
                          .Or(cf.ByControlType(ControlType.TreeItem))).Length > 1,
                timeoutMs: 5_000);
        }
    }

    // private AutomationElement FindExpansionButtonForFolderName(string folderName, AutomationElement parent) =>
    //     WaitForElement(() => ExpansionButtonForFolderName(folderName, parent));
    //
    // private AutomationElement ExpansionButtonForFolderName(string folderName, AutomationElement parent)
    // {
    //     var cf = _fixture.Automation.ConditionFactory;
    //     var folderIcon = parent
    //         .FindFirstDescendant(cf.ByAutomationId(folderName)
    //             .And(cf.ByClassName("FileIcon")));
    //
    //     if (folderIcon == null)
    //     {
    //         throw new InvalidOperationException($"Could not find the folder icon for folder {folderName}");
    //     }
    //
    //     var rowContainer = folderIcon.Parent;
    //     // or .Ancestor(cf => cf.ByControlType(ControlType.ListItem) || cf.ByClassName("TreeGridRow"))
    //
    //     if (rowContainer == null)
    //     {
    //         throw new InvalidOperationException($"Could not find the parent row of folder {folderName}");
    //     }
    //
    //     var expander = rowContainer
    //         .FindFirstDescendant(cf.ByControlType(ControlType.Button)
    //             .Or(cf.ByClassName("TreeGridExpanderCell")))
    //         .AsButton();
    //
    //     if (expander == null)
    //     {
    //         throw new InvalidOperationException($"Could not find the expander button for folder {folderName}");
    //     }
    //
    //     return expander;
    // }

    /// <summary>
    /// Attempts to find and click the select-all checkbox in the SfDataGrid column header.
    /// Returns true if the click succeeded.
    /// </summary>
    private void ClickSelectAllHeader()
    {
        var checkBox = _assetBrowserRightFileView
            .FindFirstDescendant(_cf.ByClassName("HeaderRowControl"))
            .FindFirstDescendant(_cf.ByControlType(ControlType.CheckBox));
        Mouse.Click(checkBox.BoundingRectangle.Center());
        Task.Delay(100).Wait();
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
    /// Returns the leaf (file) node count from the Project Explorer tree via the
    /// Grid pattern exposed by <c>InspectableTreeGrid</c>'s custom automation peer.
    /// The peer walks the bound item hierarchy using <c>ChildPropertyName</c> and
    /// counts only nodes that have no children, so the result directly equals the
    /// number of files — no UIA tree traversal or expand-all required.
    /// </summary>
    private int CountProjectExplorerFiles()
    {
        var treeGrid = _projectExplorerTreeGrid;

        Assert.IsTrue(treeGrid.Patterns.Grid.IsSupported,
            "ProjectExplorerTreeGrid does not support the Grid pattern. " +
            "Ensure ProjectExplorerView.xaml uses others:InspectableTreeGrid and the app has been rebuilt.");

        return treeGrid.Patterns.Grid.Pattern.RowCount;
    }

    // ── Generic wait helper ───────────────────────────────────────────────────

    private static AutomationElement WaitForElement(
        Func<AutomationElement?> finder,
        string label = "element",
        int timeoutMs = 30_000)
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
        Task.Delay(500).Wait();
        textBox.AsTextBox().Enter(text);
        Task.Delay(500).Wait();
    }
}

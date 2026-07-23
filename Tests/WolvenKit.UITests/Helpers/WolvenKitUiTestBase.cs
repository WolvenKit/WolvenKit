using System;
using System.IO;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WolvenKit.UITests.Helpers;

/// <summary>
/// Shared lifecycle and primitives for WolvenKit FlaUI tests.
///
/// Owns app launch/dispose, temp project directory, inspectable grids, and the
/// common "create project + wait for Asset Browser ready" bootstrap. Domain
/// flows (Asset Browser navigation, Project Explorer ops) live in dedicated
/// action helpers composed on top of this base.
/// </summary>
public abstract class WolvenKitUiTestBase
{
    protected WolvenKitTestFixture Fixture { get; private set; } = null!;
    protected Window MainWindow { get; private set; } = null!;
    protected string ProjectDir { get; private set; } = null!;
    protected InspectableGridHelpers Grids { get; private set; } = null!;
    protected AssetBrowserUiActions AssetBrowser { get; private set; } = null!;

    protected ConditionFactory Cf => Fixture.Automation.ConditionFactory;

    [TestInitialize]
    public void Setup()
    {
        Fixture = new WolvenKitTestFixture();
        MainWindow = Fixture.Start(startupTimeoutSeconds: 90);

        // e.g. ...\WolvenKit.UITests\bin\x64\obj\UITestTemp\{guid}\TestProject
        ProjectDir = Path.Combine(Fixture.TempRoot, "TestProject");
        Directory.CreateDirectory(ProjectDir);

        Grids = new InspectableGridHelpers(MainWindow, Cf, WaitForElement);
        AssetBrowser = new AssetBrowserUiActions(Fixture, MainWindow, Grids, WaitForElement);
    }

    [TestCleanup]
    public void Teardown()
    {
        Fixture.Dispose();
    }

    /// <summary>
    /// Creates a fresh project and waits until the Asset Browser has finished
    /// indexing archives (status "Ready"). Common fork point for AB and PE tests.
    /// </summary>
    protected void CreateProjectAndWaitForAssetBrowserReady()
    {
        CreateNewProject(projectName: "UITestProject", projectPath: ProjectDir, modName: "UITestMod");
        WaitForAssetBrowserReady();
    }

    /// <summary>
    /// Full shared seed used by Asset Browser count tests and Project Explorer
    /// tests: create project, wait for AB, navigate to anim_motion_database,
    /// select all, add to project, wait for Project Explorer.
    /// </summary>
    /// <returns>Asset Browser selected row count at the time of add.</returns>
    protected int SeedProjectWithAnimMotionDatabaseFiles()
    {
        CreateProjectAndWaitForAssetBrowserReady();
        return AssetBrowser.AddAnimMotionDatabaseFilesToProject();
    }

    protected void CreateNewProject(string projectName, string projectPath, string modName)
    {
        var cf = Fixture.Automation.ConditionFactory;

        var newProjectItem = WaitForElement(() =>
            MainWindow.FindFirstDescendant(cf.ByAutomationId("NewProjectButton")));
        newProjectItem.Click();

        // Project Wizard may open as a desktop-level dialog.
        var wizard = WaitForElement(() =>
            Fixture.Automation.GetDesktop()
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

        bool wizardClosed = WolvenKitTestFixture.WaitUntil(
            () => Fixture.Automation.GetDesktop()
                      .FindFirstDescendant(cf.ByName("Project Wizard")) == null,
            timeoutMs: 30_000);

        Assert.IsTrue(wizardClosed, "The Project Wizard did not close within 30 seconds after clicking Create.");
    }

    protected void WaitForAssetBrowserReady()
    {
        // Wait until ProgressStatus reports "Ready" (archive indexing finished).
        var cf = Fixture.Automation.ConditionFactory;

        bool ready = WolvenKitTestFixture.WaitUntil(
            () =>
            {
                var progressStatus = MainWindow.FindFirstDescendant(
                    cf.ByAutomationId("ProgressStatus").And(cf.ByText("Ready")));
                return progressStatus != null;
            },
            timeoutMs: 120_000);

        Assert.IsTrue(ready, "Asset Browser did not finish loading within 120 seconds.");
    }

    protected static AutomationElement WaitForElement(
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

    protected static void SetTextBox(AutomationElement parent, string automationId, string text)
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

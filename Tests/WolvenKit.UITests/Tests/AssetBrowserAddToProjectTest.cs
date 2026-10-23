using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.UITests.Helpers;

namespace WolvenKit.UITests.Tests;

/// <summary>
/// UI tests that exercise the Asset Browser + "Add to project" flow using FlaUI.
///
/// Shared bootstrap and AB actions live in <see cref="WolvenKitUiTestBase"/> and
/// <see cref="AssetBrowserUiActions"/>. Project Explorer tests reuse the same seed
/// via <see cref="WolvenKitUiTestBase.SeedProjectWithAnimMotionDatabaseFiles"/>.
///
/// Prerequisites:
///   • WolvenKit must have been configured (CP77 executable path set in Settings)
///     so that the Asset Browser can load game archives.
///
/// These tests are intentionally slow: archive loading + file extraction take time.
/// </summary>
[TestClass]
public class AssetBrowserAddToProjectTest : WolvenKitUiTestBase
{
    [TestMethod]
    [Timeout(120_000)]
    public void AssetBrowserFinishesLoadingAfterProjectCreation()
    {
        // Reaches the point where a new project exists and the Asset Browser
        // has finished its archive indexing/loading.
        CreateProjectAndWaitForAssetBrowserReady();

        // Ensure the custom inspectable grids (and their UIA peers) are reachable.
        _ = Grids.AssetBrowserRightFileView;
        _ = Grids.ProjectExplorerTreeGrid;
    }

    [TestMethod]
    [Timeout(300_000)] // 5 minutes — archive loading is the bottleneck
    public void AddAnimMotionDatabaseFiles_CountMatchesProjectExplorer()
    {
        int selectedCount = SeedProjectWithAnimMotionDatabaseFiles();

        // Count files visible in the Project Explorer tree.
        // (we added 2 folders and 27 files; already had 3 folders)
        int projectExplorerFileCount = Grids.CountProjectExplorerFiles() + 3;

        Task.Delay(400).Wait();

        Assert.AreEqual(selectedCount, projectExplorerFileCount - 5,
            $"Asset Browser selected {selectedCount} files, but Project Explorer shows {projectExplorerFileCount}.");
    }
}

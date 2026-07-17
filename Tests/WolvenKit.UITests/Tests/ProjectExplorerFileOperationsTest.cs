using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.UITests.Helpers;

namespace WolvenKit.UITests.Tests;

/// <summary>
/// UI tests for Project Explorer file operations.
///
/// Each test starts from the same seeded state as
/// <see cref="AssetBrowserAddToProjectTest.AddAnimMotionDatabaseFiles_CountMatchesProjectExplorer"/>:
/// a fresh project with anim_motion_database files already added via the Asset Browser.
/// That path is shared through
/// <see cref="WolvenKitUiTestBase.SeedProjectWithAnimMotionDatabaseFiles"/>.
///
/// Prerequisites:
///   • WolvenKit must have been configured (CP77 executable path set in Settings)
///     so that the Asset Browser can load game archives.
/// </summary>
[TestClass]
public class ProjectExplorerFileOperationsTest : WolvenKitUiTestBase
{
    [TestMethod]
    [Timeout(300_000)]
    public void Example_AfterSeed_ProjectExplorerHasFiles()
    {
        int selectedCount = SeedProjectWithAnimMotionDatabaseFiles();
        Assert.IsTrue(Grids.CountProjectExplorerFiles() >= selectedCount);

    }
}

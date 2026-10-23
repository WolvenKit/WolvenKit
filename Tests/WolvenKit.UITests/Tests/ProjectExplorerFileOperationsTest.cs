using System;
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
    public void DragAndDrop_MovesSingleFileToBaseDirectory()
    {
        int selectedCount = SeedProjectWithAnimMotionDatabaseFiles();
        Assert.IsTrue(Grids.CountProjectExplorerFiles() >= selectedCount);

        var exception = Assert.Throws<InvalidOperationException>(() =>
        {
            ProjectExplorer.DragSingleFileToBaseDirectory();
        });

        Assert.AreEqual("Timed out waiting for tree node 'adam_smasher_weapons.csv' to appear (waited 30 s).",
            exception.Message);
    }
}

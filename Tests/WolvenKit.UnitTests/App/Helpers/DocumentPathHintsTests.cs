using WolvenKit.App.Helpers;
using Xunit;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// Hints next to the tab labels of open files with the same name: only for those files, and only the end of the
/// folder path that tells them apart.
/// </summary>
public class DocumentPathHintsTests
{
    [Fact]
    public void UniqueNames_GetNoHint()
    {
        var hints = DocumentPathHints.Compute([@"C:\mod\archive\a\jacket.mesh", @"C:\mod\archive\a\pants.mesh"]);

        Assert.All(hints, Assert.Null);
    }

    [Fact]
    public void SameName_GetsTheDifferingParentFolder()
    {
        var hints = DocumentPathHints.Compute(
        [
            @"C:\mod\archive\base\characters\jacket.mesh",
            @"C:\mod\archive\ep1\characters\jacket.mesh",
            @"C:\mod\archive\base\other.mesh"
        ]);

        Assert.Equal(@"…\base\characters", hints[0]);
        Assert.Equal(@"…\ep1\characters", hints[1]);
        Assert.Null(hints[2]);
    }

    [Fact]
    public void ParentFolderDiffers_ShowsOnlyThatFolder()
    {
        var hints = DocumentPathHints.Compute([@"C:\mod\archive\male\jacket.mesh", @"C:\mod\archive\female\jacket.mesh"]);

        Assert.Equal(@"…\male", hints[0]);
        Assert.Equal(@"…\female", hints[1]);
    }

    [Fact]
    public void NamesCompareIgnoringCase()
    {
        var hints = DocumentPathHints.Compute([@"C:\a\Jacket.mesh", @"C:\b\jacket.MESH"]);

        Assert.Equal(@"…\a", hints[0]);
        Assert.Equal(@"…\b", hints[1]);
    }

    [Fact]
    public void SameFileTwice_GetsNoHint()
    {
        var hints = DocumentPathHints.Compute([@"C:\a\jacket.mesh", @"C:\a\jacket.mesh"]);

        Assert.All(hints, Assert.Null);
    }

    [Fact]
    public void OnePathEndsTheOther_ShowsTheWholeFolderPath()
    {
        // "x\jacket.mesh" and "y\x\jacket.mesh": every folder of the first one ends the second one
        var hints = DocumentPathHints.Compute([@"x\jacket.mesh", @"y\x\jacket.mesh"]);

        Assert.Equal("x", hints[0]);
        Assert.Equal(@"y\x", hints[1]);
    }

    [Fact]
    public void EmptyPaths_AreIgnored()
    {
        var hints = DocumentPathHints.Compute([null, "", @"C:\a\jacket.mesh"]);

        Assert.All(hints, Assert.Null);
    }
}

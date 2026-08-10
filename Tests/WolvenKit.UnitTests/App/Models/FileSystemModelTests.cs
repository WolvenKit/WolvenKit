using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.RED4.Types;
using Xunit;
using AppConstants = WolvenKit.App.Constants;

namespace Wolvenkit.Test.App.Models;

/// <summary>
/// Covers <see cref="FileSystemModel"/> against a real throwaway project directory on disk.
///
/// These touch the filesystem because the model is not mockable: the constructor eagerly calls
/// <see cref="FileSystemModel.UpdateFileInfo"/> for every non-directory node, which does
/// <c>new FileInfo(FullName).Length</c>. A file node therefore cannot exist unless the file
/// physically exists. They need nothing beyond <see cref="Path.GetTempPath"/> though - no game
/// install, no project fixture - so they belong here and not in the integration tests.
///
/// The tree shape mirrors what <c>WatcherService</c> builds:
/// the root is <c>&lt;ProjectDir&gt;</c> whose <c>RawRelativePath</c> is the *absolute*
/// project directory; every descendant's <c>RawRelativePath</c> is relative to it.
///
/// <see cref="FileSystemModel.PropertyChanged"/> behaviour is deliberately out of scope.
/// </summary>
public sealed class FileSystemModelTests : IDisposable
{
    private readonly string _projectDirectory;

    public FileSystemModelTests()
    {
        _projectDirectory = Path.Combine(Path.GetTempPath(), "wk-filesystemmodel-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_projectDirectory);
    }

    public void Dispose()
    {
        try
        {
            Directory.Delete(_projectDirectory, true);
        }
        catch (IOException)
        {
            // a leaked temp directory must never fail a test run
        }
    }

    #region helpers

    /// <summary>The <c>&lt;ProjectDir&gt;</c> node, exactly as <c>WatcherService.WatchProject</c> creates it.</summary>
    private FileSystemModel NewRoot() =>
        new(null, FileSystemModel.ProjectDirName, _projectDirectory, true);

    /// <summary>Creates the physical directory and the matching model node, and links it to its parent.</summary>
    private FileSystemModel NewDirectory(FileSystemModel parent, string name)
    {
        var relativePath = RelativePathOf(parent, name);
        Directory.CreateDirectory(Path.Combine(_projectDirectory, relativePath));

        var model = new FileSystemModel(parent, name, relativePath, true);
        AddChild(parent, model);
        return model;
    }

    /// <summary>Creates the physical file (with <paramref name="byteCount"/> bytes) and the matching model node.</summary>
    private FileSystemModel NewFile(FileSystemModel parent, string name, int byteCount = 0)
    {
        var relativePath = RelativePathOf(parent, name);
        WriteBytes(Path.Combine(_projectDirectory, relativePath), byteCount);

        var model = new FileSystemModel(parent, name, relativePath, false);
        AddChild(parent, model);
        return model;
    }

    /// <summary>Top-level nodes hang off the root, whose RawRelativePath is absolute - so they are just the name.</summary>
    private static string RelativePathOf(FileSystemModel parent, string name) =>
        parent.Parent == null ? name : Path.Combine(parent.RawRelativePath, name);

    /// <summary>
    /// Adds through the <see cref="ObservableCollection{T}"/> base so the add is synchronous.
    /// <see cref="DispatchedObservableCollection{T}.Add"/> hides it with a <c>Task.Run</c> under test,
    /// which would make every assertion here a race.
    /// </summary>
    private static void AddChild(FileSystemModel parent, FileSystemModel child) =>
        ((ObservableCollection<FileSystemModel>)parent.Children).Add(child);

    private static void WriteBytes(string path, int byteCount) =>
        File.WriteAllBytes(path, new byte[byteCount]);

    private string AbsolutePath(params string[] parts) =>
        Path.Combine(_projectDirectory, Path.Combine(parts));

    #endregion

    #region constructor

    [Fact]
    public void Constructor_RootNode_KeepsTheAbsoluteProjectDirectoryAsItsFullName()
    {
        var root = NewRoot();

        Assert.Null(root.Parent);
        Assert.Equal(FileSystemModel.ProjectDirName, root.Name);
        Assert.True(root.IsDirectory);
        Assert.Equal(_projectDirectory, root.RawRelativePath);

        // Path.Combine(root, root) collapses to root because the second argument is rooted
        Assert.Equal(_projectDirectory, root.FullName);
    }

    [Fact]
    public void Constructor_RootNode_HasAnEmptyGameRelativePath()
    {
        var root = NewRoot();

        // "<ProjectDir>" is excluded from the game path, and it is the only segment the root has
        Assert.Equal("", root.GameRelativePath);
    }

    [Fact]
    public void Constructor_TopLevelDirectory_IsAlsoExcludedFromTheGameRelativePath()
    {
        var root = NewRoot();

        var archive = NewDirectory(root, "archive");

        // "archive" is the mod root, not part of the in-game path
        Assert.Equal("", archive.GameRelativePath);
    }

    [Fact]
    public void Constructor_NestedFile_BuildsTheGameRelativePathFromEverythingBelowTheTopLevelDirectory()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var baseDir = NewDirectory(archive, "base");

        var file = NewFile(baseDir, "foo.mesh");

        Assert.Equal($"base{ResourcePath.DirectorySeparatorChar}foo.mesh", file.GameRelativePath);
    }

    [Fact]
    public void Constructor_NestedFile_JoinsGamePathSegmentsWithTheRedEngineSeparator()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var baseDir = NewDirectory(archive, "base");
        var deepDir = NewDirectory(baseDir, "deep");

        var file = NewFile(deepDir, "foo.mesh");

        // never Path.DirectorySeparatorChar - the game path is always backslash-joined
        Assert.Equal(@"base\deep\foo.mesh", file.GameRelativePath);
    }

    [Fact]
    public void Constructor_NestedFile_ResolvesFullNameAgainstTheProjectDirectory()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var baseDir = NewDirectory(archive, "base");

        var file = NewFile(baseDir, "foo.mesh");

        Assert.Equal(AbsolutePath("archive", "base", "foo.mesh"), file.FullName);
        Assert.Equal(Path.Combine("archive", "base", "foo.mesh"), file.RawRelativePath);
        Assert.True(File.Exists(file.FullName));
    }

    [Fact]
    public void Constructor_File_DerivesTheExtensionFromTheNameWithoutTheDot()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");

        var file = NewFile(archive, "foo.mesh");

        Assert.Equal("mesh", file.Extension);
    }

    [Fact]
    public void Constructor_FileWithMultipleDots_UsesOnlyTheLastSuffix()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");

        var file = NewFile(archive, "foo.bar.xl");

        Assert.Equal("xl", file.Extension);
    }

    [Fact]
    public void Constructor_FileWithoutExtension_HasAnEmptyExtension()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");

        var file = NewFile(archive, "README");

        Assert.Equal("", file.Extension);
    }

    [Fact]
    public void Constructor_PlainDirectory_UsesTheOpenDirectoryImageKey()
    {
        var root = NewRoot();

        var directory = NewDirectory(root, "somewhere");

        Assert.Equal(nameof(ECustomImageKeys.OpenDirImageKey), directory.Extension);
    }

    [Theory]
    [InlineData("archive", AppConstants.ModDirectoryTop)]
    [InlineData("raw", AppConstants.RawDirectoryTop)]
    [InlineData("resources", AppConstants.ResourceDirectoryTop)]
    public void Constructor_TopLevelDirectory_GetsItsOwnMarkerExtension(string name, string expectedExtension)
    {
        var root = NewRoot();

        var directory = NewDirectory(root, name);

        Assert.Equal(expectedExtension, directory.Extension);
    }

    [Theory]
    [InlineData("Archive")]
    [InlineData("ARCHIVE")]
    public void Constructor_TopLevelDirectory_MatchesItsMarkerCaseInsensitively(string name)
    {
        var root = NewRoot();

        var directory = NewDirectory(root, name);

        Assert.Equal(AppConstants.ModDirectoryTop, directory.Extension);
    }

    [Fact]
    public void Constructor_SubDirectory_InheritsTheExtensionOfItsParent()
    {
        var root = NewRoot();
        var raw = NewDirectory(root, "raw");

        var baseDir = NewDirectory(raw, "base");
        var deepDir = NewDirectory(baseDir, "deep");

        // the marker propagates all the way down, so any node knows which tree it belongs to
        Assert.Equal(AppConstants.RawDirectoryTop, baseDir.Extension);
        Assert.Equal(AppConstants.RawDirectoryTop, deepDir.Extension);
    }

    [Fact]
    public void Constructor_NestedDirectoryNamedArchive_DoesNotGetTheTopLevelMarker()
    {
        var root = NewRoot();
        var raw = NewDirectory(root, "raw");

        var nested = NewDirectory(raw, "archive");

        // the marker check is on the whole relative path ("raw\archive"), not the name
        Assert.Equal(AppConstants.RawDirectoryTop, nested.Extension);
    }

    #endregion

    #region hash

    [Fact]
    public void Constructor_NodeOutsideTheArchiveTree_HasNoHash()
    {
        var root = NewRoot();
        var raw = NewDirectory(root, "raw");

        var file = NewFile(raw, "foo.mesh");

        Assert.Equal(0ul, file.Hash);
        Assert.Equal("0", file.HashStr);
    }

    [Fact]
    public void Constructor_FileInsideTheArchiveTree_HashesItsGameRelativePath()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var baseDir = NewDirectory(archive, "base");

        var file = NewFile(baseDir, "foo.mesh");

        Assert.Equal(ResourcePath.CalculateHash(@"base\foo.mesh"), file.Hash);
        Assert.Equal(file.Hash.ToString(), file.HashStr);
    }

    [Fact]
    public void Constructor_NumericallyNamedFileDirectlyInArchive_TakesItsHashFromTheFileName()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");

        // loose .archive files are named after the hash they contain, so the name wins over the path
        var file = NewFile(archive, "1234567890.archive");

        Assert.Equal(1234567890ul, file.Hash);
        Assert.Equal("1234567890", file.HashStr);
    }

    [Fact]
    public void Constructor_NonNumericFileDirectlyInArchive_FallsBackToHashingTheGameRelativePath()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");

        var file = NewFile(archive, "foo.archive");

        Assert.Equal(ResourcePath.CalculateHash("foo.archive"), file.Hash);
    }

    [Fact]
    public void Constructor_NumericallyNamedFileDeeperInArchive_StillHashesItsPath()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var baseDir = NewDirectory(archive, "base");

        // the filename-is-the-hash shortcut only applies directly under "archive"
        var file = NewFile(baseDir, "1234567890.archive");

        Assert.Equal(ResourcePath.CalculateHash(@"base\1234567890.archive"), file.Hash);
    }

    [Fact]
    public void Constructor_DirectoryInsideTheArchiveTree_AlsoGetsAHash()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var baseDir = NewDirectory(archive, "base");

        var directory = NewDirectory(baseDir, "deep");

        Assert.Equal(ResourcePath.CalculateHash(@"base\deep"), directory.Hash);
    }

    #endregion

    #region UpdateFileInfo

    [Fact]
    public void Constructor_File_PopulatesTheSizeFromDisk()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");

        var file = NewFile(archive, "foo.mesh", 2048);

        Assert.Equal(2048, file.FileSize);
        Assert.Equal("2 KB", file.FileSizeStr);
    }

    [Fact]
    public void Constructor_Directory_LeavesTheSizeUnset()
    {
        var root = NewRoot();

        var directory = NewDirectory(root, "archive");

        // directories never go near FileInfo, so the size stays at its default
        Assert.Equal(0, directory.FileSize);
        Assert.Null(directory.FileSizeStr);
    }

    [Fact]
    public void UpdateFileInfo_AfterTheFileGrows_RefreshesSizeAndItsDisplayString()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var file = NewFile(archive, "foo.mesh", 10);

        WriteBytes(file.FullName, 1536);
        file.UpdateFileInfo();

        Assert.Equal(1536, file.FileSize);
        Assert.Equal("1.5 KB", file.FileSizeStr);
    }

    [Fact]
    public void UpdateFileInfo_AfterTheFileShrinksToNothing_ReportsZeroBytes()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var file = NewFile(archive, "foo.mesh", 4096);

        WriteBytes(file.FullName, 0);
        file.UpdateFileInfo();

        Assert.Equal(0, file.FileSize);
        Assert.Equal("0 B", file.FileSizeStr);
    }

    [Fact]
    public void UpdateFileInfo_WhenTheFileIsGone_Throws()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var file = NewFile(archive, "foo.mesh", 10);

        File.Delete(file.FullName);

        Assert.Throws<FileNotFoundException>(() => file.UpdateFileInfo());
    }

    [Fact]
    public void Constructor_FileThatDoesNotExist_Throws()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");

        // the constructor eagerly reads the size, so a phantom file node cannot be built
        Assert.Throws<FileNotFoundException>(() =>
            new FileSystemModel(archive, "missing.mesh", Path.Combine("archive", "missing.mesh"), false));
    }

    #endregion

    #region Rename

    [Fact]
    public void Rename_OnTheRoot_Throws()
    {
        var root = NewRoot();

        // the root has no parent to rebuild its relative path from
        Assert.Throws<Exception>(() => root.Rename("whatever"));
    }

    [Fact]
    public void Rename_File_UpdatesNamePathsAndExtension()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var baseDir = NewDirectory(archive, "base");
        var file = NewFile(baseDir, "old.mesh", 512);

        File.Move(file.FullName, AbsolutePath("archive", "base", "new.xbm"));
        file.Rename("new.xbm");

        Assert.Equal("new.xbm", file.Name);
        Assert.Equal(Path.Combine("archive", "base", "new.xbm"), file.RawRelativePath);
        Assert.Equal(AbsolutePath("archive", "base", "new.xbm"), file.FullName);
        Assert.Equal(@"base\new.xbm", file.GameRelativePath);
        Assert.Equal("xbm", file.Extension);
    }

    [Fact]
    public void Rename_File_RecomputesTheHashForTheNewPath()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var baseDir = NewDirectory(archive, "base");
        var file = NewFile(baseDir, "old.mesh");

        File.Move(file.FullName, AbsolutePath("archive", "base", "new.mesh"));
        file.Rename("new.mesh");

        Assert.Equal(ResourcePath.CalculateHash(@"base\new.mesh"), file.Hash);
        Assert.Equal(file.Hash.ToString(), file.HashStr);
    }

    [Fact]
    public void Rename_File_RereadsTheSizeFromDisk()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var file = NewFile(archive, "old.mesh", 10);

        WriteBytes(AbsolutePath("archive", "new.mesh"), 3072);
        File.Delete(file.FullName);
        file.Rename("new.mesh");

        Assert.Equal(3072, file.FileSize);
        Assert.Equal("3 KB", file.FileSizeStr);
    }

    [Fact]
    public void Rename_Directory_CascadesToDescendantsByDefault()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var oldDir = NewDirectory(archive, "old");
        var nested = NewDirectory(oldDir, "nested");
        var file = NewFile(nested, "foo.mesh", 128);

        Directory.Move(oldDir.FullName, AbsolutePath("archive", "new"));
        oldDir.Rename("new");

        Assert.Equal(Path.Combine("archive", "new"), oldDir.RawRelativePath);
        Assert.Equal(Path.Combine("archive", "new", "nested"), nested.RawRelativePath);
        Assert.Equal(Path.Combine("archive", "new", "nested", "foo.mesh"), file.RawRelativePath);

        Assert.Equal(AbsolutePath("archive", "new", "nested", "foo.mesh"), file.FullName);
        Assert.Equal(@"new\nested\foo.mesh", file.GameRelativePath);
        Assert.Equal(ResourcePath.CalculateHash(@"new\nested\foo.mesh"), file.Hash);
    }

    [Fact]
    public void Rename_Directory_LeavesDescendantNamesAlone()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var oldDir = NewDirectory(archive, "old");
        var file = NewFile(oldDir, "foo.mesh");

        Directory.Move(oldDir.FullName, AbsolutePath("archive", "new"));
        oldDir.Rename("new");

        // the cascade re-derives paths only; a child keeps the name it had
        Assert.Equal("foo.mesh", file.Name);
    }

    [Fact]
    public void Rename_DirectoryWithUpdateChildrenFalse_LeavesDescendantPathsStale()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var oldDir = NewDirectory(archive, "old");
        var file = NewFile(oldDir, "foo.mesh");

        Directory.Move(oldDir.FullName, AbsolutePath("archive", "new"));
        oldDir.Rename("new", updateChildren: false);

        Assert.Equal(Path.Combine("archive", "new"), oldDir.RawRelativePath);
        Assert.Equal(Path.Combine("archive", "old", "foo.mesh"), file.RawRelativePath);
    }

    [Fact]
    public void Rename_WithoutANewName_RebuildsThePathFromTheCurrentParent()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var oldDir = NewDirectory(archive, "old");
        var file = NewFile(oldDir, "foo.mesh");

        // simulate the parent having moved without the cascade: fix the child up on its own
        Directory.Move(oldDir.FullName, AbsolutePath("archive", "new"));
        oldDir.Rename("new", updateChildren: false);
        file.Rename();

        Assert.Equal("foo.mesh", file.Name);
        Assert.Equal(Path.Combine("archive", "new", "foo.mesh"), file.RawRelativePath);
        Assert.Equal(AbsolutePath("archive", "new", "foo.mesh"), file.FullName);
    }

    [Fact]
    public void Rename_Directory_RecomputesTheExtensionMarkerOfItsSubtree()
    {
        var root = NewRoot();
        var raw = NewDirectory(root, "raw");
        var nested = NewDirectory(raw, "nested");
        var file = NewFile(nested, "foo.mesh");

        Directory.Move(nested.FullName, AbsolutePath("raw", "renamed"));
        nested.Rename("renamed");

        Assert.Equal(AppConstants.RawDirectoryTop, nested.Extension);
        Assert.Equal("mesh", file.Extension);
    }

    [Fact]
    public void Rename_TopLevelDirectory_TurnsItsRelativePathAbsoluteAndLosesItsMarker()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var file = NewFile(archive, "foo.mesh");

        Directory.Move(archive.FullName, AbsolutePath("archive2"));
        archive.Rename("archive2");

        // Rename rebuilds the path as Path.Combine(Parent.RawRelativePath, Name), and the root's
        // RawRelativePath is the absolute project directory - so "RawRelativePath" stops being relative.
        // FullName still resolves (Path.Combine keeps the rooted second argument) but the
        // "archive"/"raw"/"resources" marker lookup no longer matches. Documents current behaviour.
        Assert.Equal(AbsolutePath("archive2"), archive.RawRelativePath);
        Assert.Equal(AbsolutePath("archive2"), archive.FullName);
        Assert.Equal(nameof(ECustomImageKeys.OpenDirImageKey), archive.Extension);

        Assert.Equal(AbsolutePath("archive2", "foo.mesh"), file.FullName);
    }

    #endregion

    #region GetFileSizeStr

    [Theory]
    [InlineData(0, "0 B")]
    [InlineData(1, "1 B")]
    [InlineData(512, "512 B")]
    [InlineData(1023, "1023 B")]
    [InlineData(1024, "1 KB")]
    [InlineData(1536, "1.5 KB")]
    [InlineData(1024L * 1024, "1 MB")]
    [InlineData(1024L * 1024 * 1024, "1 GB")]
    [InlineData(1024L * 1024 * 1024 * 1024, "1 TB")]
    [InlineData(5L * 1024 * 1024 * 1024 * 1024, "5 TB")]
    public void GetFileSizeStr_ScalesToTheLargestUnitThatFits(long fileSize, string expected) =>
        Assert.Equal(expected, FileSystemModel.GetFileSizeStr(fileSize));

    [Theory]
    [InlineData(1126, "1.1 KB")]
    [InlineData(1178, "1.15 KB")]
    [InlineData(1180, "1.15 KB")]
    public void GetFileSizeStr_RoundsToTwoDecimalPlaces(long fileSize, string expected) =>
        Assert.Equal(expected, FileSystemModel.GetFileSizeStr(fileSize));

    [Fact]
    public void GetFileSizeStr_JustUnderAUnitBoundary_RoundsUpIntoTheSmallerUnitsLabel()
    {
        // 1048575 B is 1023.999 KB, which "0.##" renders as a flat 1024 KB rather than 1 MB
        Assert.Equal("1024 KB", FileSystemModel.GetFileSizeStr(1024L * 1024 - 1));
    }

    [Fact]
    public void GetFileSizeStr_NegativeSize_StaysInBytes()
    {
        // the loop never runs for values below 1024, so a bogus size is passed straight through
        Assert.Equal("-1 B", FileSystemModel.GetFileSizeStr(-1));
    }

    [Fact]
    public void GetFileSizeStr_UsesTheInvariantDecimalSeparator()
    {
        var previous = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = new CultureInfo("de-DE");
        try
        {
            // de-DE would render "1,5" - the display string must not depend on the user's locale
            Assert.Equal("1.5 KB", FileSystemModel.GetFileSizeStr(1536));
        }
        finally
        {
            CultureInfo.CurrentCulture = previous;
        }
    }

    [Fact]
    public void GetFileSizeStr_AtOnePebibyte_OverflowsTheUnitTable()
    {
        // BUG (documented, not endorsed): the loop's `order++ < sizes.Length - 1` guard increments
        // `order` one last time on the failing check, so it indexes past "TB".
        // When this is fixed, the expectation becomes "1 PB" (or a clamped "1024 TB").
        Assert.Throws<IndexOutOfRangeException>(() =>
            FileSystemModel.GetFileSizeStr(1024L * 1024 * 1024 * 1024 * 1024));
    }

    #endregion
}

using WolvenKit.App.Helpers;
using WolvenKit.RED4.Types;
using Xunit;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// The Asset Browser hash of an open file ("Open in Asset Browser" on a document tab).
/// </summary>
public class AssetBrowserLookupTests
{
    private const string ModDirectory = @"C:\projects\mymod\source\archive";

    [Fact]
    public void ProjectFile_UsesThePathInsideTheArchiveFolder()
    {
        Assert.True(AssetBrowserLookup.TryGetHash(
            @"C:\projects\mymod\source\archive\base\characters\jacket.mesh", ModDirectory, out var hash));

        Assert.Equal(ResourcePath.CalculateHash(@"base\characters\jacket.mesh"), hash);
    }

    [Fact]
    public void FileNamedAfterItsHash_UsesThatHash()
    {
        Assert.True(AssetBrowserLookup.TryGetHash(@"C:\projects\mymod\source\archive\1234567890.mesh", ModDirectory, out var hash));

        Assert.Equal(1234567890UL, hash);
    }

    [Fact]
    public void GameFile_UsesItsGamePath()
    {
        Assert.True(AssetBrowserLookup.TryGetHash(@"base\characters\jacket.mesh", null, out var hash));

        Assert.Equal(ResourcePath.CalculateHash(@"base\characters\jacket.mesh"), hash);
    }

    [Theory]
    [InlineData(@"C:\projects\mymod\source\raw\jacket.fbx")]
    [InlineData(@"D:\elsewhere\jacket.mesh")]
    [InlineData("")]
    [InlineData(null)]
    public void FileOutsideTheArchiveFolder_HasNoHash(string? path)
    {
        Assert.False(AssetBrowserLookup.TryGetHash(path, ModDirectory, out _));
    }

    [Fact]
    public void ProjectFileWithoutProject_HasNoHash()
    {
        Assert.False(AssetBrowserLookup.TryGetHash(@"C:\projects\mymod\source\archive\a.mesh", null, out _));
    }
}

using Moq;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace Wolvenkit.Test.App.Models.ProjectManagement.Project;

public class Cp77ProjectTest
{
    private static readonly string s_projectPath = Path.Join(Path.GetTempPath(), "TestProject");
    private const string s_projectName = "TestProject";
    private readonly Cp77Project testProject;

    public Cp77ProjectTest()
    {
        testProject = new Cp77Project(s_projectPath, s_projectName, s_projectName);
    }


    [Theory]
    [InlineData(@"source\archive\base\file.xbm", null)]
    [InlineData(@"source\customSounds\file.mp3", @"source\customsounds\file.mp3")]
    [InlineData(@"source\raw\base\file.xbm", null)]
    [InlineData(@"source\resources\file.yaml", null)]
    [InlineData(@"this\dir\does\not\exist\file.yaml", @"this\dir\does\not\exist\file.yaml")]
    public void GetResourcePathFromRootTest(string relativePath, string? expectedDepotPath)
    {
        var absolutePath = Path.Join(testProject.FileDirectory, relativePath);
        var depotPath = testProject.GetResourcePathFromRoot(absolutePath);
        Assert.Equal(expectedDepotPath ?? relativePath, depotPath.GetResolvedText());
    }

    [Theory]
    [InlineData(@"archive\base\file.xbm", @"base\file.xbm", @"archive")]
    [InlineData(@"customSounds\file.mp3", @"customSounds\file.mp3", @"")]
    [InlineData(@"raw\base\file.xbm", @"base\file.xbm", @"raw")]
    [InlineData(@"resources\file.yaml", @"resources\file.yaml", "")]
    [InlineData(@"invalid\file.yaml", @"invalid\file.yaml", "")]
    public void SplitPathTest(string relativePath, string expectedRelativePath, string expectedPrefix)
    {
        var absolutePath = Path.Join(testProject.FileDirectory, relativePath);
        var absolutePrefix = Path.Join(testProject.FileDirectory, expectedPrefix);

        var (prefix, rel) = testProject.SplitFilePath(absolutePath);
        Assert.Equal(expectedRelativePath, rel);

        Assert.Equal(expectedRelativePath, testProject.GetRelativePath(absolutePath));
        Assert.Equal(absolutePrefix, testProject.GetPrefixPath(absolutePath));
    }
}
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Models;
using WolvenKit.App.Services;

namespace Wolvenkit.Test.App.Services;

[TestClass]
public class InstanceSettingsTests
{
    [TestMethod]
    [DataRow(null, new string[] { }, null)]
    [DataRow(null, new string[] { "--AppDataPath", @"some\Valid/Path" }, @"some\Valid\Path")]
    [DataRow(null, new string[] { "--AppDataPath", @"some\Invalid\...\/Path" }, null)]
    [DataRow("", new string[] { }, null)]
    [DataRow("{\"AppDataPath\":\"some\\\\Valid\\\\Path\"}", new string[] { }, @"some\Valid\Path")]
    [DataRow("{\"AppDataPath\":\"some\\\\Invalid\\\\......\\\\Path\"}", new string[] { }, null)]
    [DataRow("{\"AppDataPath\":\"some\\\\Valid\\\\Path\\\\FromFile\"}", new string[] { "--AppDataPath", @"some\Valid\PathFromArgs" }, @"some\Valid\PathFromArgs")]
    [DataRow("{\"AppDataPath\":\"some\\\\Invalid\\\\......\\\\Path\"}", new string[] { "--AppDataPath", @"some\Invalid\...\/Path" }, null)]
    [DataRow("{\"AppDataPath\":\"some\\\\Invalid\\Json......\\\\Path\"}", new string[] { }, null)]
    public void TestAppDataPathLoading(string? instanceConfigContent, string[] args, string? expectedAppDataPathOverride)
    {
        var expectedAppDataPath = expectedAppDataPathOverride ??
                                  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit");

        var configFile = $"{Guid.NewGuid()}.json";
        if (instanceConfigContent != null)
        {
            File.WriteAllText(configFile, instanceConfigContent);
        }

        var instanceSettings = new InstanceSettings();
        instanceSettings.Load(configFile, args);

        File.Delete(configFile);

        Assert.AreEqual(expectedAppDataPath, instanceSettings.AppDataPath);
    }
}

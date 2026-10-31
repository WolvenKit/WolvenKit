using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Core;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class Red4PathHelperTests
    {
        [DataTestMethod]
        [DataRow("Cyberpunk2077.exe", true)]
        [DataRow("cyberpunk2077.exe", true)]
        [DataRow("CYBERPUNK2077.EXE", true)]
        [DataRow("cpLauncher.exe", true)]
        [DataRow("cplauncher.exe", true)]
        [DataRow("gamelaunchhelper.exe", true)]
        [DataRow("C:\\Games\\Cyberpunk 2077\\bin\\x64\\Cyberpunk2077.exe", true)]
        [DataRow("C:\\XboxGames\\Cyberpunk 2077\\Content\\cpLauncher.exe", true)]
        [DataRow("C:\\XboxGames\\Cyberpunk 2077\\Content\\gamelaunchhelper.exe", true)]
        [DataRow("REDlauncher.exe", false)]
        [DataRow("witcher3.exe", false)]
        [DataRow("game.exe", false)]
        [DataRow("", false)]
        [DataRow(null, false)]
        public void IsRed4Executable_ValidatesCorrectly(string? input, bool expected)
        {
            Assert.AreEqual(expected, Red4PathHelper.IsRed4Executable(input), $"Input: {input}");
        }

        [TestMethod]
        public void ResolveGameRootDir_SteamLayout_ResolvesToRoot()
        {
            var tempDir = Path.Combine(Path.GetTempPath(), "WolvenKit_SteamTest_" + Guid.NewGuid().ToString("N"));
            try
            {
                var binDir = Path.Combine(tempDir, "bin", "x64");
                var contentDir = Path.Combine(tempDir, "archive", "pc", "content");
                Directory.CreateDirectory(binDir);
                Directory.CreateDirectory(contentDir);

                var exePath = Path.Combine(binDir, Constants.Red4Exe);
                File.WriteAllText(exePath, "");

                var resolved = Red4PathHelper.ResolveGameRootDir(exePath);

                Assert.IsNotNull(resolved);
                Assert.AreEqual(Path.GetFullPath(tempDir), Path.GetFullPath(resolved));
            }
            finally
            {
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }
            }
        }

        [TestMethod]
        public void ResolveGameRootDir_XboxContentLayout_ResolvesToContent()
        {
            var tempDir = Path.Combine(Path.GetTempPath(), "WolvenKit_XboxTest_" + Guid.NewGuid().ToString("N"));
            try
            {
                var contentDir = Path.Combine(tempDir, "Content");
                var archiveDir = Path.Combine(contentDir, "archive", "pc", "content");
                Directory.CreateDirectory(archiveDir);

                var exePath = Path.Combine(contentDir, Constants.Red4XboxExe);
                File.WriteAllText(exePath, "");

                var resolved = Red4PathHelper.ResolveGameRootDir(exePath);

                Assert.IsNotNull(resolved);
                Assert.AreEqual(Path.GetFullPath(contentDir), Path.GetFullPath(resolved));
            }
            finally
            {
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }
            }
        }

        [TestMethod]
        public void ResolveGameRootDir_XboxBaseDirectory_ResolvesToContent()
        {
            var tempDir = Path.Combine(Path.GetTempPath(), "WolvenKit_XboxBaseTest_" + Guid.NewGuid().ToString("N"));
            try
            {
                var contentDir = Path.Combine(tempDir, "Content");
                var archiveDir = Path.Combine(contentDir, "archive", "pc", "content");
                Directory.CreateDirectory(archiveDir);

                var resolved = Red4PathHelper.ResolveGameRootDir(tempDir);

                Assert.IsNotNull(resolved);
                Assert.AreEqual(Path.GetFullPath(contentDir), Path.GetFullPath(resolved));
            }
            finally
            {
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }
            }
        }

        [TestMethod]
        public void ResolveGameRootDir_OfflineOrMissingPath_ResolvesFallbackWithoutThrowing()
        {
            var nonExistentSteamExe = @"Z:\NonExistentDrive\Cyberpunk 2077\bin\x64\Cyberpunk2077.exe";
            var resolvedSteam = Red4PathHelper.ResolveGameRootDir(nonExistentSteamExe);

            Assert.IsNotNull(resolvedSteam);
            Assert.AreEqual(@"Z:\NonExistentDrive\Cyberpunk 2077", resolvedSteam);

            var nonExistentXboxExe = @"Z:\NonExistentDrive\Cyberpunk 2077\Content\cpLauncher.exe";
            var resolvedXbox = Red4PathHelper.ResolveGameRootDir(nonExistentXboxExe);

            Assert.IsNotNull(resolvedXbox);
            Assert.AreEqual(@"Z:\NonExistentDrive\Cyberpunk 2077\Content", resolvedXbox);
        }

        [TestMethod]
        public void ResolveOodleDll_XboxDirectLayout_ResolvesCorrectly()
        {
            var tempDir = Path.Combine(Path.GetTempPath(), "WolvenKit_OodleXboxTest_" + Guid.NewGuid().ToString("N"));
            try
            {
                Directory.CreateDirectory(tempDir);
                var oodlePath = Path.Combine(tempDir, Constants.Oodle);
                File.WriteAllText(oodlePath, "");

                var resolved = Red4PathHelper.ResolveOodleDll(tempDir);

                Assert.IsNotNull(resolved);
                Assert.AreEqual(Path.GetFullPath(oodlePath), Path.GetFullPath(resolved));
            }
            finally
            {
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }
            }
        }

        [TestMethod]
        public void ResolveOodleDll_StandardBinX64Layout_ResolvesCorrectly()
        {
            var tempDir = Path.Combine(Path.GetTempPath(), "WolvenKit_OodleSteamTest_" + Guid.NewGuid().ToString("N"));
            try
            {
                var binDir = Path.Combine(tempDir, "bin", "x64");
                Directory.CreateDirectory(binDir);
                var oodlePath = Path.Combine(binDir, Constants.Oodle);
                File.WriteAllText(oodlePath, "");

                var resolved = Red4PathHelper.ResolveOodleDll(tempDir);

                Assert.IsNotNull(resolved);
                Assert.AreEqual(Path.GetFullPath(oodlePath), Path.GetFullPath(resolved));
            }
            finally
            {
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }
            }
        }

        [TestMethod]
        public void ResolveExecutable_XboxLayout_FindsCpLauncher()
        {
            var tempDir = Path.Combine(Path.GetTempPath(), "WolvenKit_ExeTest_" + Guid.NewGuid().ToString("N"));
            try
            {
                Directory.CreateDirectory(tempDir);
                var cpLauncher = Path.Combine(tempDir, Constants.Red4XboxExe);
                File.WriteAllText(cpLauncher, "");

                var resolved = Red4PathHelper.ResolveExecutable(tempDir);

                Assert.IsNotNull(resolved);
                Assert.AreEqual(Path.GetFullPath(cpLauncher), Path.GetFullPath(resolved.FullName));
            }
            finally
            {
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }
            }
        }

        [TestMethod]
        public void GetDefaultXboxGameLocations_WhenFound_PathsExistAndEndWithContent()
        {
            var locations = Red4PathHelper.GetDefaultXboxGameLocations().ToList();
            foreach (var loc in locations)
            {
                Assert.IsTrue(Directory.Exists(loc), $"Location does not exist: {loc}");
                Assert.IsTrue(loc.EndsWith("Content", StringComparison.OrdinalIgnoreCase), $"Location should end with Content: {loc}");
            }
        }
    }
}

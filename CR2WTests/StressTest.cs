using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit;
using System.Linq;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.Bundles;
using WolvenKit.Common;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text;
using System.Security.Cryptography;
using WolvenKit.Common.Extensions;
using Microsoft.Win32;

namespace CR2WTests
{
    public static class AssertEx
    {
        public static async Task<TException>
          ThrowsAsync<TException>(Func<Task> action,
          bool allowDerivedTypes = true) where TException : Exception
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                if (allowDerivedTypes && !(ex is TException))
                    throw new Exception("Delegate threw exception of type " +
                      ex.GetType().Name + ", but " + typeof(TException).Name +
                      " or a derived type was expected.", ex);
                if (!allowDerivedTypes && ex.GetType() != typeof(TException))
                    throw new Exception("Delegate threw exception of type " +
                      ex.GetType().Name + ", but " + typeof(TException).Name +
                      " was expected.", ex);
                return (TException)ex;
            }
            throw new Exception("Delegate did not throw expected exception " +
              typeof(TException).Name + ".");
        }
        public static Task<Exception> ThrowsAsync(Func<Task> action)
        {
            return ThrowsAsync<Exception>(action, true);
        }
    }

    [TestClass]
    public class StressTest
    {
        static string bundletag = "*";
        static Dictionary<string, MemoryMappedFile> memorymappedbundles;
        static BundleManager bm;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            var tw3Finaldir = "";
            // check for W3_DIR environment variable
            var W3_DIR = System.Environment.GetEnvironmentVariable("W3_DIR", EnvironmentVariableTarget.User);
            if (!string.IsNullOrEmpty(W3_DIR))
                tw3Finaldir = W3_DIR;
            // else lookup w3 exe
            else
            {
                var exedir = new FileInfo(LookUpW3exe()).Directory.FullName;
                if (Directory.Exists(exedir))
                    tw3Finaldir = exedir;
                // else close
                else
                    Assert.IsFalse(true, "Aborting test. No valid Wicther 3 directory found.");
            }

            
            memorymappedbundles = new Dictionary<string, MemoryMappedFile>();
            bm = new BundleManager();
            bm.LoadAll(tw3Finaldir);

            //Load MemoryMapped Bundles
            foreach (var b in bm.Bundles.Values)
            {
                var e = b.ArchiveAbsolutePath.GetHashMD5();
            
                memorymappedbundles.Add(e, MemoryMappedFile.CreateFromFile(b.ArchiveAbsolutePath, FileMode.Open, e, 0, MemoryMappedFileAccess.Read));

            }
        }

        private static string LookUpW3exe()
        {
            const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            const string uninstallkey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            var w3 = "";
            try
            {
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") ||
                            programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        {
                            w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe",
                                SearchOption.AllDirectories).First();
                        }
                    }
                });
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey2)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") ||
                            programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                                w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe",
                                SearchOption.AllDirectories).First();
                        }
                    }
                });
                return w3;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Methods to test for the different file types
        #region Methods
        [TestMethod]
        public async Task Cellmap()
        {
            await Task.Run(() => StressTestExt("cellmap"));
        }

        [TestMethod]
        public async Task Env()
        {
            await Task.Run(() => StressTestExt("env"));
        }

        [TestMethod]
        public async Task Flyr()
        {
            await Task.Run(() => StressTestExt("flyr"));
        }

        [TestMethod]
        public async Task Formation()
        {
            await Task.Run(() => StressTestExt("formation"));
        }

        [TestMethod]
        public async Task Grassmask()
        {
            await Task.Run(() => StressTestExt("grassmask"));
        }

        [TestMethod]
        public async Task Guiconfig()
        {
            await Task.Run(() => StressTestExt("guiconfig"));
        }

        [TestMethod]
        public async Task hud()
        {
            await Task.Run(() => StressTestExt("hud"));
        }

        [TestMethod]
        public async Task journal()
        {
            await Task.Run(() => StressTestExt("journal"));
        }

        [TestMethod]
        public async Task menu()
        {
            await Task.Run(() => StressTestExt("menu"));
        }



        [TestMethod]
        public async Task popup()
        {
            await Task.Run(() => StressTestExt("popup"));
        }

        [TestMethod]
        public async Task redapex()
        {
            await Task.Run(() => StressTestExt("redapex"));
        }

        [TestMethod]
        public async Task redcloth()
        {
            await Task.Run(() => StressTestExt("redcloth"));
        }

        [TestMethod]
        public async Task reddest()
        {
            await Task.Run(() => StressTestExt("reddest"));
        }

        [TestMethod]
        public async Task reddlc()
        {
            await Task.Run(() => StressTestExt("reddlc"));
        }

        [TestMethod]
        public async Task redexp()
        {
            await Task.Run(() => StressTestExt("redexp"));
        }

        [TestMethod]
        public async Task redfur()
        {
            await Task.Run(() => StressTestExt("redfur"));
        }

        [TestMethod]
        public async Task redgame()
        {
            await Task.Run(() => StressTestExt("redgame"));
        }

        [TestMethod]
        public async Task redicsv()
        {
            await Task.Run(() => StressTestExt("redicsv"));
        }

        [TestMethod]
        public async Task redswf()
        {
            await Task.Run(() => StressTestExt("redswf"));
        }

        [TestMethod]
        public async Task redwpset()
        {
            await Task.Run(() => StressTestExt("redwpset"));
        }

        [TestMethod]
        public async Task spawntree()
        {
            await Task.Run(() => StressTestExt("spawntree"));
        }

        [TestMethod]
        public async Task texarray()
        {
            await Task.Run(() => StressTestExt("texarray"));
        }

        [TestMethod]
        public async Task vbrush()
        {
            await Task.Run(() => StressTestExt("vbrush"));
        }

        [TestMethod]
        public async Task w2am()
        {
            await Task.Run(() => StressTestExt("w2am"));
        }

        [TestMethod]
        public async Task w2animev()
        {
            await Task.Run(() => StressTestExt("w2animev"));
        }

        [TestMethod]
        public async Task w2anims()
        {
            await Task.Run(() => StressTestExt("w2anims"));
        }

        [TestMethod]
        public async Task w2beh()
        {
            await Task.Run(() => StressTestExt("w2beh"));
        }

        [TestMethod]
        public async Task w2behtree()
        {
            await Task.Run(() => StressTestExt("w2behtree"));
        }

        [TestMethod]
        public async Task w2cent()
        {
            await Task.Run(() => StressTestExt("w2cent"));
        }

        [TestMethod]
        public async Task w2comm()
        {
            await Task.Run(() => StressTestExt("w2comm"));
        }

        [TestMethod]
        public async Task w2cube()
        {
            await Task.Run(() => StressTestExt("w2cube"));
        }

        [TestMethod]
        public async Task w2cutscene()
        {
            await Task.Run(() => StressTestExt("w2cutscene"));
        }

        [TestMethod]
        public async Task w2dset()
        {
            await Task.Run(() => StressTestExt("w2dset"));
        }

        [TestMethod]
        public async Task w2em()
        {
            await Task.Run(() => StressTestExt("w2em"));
        }

        [TestMethod]
        public async Task w2ent()
        {
            await Task.Run(() => StressTestExt("w2ent"));
        }
        //[TestMethod]
        //public async Task w2entPatch()
        //{
        //    bundletag = "patch1*";
        //    await Task.Run(() => StressTestExt("w2ent"));
        //}
        //[TestMethod]
        //public async Task w2entContent0()
        //{
        //    bundletag = "content0*";
        //    await Task.Run(() => StressTestExt("w2ent"));
        //}
        //[TestMethod]
        //public async Task w2entContents()
        //{
        //    bundletag = "sanscontent0";
        //    await Task.Run(() => StressTestExt("w2ent"));
        //}

        [TestMethod]
        public async Task w2fnt()
        {
            //var ret = await Task.Run(() => await Task.Run(() => StressTestExt("w2fnt"));
            //Assert.AreEqual(0, ret.Item1, $"Unknown bytes remained -> {ret.Item1}bytes"));
            //Assert.AreEqual(0, ret.Item2, $"Unparsed files -> {ret.Item2}"));


            //var ex = Assert.ThrowsException<AssertFailedException>(() => { await Task.Run(() => StressTestExt("w2fnt")); });
            //var ex = await AssertEx.ThrowsAsync<AssertFailedException>(()  => await Task.Run(() => StressTestExt("w2fnt"));
            await Task.Run(() => StressTestExt("w2fnt"));
        }

        [TestMethod]
        public async Task w2je()
        {
            await Task.Run(() => StressTestExt("w2je"));
        }

        [TestMethod]
        public async Task w2job()
        {
            await Task.Run(() => StressTestExt("w2job"));
        }

        [TestMethod]
        public async Task w2l()
        {
            await Task.Run(() => StressTestExt("w2l"));
        }

        [TestMethod]
        public async Task w2mesh()
        {
            await Task.Run(() => StressTestExt("w2mesh"));
        }

        [TestMethod]
        public async Task w2mg()
        {
            await Task.Run(() => StressTestExt("w2mg"));
        }

        [TestMethod]
        public async Task w2mi()
        {
            await Task.Run(() => StressTestExt("w2mi"));
        }

        [TestMethod]
        public async Task w2p()
        {
            await Task.Run(() => StressTestExt("w2p"));
        }

        [TestMethod]
        public async Task w2phase()
        {
            await Task.Run(() => StressTestExt("w2phase"));
        }

        [TestMethod]
        public async Task w2qm()
        {
            await Task.Run(() => StressTestExt("w2qm"));
        }

        [TestMethod]
        public async Task w2quest()
        {
            await Task.Run(() => StressTestExt("w2quest"));
        }

        [TestMethod]
        public async Task w2ragdoll()
        {
            await Task.Run(() => StressTestExt("w2ragdoll"));
        }

        [TestMethod]
        public async Task w2rig()
        {
            await Task.Run(() => StressTestExt("w2rig"));
        }

        [TestMethod]
        public async Task w2scene()
        {
            await Task.Run(() => StressTestExt("w2scene"));
        }

        [TestMethod]
        public async Task w2sf()
        {
            await Task.Run(() => StressTestExt("w2sf"));
        }

        [TestMethod]
        public async Task w2steer()
        {
            await Task.Run(() => StressTestExt("w2steer"));
        }

        [TestMethod]
        public async Task w2ter()
        {
            await Task.Run(() => StressTestExt("w2ter"));
        }

        [TestMethod]
        public async Task w2w()
        {
            await Task.Run(() => StressTestExt("w2w"));
        }

        [TestMethod]
        public async Task w3app()
        {
            await Task.Run(() => StressTestExt("w3app"));
        }

        [TestMethod]
        public async Task w3dyng()
        {
            await Task.Run(() => StressTestExt("w3dyng"));
        }

        [TestMethod]
        public async Task w3fac()
        {
            await Task.Run(() => StressTestExt("w3fac"));
        }

        [TestMethod]
        public async Task w3occlusion()
        {
            await Task.Run(() => StressTestExt("w3occlusion"));
        }

        [TestMethod]
        public async Task w3simplex()
        {
            await Task.Run(() => StressTestExt("w3simplex"));
        }

        [TestMethod]
        public async Task xbm()
        {
            await Task.Run(() => StressTestExt("xbm"));
        }



        //Not Cr2w files
        /*
        [TestMethod]
        public async Task buffer()
        {
            await Task.Run(() => StressTestExt("buffer");
        }
        [TestMethod]
        public async Task navconfig()
        {
            await Task.Run(() => StressTestExt("navconfig");
        }

        [TestMethod]
        public async Task navgraph()
        {
            await Task.Run(() => StressTestExt("navgraph");
        }

        [TestMethod]
        public async Task naviobstacles()
        {
            await Task.Run(() => StressTestExt("naviobstacles");
        }

        [TestMethod]
        public async Task navmesh()
        {
            await Task.Run(() => StressTestExt("navmesh");
        }

        [TestMethod]
        public async Task navtile()
        {
            await Task.Run(() => StressTestExt("navtile");
        }
        */
        #endregion

        // Actually do the test
        public void StressTestExt(string ext)
        {

            using (var frm = new frmUnitTest(ext, bundletag, bm))
            {
                //https://stackoverflow.com/questions/17797670/form-showdialog-does-not-display-window-with-debugging-enabled
                frm.Load += (sender, e) => (sender as frmUnitTest).Visible = true;
                frm.ShowDialog();

                var result = frm.GetResult();
                
                Assert.AreEqual(0, result.Item1, $"Unknown bytes remained -> {result.Item1}bytes");
                Assert.AreEqual(0, result.Item2, $"Unparsed files -> {result.Item2}");
            }
        }
        

    }
}
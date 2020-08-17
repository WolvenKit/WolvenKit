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
        static BundleManager mc;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            memorymappedbundles = new Dictionary<string, MemoryMappedFile>();
            mc = new BundleManager();
            //mc.LoadAll("D:\\SteamLibrary\\steamapps\\common\\The Witcher 3\\bin\\x64");
            mc.LoadAll("C:\\w3mod\\The Witcher 3\\bin\\x64");

            //Load MemoryMapped Bundles
            foreach (var b in mc.Bundles.Values)
            {
                var e = b.FileName.GetHashMD5();

                memorymappedbundles.Add(e, MemoryMappedFile.CreateFromFile(b.FileName, FileMode.Open, e, 0, MemoryMappedFileAccess.Read));

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
        public async Task StressTestExt(string ext)
        {

            using (var frm = new frmUnitTest(ext, bundletag, mc))
            {
                //https://stackoverflow.com/questions/17797670/form-showdialog-does-not-display-window-with-debugging-enabled
                frm.Load += (sender, e) => (sender as frmUnitTest).Visible = true;
                frm.ShowDialog();

                var result = frm.GetResult();

                Assert.AreEqual(0, result.Item1, $"Unknown bytes remained -> {result.Item1}bytes");
                Assert.AreEqual(0, result.Item2, $"Unparsed files -> {result.Item2}");

                //await Task.Run(() => frm.StressTestExtAsync(ext, bundletag)).ContinueWith(
                //antecedent =>
                //{
                //    Assert.AreEqual(0, antecedent.Result.Item1, $"Unknown bytes remained -> {antecedent.Result.Item1}bytes");
                //    Assert.AreEqual(0, antecedent.Result.Item2, $"Unparsed files -> {antecedent.Result.Item2}");
                //}
                //);
            }
        }
        

/*        private async static Task<Tuple<long, long, Dictionary<string, Tuple<long, long>>>> StressTestFileAsync(BundleItem f, List<string> unknownclasses)
        {
            Dictionary<string, Tuple<long, long>> chunkstate = new Dictionary<string, Tuple<long, long>>();
            long totalbytes = 0;
            long unknownbytes = 0;

            var crw = new CR2WFile();

            using (var ms = new MemoryStream())
            using (var br = new BinaryReader(ms))
            {
                f.ExtractExistingMMF(ms);
                ms.Seek(0, SeekOrigin.Begin);

                crw.Read(br); // make this async?
            }

            unknownclasses.AddRange(crw.UnknownTypes);
            foreach (var c in crw.chunks)
            {
                var ubsl = c.unknownBytes?.Bytes != null ? c.unknownBytes.Bytes.Length : 0;

                if (!chunkstate.ContainsKey(c.REDType))
                {
                    chunkstate.Add(c.REDType, new Tuple<long, long>(0, 0));
                }
                var already = chunkstate[c.REDType];
                chunkstate[c.REDType] = new Tuple<long, long>(
                        already.Item1 + c.Export.dataSize,
                        already.Item2 + ubsl
                    );

                totalbytes += c.Export.dataSize;
                unknownbytes += ubsl;

            }

            return new Tuple<long, long, Dictionary<string, Tuple<long, long>>>(totalbytes, unknownbytes, chunkstate);

        }*/
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit;
using System.Linq;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.Bundles;
using System.Threading.Tasks;

namespace CR2WTests
{
    [TestClass]
    public class StressTest
    {
        static BundleManager mc;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            mc = new BundleManager();
            mc.LoadAll("D:\\SteamLibrary\\steamapps\\common\\TW3\\bin\\x64");
            //mc.LoadAll("C:\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");
        }

        // Methods to test for the different file types

        #region Tests
        [TestMethod]
        public void cellmap()
        {
            StressTestExt("cellmap");
        }

        [TestMethod]
        public void env()
        {
            StressTestExt("env");
        }

        [TestMethod]
        public void flyr()
        {
            StressTestExt("flyr");
        }

        [TestMethod]
        public void formation()
        {
            StressTestExt("formation");
        }

        [TestMethod]
        public void grassmask()
        {
            StressTestExt("grassmask");
        }

        [TestMethod]
        public void guiconfig()
        {
            StressTestExt("guiconfig");
        }

        [TestMethod]
        public void hud()
        {
            StressTestExt("hud");
        }

        [TestMethod]
        public void journal()
        {
            StressTestExt("journal");
        }

        [TestMethod]
        public void menu()
        {
            StressTestExt("menu");
        }

        

        [TestMethod]
        public void popup()
        {
            StressTestExt("popup");
        }

        [TestMethod]
        public void redapex()
        {
            StressTestExt("redapex");
        }

        [TestMethod]
        public void redcloth()
        {
            StressTestExt("redcloth");
        }

        [TestMethod]
        public void reddest()
        {
            StressTestExt("reddest");
        }

        [TestMethod]
        public void reddlc()
        {
            StressTestExt("reddlc");
        }

        [TestMethod]
        public void redexp()
        {
            StressTestExt("redexp");
        }

        [TestMethod]
        public void redfur()
        {
            StressTestExt("redfur");
        }

        [TestMethod]
        public void redgame()
        {
            StressTestExt("redgame");
        }

        [TestMethod]
        public void redicsv()
        {
            StressTestExt("redicsv");
        }

        [TestMethod]
        public void redswf()
        {
            StressTestExt("redswf");
        }

        [TestMethod]
        public void redwpset()
        {
            StressTestExt("redwpset");
        }

        [TestMethod]
        public void spawntree()
        {
            StressTestExt("spawntree");
        }

        [TestMethod]
        public void texarray()
        {
            StressTestExt("texarray");
        }

        [TestMethod]
        public void vbrush()
        {
            StressTestExt("vbrush");
        }

        [TestMethod]
        public void w2am()
        {
            StressTestExt("w2am");
        }

        [TestMethod]
        public void w2animev()
        {
            StressTestExt("w2animev");
        }

        [TestMethod]
        public void w2anims()
        {
            StressTestExt("w2anims");
        }

        [TestMethod]
        public void w2beh()
        {
            StressTestExt("w2beh");
        }

        [TestMethod]
        public void w2behtree()
        {
            StressTestExt("w2behtree");
        }

        [TestMethod]
        public void w2cent()
        {
            StressTestExt("w2cent");
        }

        [TestMethod]
        public void w2comm()
        {
            StressTestExt("w2comm");
        }

        [TestMethod]
        public void w2cube()
        {
            StressTestExt("w2cube");
        }

        [TestMethod]
        public void w2cutscene()
        {
            StressTestExt("w2cutscene");
        }

        [TestMethod]
        public void w2dset()
        {
            StressTestExt("w2dset");
        }

        [TestMethod]
        public void w2em()
        {
            StressTestExt("w2em");
        }
        
        [TestMethod]
        public void w2ent()
        {
            StressTestExt("w2ent");
        }
        
        [TestMethod]
        public void w2fnt()
        {
            StressTestExt("w2fnt");
        }

        [TestMethod]
        public void w2je()
        {
            StressTestExt("w2je");
        }

        [TestMethod]
        public void w2job()
        {
            StressTestExt("w2job");
        }

        [TestMethod]
        public void w2l()
        {
            StressTestExt("w2l");
        }

        [TestMethod]
        public void w2mesh()
        {
            StressTestExt("w2mesh");
        }

        [TestMethod]
        public void w2mg()
        {
            StressTestExt("w2mg");
        }

        [TestMethod]
        public void w2mi()
        {
            StressTestExt("w2mi");
        }

        [TestMethod]
        public void w2p()
        {
            StressTestExt("w2p");
        }

        [TestMethod]
        public void w2phase()
        {
            StressTestExt("w2phase");
        }

        [TestMethod]
        public void w2qm()
        {
            StressTestExt("w2qm");
        }

        [TestMethod]
        public void w2quest()
        {
            StressTestExt("w2quest");
        }

        [TestMethod]
        public void w2ragdoll()
        {
            StressTestExt("w2ragdoll");
        }

        [TestMethod]
        public void w2rig()
        {
            StressTestExt("w2rig");
        }

        [TestMethod]
        public void w2scene()
        {
            StressTestExt("w2scene");
        }

        [TestMethod]
        public void w2sf()
        {
            StressTestExt("w2sf");
        }

        [TestMethod]
        public void w2steer()
        {
            StressTestExt("w2steer");
        }

        [TestMethod]
        public void w2ter()
        {
            StressTestExt("w2ter");
        }

        [TestMethod]
        public void w2w()
        {
            StressTestExt("w2w");
        }

        [TestMethod]
        public void w3app()
        {
            StressTestExt("w3app");
        }

        [TestMethod]
        public void w3dyng()
        {
            StressTestExt("w3dyng");
        }

        [TestMethod]
        public void w3fac()
        {
            StressTestExt("w3fac");
        }

        [TestMethod]
        public void w3occlusion()
        {
            StressTestExt("w3occlusion");
        }

        [TestMethod]
        public void w3simplex()
        {
            StressTestExt("w3simplex");
        }

        [TestMethod]
        public void xbm()
        {
            StressTestExt("xbm");
        }



        //Not Cr2w files
        /*
        [TestMethod]
        public void buffer()
        {
            StressTestExt("buffer");
        }
        [TestMethod]
        public void navconfig()
        {
            StressTestExt("navconfig");
        }

        [TestMethod]
        public void navgraph()
        {
            StressTestExt("navgraph");
        }

        [TestMethod]
        public void naviobstacles()
        {
            StressTestExt("naviobstacles");
        }

        [TestMethod]
        public void navmesh()
        {
            StressTestExt("navmesh");
        }

        [TestMethod]
        public void navtile()
        {
            StressTestExt("navtile");
        }
        */
        #endregion
        // Actually do the test
        public void StressTestExt(string ext)
        {
            long unknownbytes = 0;
            long totalbytes = 0;
            List<string> unknownclasses = new List<string>();
            long filecount = 0;
            Dictionary<string, Tuple<long, long>> chunkstate = new Dictionary<string, Tuple<long, long>>();
            List<string> unparsedfiles = new List<string>();

            var files = mc.FileList.Where(x => x.Name.EndsWith(ext)).ToList();
            filecount = files.Count();
            Parallel.ForEach(files, f =>
            {
                try
                {
                    var buff = new byte[f.Size];
                    using (var s = new MemoryStream())
                    {
                        f.Extract(s);
                        totalbytes += f.Size;
                        using (var ms = new MemoryStream(s.ToArray()))
                        {
                            using (var br = new BinaryReader(ms))
                            {
                                var crw = new CR2WFile(br);
                                unknownclasses.AddRange(crw.UnknownTypes);
                                foreach (var c in crw.chunks)
                                {
                                    if (!chunkstate.ContainsKey(c.Type))
                                    {
                                        chunkstate.Add(c.Type, new Tuple<long, long>(0, 0));
                                    }
                                    var already = chunkstate[c.Type];
                                    chunkstate[c.Type] = new Tuple<long, long>(
                                            already.Item1 + c.Export.dataSize,
                                            already.Item2 + c.unknownBytes.Bytes.Length
                                        );
                                    totalbytes += c.Export.dataSize;
                                    unknownbytes += c.unknownBytes.Bytes.Length;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    unparsedfiles.Add(f.Name);
                }
            });

            Console.WriteLine($"{ext} test completed...");
            Console.WriteLine("Results:");
            Console.WriteLine($"\t- Parsed {filecount} {ext} files");
            Console.WriteLine($"\t- Parsing percentage => {(((double)totalbytes - (double)unknownbytes) / (double)totalbytes).ToString("0.00%")}" +
                $" | Couldn't parse: {unparsedfiles.Count} files!");
            Console.WriteLine($"Classes: ");
            foreach (var c in chunkstate)
            {
                var percentage = (((double)c.Value.Item2 - (double)c.Value.Item1) / (double)c.Value.Item1);
                if (percentage != (double)-1)
                   Console.WriteLine($"\t- {c.Key} {percentage.ToString("0.000000%")}");
            }
            Console.WriteLine("Files unparsed:");
            foreach(var f in unparsedfiles)
            {
                Console.WriteLine($"\t-{f}");
            }
            Console.WriteLine("Types unparsed:");
            unknownclasses = unknownclasses.Distinct().ToList();
            foreach (var f in unknownclasses)
            {
                Console.WriteLine($"\t-{f}");
            }
            Assert.AreEqual(0, unknownbytes, $"Unknown bytes remained -> {unknownbytes}bytes");
            Assert.AreEqual(0, unparsedfiles.Count, $"Unparsed files -> {unparsedfiles}");
        }
    }
}
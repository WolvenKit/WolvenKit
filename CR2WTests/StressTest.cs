using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit;
using System.Linq;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.Bundles;

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
            mc.LoadAll("C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");
        }

        // Methods to test for the different file types

        [TestMethod]
        public void Journal()
        {
            StressTestExt("journal");
        }


        // Actually do the test
        public void StressTestExt(string ext)
        {
            long unknownbytes = 0;
            long totalbytes = 0;
            List<string> unknownclasses = new List<string>();
            long rigcount = 0;
            Dictionary<string, Tuple<long, long>> chunkstate = new Dictionary<string, Tuple<long, long>>();
            List<string> unparsedfiles = new List<string>();

            var files = mc.FileList.Where(x => x.Name.EndsWith(ext));
            rigcount = files.Count();
            foreach (var f in files)
            {
                try
                {
                    var buff = new byte[f.Size];
                    using (var s = new MemoryStream())
                    {
                        f.Extract(s);
                        totalbytes += f.Size;
                        using(var ms = new MemoryStream(s.ToArray()))
                        {
                            using (var br = new BinaryReader(ms))
                            {
                                var crw = new CR2WFile(br);
                                unknownclasses.AddRange(crw.UnknownTypes);
                                foreach (var c in crw.chunks)
                                {
                                    if (!chunkstate.ContainsKey(c.Name))
                                    {
                                        chunkstate.Add(c.Name, new Tuple<long, long>(0, 0));
                                    }
                                    var already = chunkstate[c.Name];
                                    chunkstate[c.Name] = new Tuple<long, long>(
                                            already.Item1 + c.size,
                                            already.Item2 + c.unknownBytes.Bytes.Length
                                        );
                                    totalbytes += c.size;
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
            }

            Console.WriteLine($"{ext} test completed...");
            Console.WriteLine("Results:");
            Console.WriteLine($"\t- Parsed {rigcount} {ext} files");
            Console.WriteLine($"\t- Parsing percentage => {(((double)totalbytes - (double)unknownbytes) / (double)totalbytes).ToString("0.00%")} | Couldn't parse: {unparsedfiles.Count}files!");
            Console.WriteLine($"Classes: ");
            foreach (var c in chunkstate)
            {
                Console.WriteLine($"\t- {c.Key} - {(((double)c.Value.Item2 - (double)c.Value.Item1) / (double)c.Value.Item1).ToString("0.00%")}");
            }
            Assert.AreEqual(0, unknownbytes);
        }
    }
}

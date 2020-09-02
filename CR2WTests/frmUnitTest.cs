using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit;
using System.IO.MemoryMappedFiles;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.Bundles;
using WolvenKit.Common;
using System.Diagnostics;
using System.Security.Cryptography;
using WolvenKit.Common.Extensions;
using System.Collections.Concurrent;
using System.Threading;

namespace CR2WTests
{
    public partial class frmUnitTest : Form
    {
        private Tuple<long, int> res;

        private string ext;
        private string bundletag;
        private BundleManager bm;

        public frmUnitTest(string _ext, string _bundletag, BundleManager _mc)
        {
            InitializeComponent();

            ext = _ext;
            bundletag = _bundletag;
            bm = _mc;

            Setup();

            Run();

            this.Text = ext;

        }

        private void UpdateRichTextBox1(string val)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                this.richTextBox1.BeginInvoke((MethodInvoker)delegate () { this.richTextBox1.AppendText(val);});
            }
            else
            {
                this.richTextBox1.AppendText(val);
            }
        }
        private void UpdateRichTextBox2(string val)
        {
            if (this.richTextBox2.InvokeRequired)
            {
                this.richTextBox2.BeginInvoke((MethodInvoker)delegate () { this.richTextBox2.AppendText(val); });
            }
            else
            {
                this.richTextBox2.AppendText(val);
            }
        }
        private void UpdateProgress()
        {
            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.BeginInvoke((MethodInvoker)delegate () { this.progressBar1.PerformStep(); });
            }
            else
            {
                this.progressBar1.PerformStep();
            }
        }
        private void UpdateMaxProgress(int val)
        {
            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.BeginInvoke((MethodInvoker)delegate () { this.progressBar1.Maximum = val; });
            }
            else
            {
                this.progressBar1.Maximum = val;
            }
        }

        private void Setup()
        {
            progressBar1.Minimum = 1;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
        }

        public async Task<Tuple<long, int>> Run()
        {
            await Task.Run(() => StressTestExtAsync()).ContinueWith(
                antecedent =>
                {
                    res = antecedent.Result;
                    Thread.Sleep(10000);
                    try
                    {
                        this.Close();
                    }
                    catch
                    {

                    }
                    return antecedent.Result;

                }
                );
            return null;
        }

        public async Task<Tuple<long, int>> StressTestExtAsync()
        {
            long unknownbytes = 0;
            long totalbytes = 0;
            ConcurrentDictionary<string, string> unknownclasses = new ConcurrentDictionary<string, string>();
            long filecount = 0;
            //This one is trickier, concurrentdict would be of no use since we need += on tuple items, so we will lock.
            Dictionary<string, Tuple<long, long>> chunkstate = new Dictionary<string, Tuple<long, long>>();
            ConcurrentBag<string> unparsedfiles = new ConcurrentBag<string>();
            var processedfiles = new ConcurrentBag<string>();

            List<IWitcherFile> files = bm.Items
                .SelectMany(_ => _.Value)
                .Where(x => x.Name.EndsWith(ext))
                .ToList();

            filecount = files.Count;

            // Set Maximum to the total number of files to copy.
            UpdateMaxProgress(files.Count);

            Parallel.For (0, files.Count, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i =>
            {
                IWitcherFile f = (IWitcherFile)files[i];

                if (f is BundleItem bi /*&& bi.Name.StartsWith("quests\\minor_quests\\skellige\\mq20")*/)
                {
                    //log
                    UpdateRichTextBox1($"{i + 1}/{files.Count}: {f.Name}\r\n");
                    UpdateProgress();
                    try
                    {
                        var fileresult = StressTestFile(bi, ref unknownclasses, ref totalbytes, ref unknownbytes, ref chunkstate);
                        processedfiles.Add(f.Name);
                    }
                    catch (Exception ex)
                    {
                        unparsedfiles.Add(f.Name);
                        //throw ex;
                        Console.WriteLine($"{f.Name}:{ex.Message}");
                        UpdateRichTextBox2($"{f.Name}:{ex.Message}\r\n");
                    }
                }
            });

            Console.WriteLine($"{ext} test completed...");
            Console.WriteLine("Results:");
            Console.WriteLine($"\t- Parsed {filecount} {ext} files");
            Console.WriteLine($"\t- Parsing percentage => {((double)totalbytes - (double)unknownbytes) / (double)totalbytes:0.00%}" +
                $" | Couldn't parse: {unparsedfiles.Count} files!");
            Console.WriteLine($"Classes: ");
            UpdateRichTextBox2($"{ext} test completed...\r\n");
            UpdateRichTextBox2("Results:\r\n");
            UpdateRichTextBox2($"\t- Parsed {filecount} {ext} files\r\n");
            UpdateRichTextBox2($"\t- Parsing percentage => {((double)totalbytes - (double)unknownbytes) / (double)totalbytes:0.00%}\r\n" +
                $" | Couldn't parse: {unparsedfiles.Count} files!\r\n");
            UpdateRichTextBox2($"Classes: \r\n");

            foreach (var c in chunkstate)
            {
                var percentage = (((double)c.Value.Item1 - (double)c.Value.Item2) / (double)c.Value.Item1);
                if (percentage != (double)1)
                {
                    Console.WriteLine($"\t- {c.Key} {percentage:0.00%}");
                    UpdateRichTextBox2($"\t- {c.Key} {percentage:0.00%}\r\n");
                }
            }

            Console.WriteLine("Files errored during parsing:");
            UpdateRichTextBox2("Files errored during parsing:\r\n");
            foreach (var f in unparsedfiles)
            {
                Console.WriteLine($"\t-{f}");
                UpdateRichTextBox2($"\t-{f}\r\n");
            }

            Console.WriteLine("Types unparsed:");
            UpdateRichTextBox2("Types unparsed:\r\n");
            foreach (var f in unknownclasses)
            {
                Console.WriteLine($"\t-{f}");
                UpdateRichTextBox2($"\t-{f}\r\n");
            }

            return new Tuple<long, int>(unknownbytes, unparsedfiles.Count);
        }

        private static int StressTestFile(BundleItem f, ref ConcurrentDictionary<string, string> unknownclasses, ref long totalbytes, ref long unknownbytes, ref Dictionary<string, Tuple<long, long>> chunkstate)
        {
            var crw = new CR2WFile();

            using (var ms = new MemoryStream())
            using (var br = new BinaryReader(ms))
            {
                f.ExtractExistingMMF(ms);
                ms.Seek(0, SeekOrigin.Begin);

                #region Reading Test A
                // reading test
                crw.Read(br);
                #endregion

                #region StringTableTest A.1
                // additional tests
                (var dict, var strings, var nameslist, var importslist) = crw.GenerateStringtable();
                var newdictvalues = dict.Values.ToList();
                var dictvalues = crw.StringDictionary.Values.ToList();
                var diffDictList = dictvalues.Except(newdictvalues).ToList();
                if (diffDictList.Count != 0)
                {
                    //w2anims inconsistencies
                    bool isclassicalinconsistentw2anims=true;
                    foreach (string str in diffDictList)
                    {
                        if (str == "extAnimEvents" ||
                            str == "array:2,0,handle:CExtAnimEventsFile" ||
                            str == "CExtAnimEventsFile" ||
                            str.Contains("sounds\\") ||
                            str.Contains("sound\\"))
                        {
                            continue;
                        }
                        else
                        {
                            isclassicalinconsistentw2anims = false;
                            break;
                        }
                    }
                    //w2ent detlaff inconsistencies
                    bool isclassicalinconsistentw2ent = true;
                    foreach (string str in diffDictList)
                    {
                        if (str == "IF_Positive" ||
                            str == "IF_Negative" ||
                            str == "IF_Neutral" ||
                            str == "IF_Immobilize" ||
                            str == "IF_Confuse" ||
                            str == "IF_Damage")
                        {
                            continue;
                        }
                        else
                        {
                            isclassicalinconsistentw2ent = false;
                            break;
                        }
                    }
                    //w2phase inconsistencies
                    bool isclassicalinconsistentw2phase = true;
                    foreach (string str in diffDictList)
                    {
                        if (str == "@SItem" ||
                            str == "SItem" ||
                            str == "#CEnvironmentDefinition" ||
                            str == "CEnvironmentDefinition")
                        {
                            continue;
                        }
                        else
                        {
                            isclassicalinconsistentw2phase = false;
                            break;
                        }
                    }

                    if (isclassicalinconsistentw2anims)
                    {
                        //throw new InvalidBundleException("Classical inconsistent .w2anims - " +
                        //    ".w2animev sound handles left behind in string lists, but actual data is empty");
                    }
                    else if (isclassicalinconsistentw2ent)
                    {
                        //throw new InvalidBundleException("Inconsistent .w2ent - " +
                        //    "some Detlaff stuff");
                    }
                    else if (isclassicalinconsistentw2phase)
                    {
                        //throw new InvalidBundleException("Inconsistent .w2phase - " +
                        //    "secret e3 files");
                    }
                    else
                    {
                        throw new InvalidBundleException(" Generated dictionary not equal actual dictionary.");
                    }
                }
                #endregion

                #region Writing Test B
                byte[] buffer_testB;
                byte[] buffer_testB_original;

                using (var ms_testB = new MemoryStream())
                using (var bw_testB = new BinaryWriter(ms_testB))
                {
                    crw.Write(bw_testB);
                    buffer_testB = ms_testB.ToArray();
                }

                // compare
                ms.Seek(0, SeekOrigin.Begin);
                buffer_testB_original = ms.ToArray();

                if (!Enumerable.SequenceEqual(buffer_testB_original, buffer_testB))
                {
                    throw new InvalidBundleException(" Generated cr2w file not equal to original file.");
                }

                #endregion

            }
            foreach (var ut in crw.UnknownTypes)
            {
                unknownclasses.TryAdd(ut,ut);
            }
            foreach (var c in crw.chunks)
            {
                var ubsl = c.unknownBytes?.Bytes != null ? c.unknownBytes.Bytes.Length : 0;

                lock (chunkstate)
                {
                    if (!chunkstate.ContainsKey(c.REDType))
                    {
                        chunkstate.Add(c.REDType, new Tuple<long, long>(0, 0));
                    }
                    var already = chunkstate[c.REDType];
                    chunkstate[c.REDType] = new Tuple<long, long>(
                            already.Item1 + c.Export.dataSize,
                            already.Item2 + ubsl
                        );
                }

                Interlocked.Add(ref totalbytes, c.Export.dataSize);
                Interlocked.Add(ref unknownbytes, ubsl);
            }
            return 0;
        }

        internal Tuple<long, int> GetResult()
        {

            return res;
        }
    }
}

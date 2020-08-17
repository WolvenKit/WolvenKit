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

namespace CR2WTests
{
    public partial class frmUnitTest : Form
    {
        private Tuple<long, int> res;

        private string ext;
        private string bundletag;
        private BundleManager mc;

        public frmUnitTest(string _ext, string _bundletag, BundleManager _mc)
        {
            InitializeComponent();

            ext = _ext;
            bundletag = _bundletag;
            mc = _mc;

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
                    return antecedent.Result;
                }
                );
            //StressTestExtAsync();

            //var r = StressTestExtAsync();
            //return r;

            return null;
        }

        public /*static async Task<*/Tuple<long, int> StressTestExtAsync()
        {
            long unknownbytes = 0;
            long totalbytes = 0;
            List<string> unknownclasses = new List<string>();
            long rigcount = 0;
            Dictionary<string, Tuple<long, long>> chunkstate = new Dictionary<string, Tuple<long, long>>();
            List<Dictionary<string, Tuple<long, long>>> chunkstateList = new List<Dictionary<string, Tuple<long, long>>>();
            List<string> unparsedfiles = new List<string>();


            //List<IWitcherFile> files = mc.FileList.Where(x => x.Name.EndsWith(ext)).ToList();
            var content = Path.Combine("C:\\w3mod\\The Witcher 3\\content\\");

            //var patchdirs = new List<string>();

            //if (bundletag == "sanscontent0")
            //{
            //    patchdirs = new List<string>(Directory.GetDirectories(content, bundletag)).Where(_ => !_.Contains("content0")).ToList();
            //}
            //else
            ////if (bundletag == "content0*" || bundletag == "patch1*")
            //{
            //    patchdirs = new List<string>(Directory.GetDirectories(content, bundletag));
            //}


            //patchdirs.Sort(new AlphanumComparator<string>());
            //foreach (var file in patchdirs.SelectMany(dir => Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories)))
            //{
            //    mc.LoadBundle(file, true);
            //}

            List<IWitcherFile> files = mc.Items
                .SelectMany(_ => _.Value)
                .Where(x => x.Name.EndsWith(ext))
                .ToList();

            var processedfiles = new List<string>();
            rigcount = files.Count;

            //var tasks = new List<Task>();

            // Set Maximum to the total number of files to copy.
            UpdateMaxProgress(files.Count);

            for (int i = 0; i < files.Count; i++)
            {
                IWitcherFile f = (IWitcherFile)files[i];
                //log
                //richTextBox1.AppendText($"{i + 1}/{files.Count}: {f.Name}\r\n");
                UpdateRichTextBox1($"{i + 1}/{files.Count}: {f.Name}\r\n");
                //progressBar1.PerformStep();
                UpdateProgress();
                //this.Text = $"{ext} - {i + 1}/{files.Count}\r\n\r\n";

                if (f is BundleItem bi)
                {
                    totalbytes += f.Size;

                    try
                    {
                        Tuple<long, long, Dictionary<string, Tuple<long, long>>> result = StressTestFile(bi, unknownclasses);
                        totalbytes += result.Item1;
                        unknownbytes += result.Item2;
                        chunkstateList.Add(result.Item3);
                        processedfiles.Add(f.Name);
                    }
                    catch (Exception ex)
                    {
                        unparsedfiles.Add(f.Name);
                        //throw ex;

                        UpdateRichTextBox2($"{f.Name}:{ex.Message}\r\n");
                    }



                    //tasks.Add(Task.Run(async () => await StressTestFileAsync(bi, unknownclasses))
                    //    .ContinueWith(t =>
                    //    {
                    //        if (t.IsCompleted)
                    //        {
                    //            try
                    //            {
                    //                totalbytes += t.Result.Item1;
                    //                unknownbytes += t.Result.Item2;
                    //                chunkstateList.Add(t.Result.Item3);
                    //                processedfiles.Add(f.Name);
                    //            }
                    //            catch (Exception ex)
                    //            {
                    //                unparsedfiles.Add(f.Name);
                    //                //throw;
                    //            }
                    //        }
                    //        else
                    //        {
                    //            unparsedfiles.Add(f.Name);
                    //        }
                    //    //Debug.WriteLine($"{t.Id} Status: {t.Status}, {chunkstateList.Count} / {tasks.Count} tests completed.");
                    //}
                    //));
                }
            }

            //Task.WaitAll(tasks.ToArray());


            var leftoutfiles = new List<string>();
            if (chunkstateList.Count != files.Count)
            {
                foreach (var file in files.Select(_ => _.Name))
                {
                    if (!processedfiles.Contains(file))
                    {
                        leftoutfiles.Add(file);
                    }
                }
            }

            // concat dictionaries
            foreach (var dict in chunkstateList)
            {
                if (dict == null)
                    continue;
                foreach (string key in dict.Keys)
                {
                    var val = dict[key];

                    if (!chunkstate.ContainsKey(key))
                    {
                        chunkstate.Add(key, new Tuple<long, long>(0, 0));
                    }
                    var already = chunkstate[key];
                    chunkstate[key] = new Tuple<long, long>(
                            already.Item1 + val.Item1,
                            already.Item2 + val.Item2
                        );
                }
            }

            //richTextBox2.Clear();

            Console.WriteLine($"{ext} test completed...");
            Console.WriteLine("Results:");
            Console.WriteLine($"\t- Parsed {rigcount} {ext} files");
            Console.WriteLine($"\t- Parsing percentage => {((double)totalbytes - (double)unknownbytes) / (double)totalbytes:0.00%}" +
                $" | Couldn't parse: {unparsedfiles.Count} files!");
            Console.WriteLine($"Classes: ");
            UpdateRichTextBox2($"{ext} test completed...\r\n");
            UpdateRichTextBox2("Results:\r\n");
            UpdateRichTextBox2($"\t- Parsed {rigcount} {ext} files\r\n");
            UpdateRichTextBox2($"\t- Parsing percentage => {((double)totalbytes - (double)unknownbytes) / (double)totalbytes:0.00%}\r\n" +
                $" | Couldn't parse: {unparsedfiles.Count} files!\r\n");
            UpdateRichTextBox2($"Classes: \r\n");

            foreach (var c in chunkstate)
            {
                var percentage = (((double)c.Value.Item2 - (double)c.Value.Item1) / (double)c.Value.Item1);
                if (percentage != (double)-1)
                {
                    Console.WriteLine($"\t- {c.Key} {percentage:0.000000%}");
                    UpdateRichTextBox2($"\t- {c.Key} {percentage:0.000000%}\r\n");
                }
            }

            Console.WriteLine("Files unparsed:");
            UpdateRichTextBox2("Files unparsed:\r\n");
            foreach (var f in unparsedfiles)
            {
                Console.WriteLine($"\t-{f}");
                UpdateRichTextBox2($"\t-{f}\r\n");
            }

            Console.WriteLine("Files left out:");
            UpdateRichTextBox2("Files left out:\r\n");
            foreach (var f in leftoutfiles)
            {
                Console.WriteLine($"\t-{f}");
                UpdateRichTextBox2($"\t-{f}\r\n");
            }

            Console.WriteLine("Types unparsed:");
            UpdateRichTextBox2("Types unparsed:\r\n");
            unknownclasses = unknownclasses.Distinct().ToList();
            foreach (var f in unknownclasses)
            {
                Console.WriteLine($"\t-{f}");
                UpdateRichTextBox2($"\t-{f}\r\n");
            }

            return new Tuple<long, int>(unknownbytes, unparsedfiles.Count);
        }

        private static Tuple<long, long, Dictionary<string, Tuple<long, long>>> StressTestFile(BundleItem f, List<string> unknownclasses)
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


                // reading test
                crw.Read(br);

                // additional tests
                (var dict, var strings, var nameslist, var importslist) = crw.GenerateStringtable();
                var newdictvalues = dict.Values.ToList();
                var dictvalues = crw.StringDictionary.Values.ToList();
                if (!newdictvalues.SequenceEqual(dictvalues))
                {
                    throw new InvalidBundleException("Generated dictionary not equal actual dictionary.");
                }

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

        }

        internal Tuple<long, int> GetResult()
        {


            return res;
        }
    }
}

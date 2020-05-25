using Microsoft.JScript;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using VGMToolbox.format.hoot;
using VisualPlus.Extensibility;
using Vlc.DotNet.Core.Interops.Signatures;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Editors;
using static WolvenKit.frmChunkProperties;

namespace WolvenKit.Forms
{

    public partial class frmCR2WtoText : Form
    {
        private List<string> Files = new List<string>();

        private CancellationTokenSource Cancel;

        private bool _outputSingleFile = false;
        private bool OutputSingleFile
        {
            get => _outputSingleFile;
            set
            {
                _outputSingleFile = value;
                txtOutputDestination.Clear();
            }
        }
        private bool existingOverwrite = true;

        private bool _running = false;

        public frmCR2WtoText()
        {
            InitializeComponent();
            SetDefaults();
        }
        private void SetDefaults()
        {
            radExistingOverwrite.Checked = existingOverwrite;
            radExistingSkip.Checked = !existingOverwrite;
            radOutputModeSingleFile.Checked = OutputSingleFile;
            radOutputModeSeparateFiles.Checked = !OutputSingleFile;
            chkDumpSDB.Checked = true;
            chkDumpFCD.Checked = false;
            chkDumpEmbedded.Checked = true;
            numThreads.Value = Environment.ProcessorCount;
            numThreads.Maximum = Environment.ProcessorCount;
            SetStatus(0, 0, 0, 0);
        }
        // Thread safe methods to update the processed counts while dumping async.
        private void SetStatusStatic(int count, int total, int nonCr2W, int exceptions)
        {
            Invoke(new SetStatusDelegate(SetStatus), count, total, nonCr2W, exceptions);
        }
        private void SetStatus(int count, int processed, int nonCR2W, int exceptions)
        {
            // TODO: Why can't I assign this all at once with an int[]? 
            // When I try, the row shows 'System.Int32[]' in the first cell and nothing else.
            // A string[] works, but not an int[] for some reason.
            int[] row = { count, processed, nonCR2W, exceptions };
            if (dataStatus.Rows.Count == 0)
                dataStatus.Rows.Add(count, processed, nonCR2W, exceptions);
            else
                dataStatus.Rows[0].SetValues(count, processed, nonCR2W, exceptions);
            /*
            dataStatus.Rows[0].Cells[0].Value = count;
            dataStatus.Rows[0].Cells[1].Value = processed;
            dataStatus.Rows[0].Cells[2].Value = nonCR2W;
            dataStatus.Rows[0].Cells[3].Value = exceptions;*/

            if (processed > 0)
                UpdateProgressBarStatic(processed);
        }
        private delegate void UpdateProgressBarDelegate(int processed);
        private void UpdateProgressBarStatic(int processed)
        {
            Invoke(new UpdateProgressBarDelegate(UpdateProgressBar), processed);
        }
        private void UpdateProgressBar(int processed)
        {
            prgProgressBar.PerformStep();
        }
        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Choose path containing unbundled CR2W files."
            };
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtPath.Text = dlg.FileName;
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                StartRun();
            }
            else
            {
                btnRun.Text = "Stopping...";
                _running = false;
                Cancel.Cancel();
            }
        }
        private void ControlsEnabledDuringRun(bool b)
        {
            // During run, all controls are disabled, and the run button changes to abort
            pnlControls.Enabled = b;
            btnRun.Text = b ? "Run CR2W Dump" : "Abort";
        }
        private async void StartRun()
        {
            ControlsEnabledDuringRun(false);
            prgProgressBar.Value = 0;
            prgProgressBar.Visible = true;
            _running = true;

            await Task.Run(DoRun);

            _running = false;
            prgProgressBar.Visible = false;
            ControlsEnabledDuringRun(true);
        }
        private async Task DoRun()
        {
            SetStatusStatic(Files.Count(), 0, 0, 0);

            if (Files.Any())
            {
                string sourcePath = txtPath.Text;
                string outputLocation = txtOutputDestination.Text;

                var cr2wOptions = new LoggerCR2WOptions
                {
                    StartingIndentLevel = 1,
                    ListEmbedded = chkDumpEmbedded.Checked,
                    DumpFCD = chkDumpFCD.Checked,
                    DumpSDB = chkDumpSDB.Checked,
                };

                Cancel = new CancellationTokenSource();

                var loggerOptions = new LoggerWriterOptions
                {
                    CancelToken = Cancel.Token,
                    SetStatusDel = SetStatus,
                    OutputSingleFile = this.OutputSingleFile,
                    NumThreads = (int) numThreads.Value,
                    SourcePath = sourcePath,
                    OutputLocation = outputLocation,
                    CreateFolders = chkCreateFolders.Checked,
                    PrefixFileName = chkPrefixFileName.Checked,
                    OverwriteFiles = radExistingOverwrite.Checked
                };

                LoggerWriter writer;

                if (OutputSingleFile)
                    writer = new LoggerWriterSingle(Files, loggerOptions, cr2wOptions);
                else
                    writer = new LoggerWriterSeparate(Files, loggerOptions, cr2wOptions);

                await writer.StartDump();

                Cancel.Dispose();
            }
        }

        private void CheckEnableRunButton()
        {
            btnRun.Enabled = txtPath.Text != "" && txtOutputDestination.Text != "" && Files.Any();
        }
        private async Task UpdateSourceFolder(string path)
        {
            string[] extExclude = new[] { ".txt", ".json", ".csv", ".xml", ".jpg", ".png", ".buffer", ".navgraph", ".navtile",
                                          ".usm", ".wem", ".dds", ".bnk", ".xbm", ".bundle", ".w3strings", ".store", ".navconfig",
                                          ".srt", ".naviobstacles", ".navmesh"};

            Files.Clear();
            if (Directory.Exists(path))
            {
                btnRun.Enabled = false;
                pnlControls.Enabled = false;
                await Task.Run(() =>
                {
                    int fileCounter = 1;
                    foreach (var file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                                                  .Where(file => !extExclude.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))))
                    {
                        Files.Add(file);
                        if (fileCounter++ % 100 == 0) // Only update status for every 100 files
                            SetStatusStatic(fileCounter, 0, 0, 0);
                    }
                });

                int count = Files.Count();
                SetStatusStatic(count, 0, 0, 0);
                ResetProgressBar(count);

                pnlControls.Enabled = true;
                CheckEnableRunButton();
            }
            else
            {
                Files.Clear();
                SetStatusStatic(0, 0, 0, 0);
            }

        }
        private void ResetProgressBar(int count)
        {
            prgProgressBar.Maximum = count;
            prgProgressBar.Step = 1;
        }
        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            UpdateSourceFolder(txtPath.Text);
        }
        private void txtOutputDestination_TextChanged(object sender, EventArgs e)
        {
            CheckEnableRunButton();
        }
        private void btnPickOutput_Click(object sender, EventArgs e)
        {
            if (OutputSingleFile)
            {
                SaveFileDialog fileDlg = new SaveFileDialog
                {
                    Title = "Enter the filename to output to",
                    Filter = "txt | *.txt"
                };
                if (fileDlg.ShowDialog() == DialogResult.OK)
                    txtOutputDestination.Text = fileDlg.FileName;
            }
            else
            {
                CommonOpenFileDialog folderDlg = new CommonOpenFileDialog
                {
                    Title = "Select folder to write text dumps to",
                    IsFolderPicker = true,
                    EnsurePathExists = false,
                    EnsureFileExists = false,
                    EnsureValidNames = true

                };

                if (folderDlg.ShowDialog() == CommonFileDialogResult.Ok)
                    txtOutputDestination.Text = folderDlg.FileName;
            }
        }
        private void RadioOutputModeChanged(object sender, EventArgs e)
        {
            OutputSingleFile = radOutputModeSingleFile.Checked;
            // In Separate Files mode, enable controls for:
            //   Creating intermediate folders; choosing file overwrite/skip; multi-threaded operation
            chkCreateFolders.Enabled = radOutputModeSeparateFiles.Checked;
            grpExistingFiles.Enabled = radOutputModeSeparateFiles.Checked;
            numThreads.Enabled = radOutputModeSeparateFiles.Checked;
        }
    }

    internal class LoggerWriterSeparate : LoggerWriter
    {
        internal LoggerWriterSeparate(List<string> files, LoggerWriterOptions writerOptions, LoggerCR2WOptions cr2wOptions)
            : base(files, writerOptions, cr2wOptions)
        {
        }
        public override async Task StartDump()
        {
            var parOptions = new ParallelOptions()
            {
                MaxDegreeOfParallelism = WriterOptions.NumThreads,
                CancellationToken = WriterOptions.CancelToken
            };

            if (!Directory.Exists(WriterOptions.OutputLocation))
                Directory.CreateDirectory(WriterOptions.OutputLocation);

            int fileCount = 0, nonCR2WCount = 0, exceptionCount = 0;
            try
            {
                Parallel.ForEach(Files, parOptions, async fileName =>
                {
                    string outputDestination;
                    string fileBaseName = Path.GetFileName(fileName);

                    if (WriterOptions.CreateFolders)
                    {
                        // Recreate the file structure of the source folder in the destination folder.
                        // Strip the sourcepath from the start of the filename, then create the remaining folders
                        fileName.ReplaceFirst(WriterOptions.SourcePath, "", out var replacedSourcePath);
                        var i = replacedSourcePath.LastIndexOf(fileBaseName, StringComparison.Ordinal);
                        outputDestination = WriterOptions.OutputLocation + replacedSourcePath.Substring(0, i);

                        Directory.CreateDirectory(outputDestination);
                    }
                    else
                        outputDestination = WriterOptions.OutputLocation;

                    outputDestination = outputDestination + "\\" + fileBaseName + ".txt";

                    bool skip = false;
                    if (File.Exists(outputDestination))
                        if (WriterOptions.OverwriteFiles)
                            File.Delete(outputDestination);
                        else
                            skip = true;

                    if (!skip)
                        using (StreamWriter streamDestination = new StreamWriter(outputDestination, false))
                        {
                            var dumpResult = await Dump(streamDestination, fileName);
                            nonCR2WCount += dumpResult.nonCR2W ? 1 : 0;
                            exceptionCount += dumpResult.exceptions ? 1 : 0;
                        }

                    SetStatusStatic(Files.Count(), ++fileCount, nonCR2WCount, exceptionCount);
                });
            }
            catch (OperationCanceledException)
            {
                //TODO: Do we need to do anything here?
            }
        }
    }
    internal class LoggerWriterSingle : LoggerWriter
    {
        internal LoggerWriterSingle(List<string> files, LoggerWriterOptions writerOptions, LoggerCR2WOptions cr2wOptions)
            : base(files, writerOptions, cr2wOptions)
        {
        }
        public override async Task StartDump()
        {
            string outputDestination = WriterOptions.OutputLocation;
            if (File.Exists(outputDestination))
                File.Delete(outputDestination);

            int fileCount = 0, nonCR2WCount = 0, exceptionCount = 0;
            using (StreamWriter streamDestination = new StreamWriter(outputDestination, false))
                foreach (var fileName in Files)
                {
                    if (WriterOptions.CancelToken.IsCancellationRequested)
                        break;
                    var dumpResult = await Dump(streamDestination, fileName);
                    nonCR2WCount += dumpResult.nonCR2W ? 1 : 0;
                    exceptionCount += dumpResult.exceptions ? 1 : 0;
                    SetStatusStatic(Files.Count(), ++fileCount, nonCR2WCount, exceptionCount);
                }
        }
    }

    internal abstract class LoggerWriter
    {
        protected LoggerCR2WOptions CR2WOptions;
        protected List<string> Files { get; }
        protected LoggerWriterOptions WriterOptions { get; set; }
        internal LoggerWriter(List<string> files, LoggerWriterOptions writerOptions, LoggerCR2WOptions cr2wOptions)
        {
            Files = files;
            WriterOptions = writerOptions;
            CR2WOptions = cr2wOptions;
        }

        public abstract Task StartDump();
        protected void SetStatusStatic(int count, int total, int nonCr2W, int exceptions)
        {
            WriterOptions.SetStatusDel(count, total, nonCr2W, exceptions);
        }

        protected async Task<(bool nonCR2W, bool exceptions)> Dump(StreamWriter streamDestination, string fileName)
        {
            LoggerOutputFile outputFile = new LoggerOutputFile(streamDestination, WriterOptions.PrefixFileName,
                Path.GetFileName(fileName));
            bool gotExceptions = false;
            bool nonCR2W = false;
            try
            {
                var cf = new LoggerCR2W(fileName, outputFile, CR2WOptions);
                outputFile.WriteLine("FILE: " + fileName);
                cf.processCR2W();
                if (cf.ExceptionCount > 0)
                    gotExceptions = true;
            }
            catch (FormatException fe)
            {
                string msg = fileName + ": Not a valid CR2W file, or file is damaged.";
                Console.WriteLine(msg);
                nonCR2W = true;
            }
            catch (Exception ex)
            {
                string msg = fileName + ": Exception: " + ex.ToString();
                outputFile.WriteLine(msg);
                Console.WriteLine(msg);
                gotExceptions = true;
            }

            return (nonCR2W, gotExceptions);
        }
    }

    internal class LoggerOutputFile
    {
        private string Prefix { get; }
        private bool PrefixLine { get; }
        private StreamWriter OutputFile { get; }
        internal LoggerOutputFile(StreamWriter streamDestination, bool prefixLine, string prefix)
        {
            OutputFile = streamDestination;
            PrefixLine = prefixLine;
            Prefix = prefix;
        }
        public void WriteLine(string line)
        {
            OutputFile.WriteLine(line);
        }
        public virtual bool DumpText(string text, int level = 0)
        {
            string line;
            string indent = "";

            for (int i = 0; i < level; i++)
                indent += "    ";

            if (PrefixLine)
                line = Prefix + ":" + indent + text + "\r\n";
            else
                line = indent + text + "\r\n";

            OutputFile.Write(line);

            return true;
        }
    }

    internal delegate void SetStatusDelegate(int count, int total, int nonCR2W, int exceptions);

    internal struct LoggerWriterOptions
    {
        public CancellationToken CancelToken { get; set; }
        public SetStatusDelegate SetStatusDel { get; set; }
        public List<string> Files { get; set; }
        public bool OutputSingleFile { get; set; }
        public int NumThreads { get; set; }
        public string SourcePath { get; set; }
        public string OutputLocation { get; set; }
        public bool CreateFolders { get; set; }
        public bool PrefixFileName { get; set; }
        public bool OverwriteFiles { get; set; }
    }
    internal struct LoggerCR2WOptions
    {
        public int StartingIndentLevel { get; set; }
        public bool ListEmbedded { get; set; }
        public bool DumpSDB { get; set; }
        public bool DumpFCD { get; set; }
    }
    internal class LoggerCR2W
    {
        public int ExceptionCount = 0;

        private CR2WFile CR2W { get; }
        private LoggerOutputFile Writer { get; }
        private LoggerCR2WOptions Options { get; }
        private List<CR2WExportWrapper> Chunks { get; }
        private List<CR2WEmbeddedWrapper> Embedded { get; }

        private static CR2WFile loadCR2W(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                    return new CR2WFile(reader);
        }
        internal LoggerCR2W(string fileName, LoggerOutputFile writer, LoggerCR2WOptions options) : this(LoggerCR2W.loadCR2W(fileName), writer, options)
        {}
        internal LoggerCR2W(CR2WFile cr2wFile, LoggerOutputFile writer, LoggerCR2WOptions options)
        {
            CR2W = cr2wFile;
            Chunks = CR2W.chunks;
            Embedded = CR2W.embedded;
            Writer = writer;
            Options = options;
        }
        public void processCR2W(int overrideLevel = 0)
        {
            int level = (overrideLevel > 0) ? overrideLevel : Options.StartingIndentLevel;
            if (Options.ListEmbedded && Embedded != null && Embedded.Any())
            {
                Writer.DumpText("Embedded files:", level);
                ProcessEmbedded(level);
            }
            Writer.DumpText("Chunks:", level);
            foreach (var chunk in Chunks)
            {
                Writer.DumpText(chunk.Name + " (" + chunk.Type + ") : " + chunk.Preview, level);
                var node = GetNodes(chunk);
                ProcessNode(node, level + 1);
            }
        }
        private void ProcessEmbedded(int level)
        {
            //TODO: Also dump the embedded files? (optionally)
            int fileCounter = 1;
            foreach (CR2WEmbeddedWrapper embed in Embedded)
            {
                Writer.DumpText("(" + fileCounter++ + "):", level);
                Writer.DumpText("Index: " + embed.Embedded.importIndex, level + 1);
                Writer.DumpText("ImportPath: " + embed.ImportPath, level + 1);
                Writer.DumpText("ImportClass: " + embed.ImportClass, level + 1);
                Writer.DumpText("Size: " + embed.Embedded.dataSize, level + 1);
                Writer.DumpText("ClassName: " + embed.ClassName, level + 1);
                Writer.DumpText("Handle: " + embed.Handle, level + 1);
            }
        }
        private void ProcessNode(VariableListNode node, int level)
        {
            if (node.Name == "unknownBytes" && node.Value == "0 bytes"
                || node.Name == "unk1" && node.Value == "0")
                return;

            if (node.Name == "Parent" && node.Value == "NULL")
                return;

            if (node.Name != node.Value) // Chunk node is already printed in processCR2W, so don't print it again.
            {
                Writer.DumpText(node.Name + " (" + node.Type + ") : " + node.Value, level);
                level++;
            }

            if (node.ChildCount > 0)
                foreach (var child in node.Children)
                    ProcessNode(child, level);

            if (   (node.Type == "SharedDataBuffer" && Options.DumpSDB) 
                || (node.Type == "array:2,0,Uint8" && node.Name != "deltaTimes") ) 
            {   // Embedded CR2W dump:
                // Dump SharedDataBuffer if option is set.
                // Dump "array:2,0,Uint8", unless it's called "deltaTimes" (not CR2W)
                // And dump FCD only if options.dumpFCD is set.
                if (node.Name != "flatCompiledData" || Options.DumpFCD)
                {
                    try
                    {
                        CR2WFile embedcr2w = new CR2WFile(((IByteSource)node.Variable).Bytes);
                        var lc = new LoggerCR2W(embedcr2w, Writer, Options);
                        lc.processCR2W(level);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(node.Name + ": Buffer or 'array:2,0,Uint8' was not a CR2W file.");
                    }
                    catch (Exception e)
                    {
                        string msg = node.Name + " - " + node.Type + ": Buffer or 'array:2,0,Uint8' caught exception: " + e.ToString();
                        Writer.DumpText(msg, level);
                        Console.WriteLine(msg);
                        ExceptionCount++;
                    }
                }
            }
        }
        public VariableListNode GetNodes(CR2WExportWrapper chunk)
        {
            return AddListViewItems(chunk);
        }
        private VariableListNode AddListViewItems(IEditableVariable v, VariableListNode parent = null,
            int arrayindex = 0)
        {
            // This function is 100% copied from frmChunkProperties.cs !
            var node = new VariableListNode()
            {
                Variable = v,
                Children = new List<VariableListNode>(),
                Parent = parent
            };
            var vars = v.GetEditableVariables();
            if (vars != null)
            {
                for (var i = 0; i < vars.Count; i++)
                {
                    node.Children.Add(AddListViewItems(vars[i], node, i));
                }
            }

            return node;
        }
    }
}

using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using VisualPlus.Extensibility;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Editors;
using static WolvenKit.frmChunkProperties;
using DataGrid = System.Windows.Forms.DataGrid;

namespace WolvenKit.Forms
{
    public partial class frmCR2WtoText : Form
    {
        private StatusController statusController;
        private readonly List<string> Files = new List<string>();

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

        private bool _running = false;
        private bool _stopping = false;

        public frmCR2WtoText()
        {
            InitializeComponent();
            SetDefaults();
        }
        private void SetDefaults()
        {
            radExistingOverwrite.Checked = true;
            radExistingSkip.Checked = !radExistingOverwrite.Checked;
            radOutputModeSingleFile.Checked = OutputSingleFile;
            radOutputModeSeparateFiles.Checked = !OutputSingleFile;
            chkDumpSDB.Checked = true;
            chkDumpFCD.Checked = false;
            chkDumpEmbedded.Checked = true;
            numThreads.Value = Environment.ProcessorCount;
            numThreads.Maximum = Environment.ProcessorCount;
            statusController = new StatusController(dataStatus);
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
            else if (!_stopping)
            {
                btnRun.Text = "Stopping...";
                Cancel.Cancel();
                _stopping = true;
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

            prgProgressBar.Visible = false;
            ControlsEnabledDuringRun(true);
            _running = false;
            _stopping = false;
        }
        private async Task DoRun()
        {
            statusController.Processed = statusController.Skipped = statusController.NonCR2W = statusController.Exceptions = 0;
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

                var loggerOptions = new LoggerWriterData
                {
                    CancelToken = Cancel.Token,
                    Status = statusController,
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

                writer.EventOnProcessed += UpdateProgressBarStatic;
                await writer.PrepareDump();

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
                    int fileCounter = 0;
                    foreach (var file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                                                  .Where(file => !extExclude.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))))
                    {
                        Files.Add(file);
                        if (++fileCounter % 100 == 0) // Only update status for every 100 files
                            statusController.Count = fileCounter;
                    }
                });

                statusController.Count = Files.Count();
                ResetProgressBar(Files.Count());

                pnlControls.Enabled = true;
                CheckEnableRunButton();
            }
            else
            {
                Files.Clear();
                statusController.Count = 0;
            }

        }
        private void ResetProgressBar(int filesCount)
        {
            prgProgressBar.Maximum = filesCount;
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
        private void frmCR2WtoText_FormClosing(object sender, FormClosingEventArgs e)
        {   // Don't allow form to close if dump is running.
            e.Cancel = _running;
        }
    }

    internal class StatusController
    {
        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                UpdateCell(0, _count);
            }
        }
        private int _processed;
        public int Processed
        {
            get => _processed;
            set
            {
                _processed = value;
                UpdateCell(1, _processed);
            }
        }
        private int _skipped;
        public int Skipped
        {
            get => _skipped;
            set
            {
                _skipped = value;
                UpdateCell(2, _skipped);
            }
        }
        private int _nonCR2W;
        public int NonCR2W
        {
            get => _nonCR2W;
            set
            {
                _nonCR2W = value;
                UpdateCell(3, _nonCR2W);
;
            }
        }
        private int _exceptions;
        public int Exceptions
        {
            get => _exceptions;
            set
            {
                _exceptions = value;
                UpdateCell(4, _exceptions);
            }
        }
        private DataGridView Grid { get; }
        private void UpdateCell(int index, int value)
        {
            Grid.Rows[0].Cells[index].Value = value;
        }
        internal StatusController(DataGridView grid)
        {
            Grid = grid;
            object[] row = {0, 0, 0, 0, 0};
            if (Grid.Rows.Count == 0)
                Grid.Rows.Add(row);
            else
                Grid.Rows[0].SetValues(row);
        }
    }
    internal class LoggerWriterSeparate : LoggerWriter
    {
        internal LoggerWriterSeparate(List<string> files, LoggerWriterData writerData, LoggerCR2WOptions cr2wOptions)
            : base(files, writerData, cr2wOptions) { }
        public override async Task PrepareDump()
        {
            var parOptions = new ParallelOptions()
            {
                MaxDegreeOfParallelism = WriterData.NumThreads,
                CancellationToken = WriterData.CancelToken
            };

            if (!Directory.Exists(WriterData.OutputLocation))
                Directory.CreateDirectory(WriterData.OutputLocation);

            try
            {
                Parallel.ForEach(Files, parOptions, async fileName =>
                {
                    string outputDestination;
                    string fileBaseName = Path.GetFileName(fileName);

                    if (WriterData.CreateFolders)
                    {
                        // Recreate the file structure of the source folder in the destination folder.
                        // Strip the sourcepath from the start of the filename, then create the remaining folders
                        fileName.ReplaceFirst(WriterData.SourcePath, "", out var replacedSourcePath);
                        var i = replacedSourcePath.LastIndexOf(fileBaseName, StringComparison.Ordinal);
                        outputDestination = WriterData.OutputLocation + replacedSourcePath.Substring(0, i);

                        Directory.CreateDirectory(outputDestination);
                    }
                    else
                        outputDestination = WriterData.OutputLocation;

                    outputDestination = outputDestination + "\\" + fileBaseName + ".txt";

                    bool skip = false;
                    if (File.Exists(outputDestination))
                        if (WriterData.OverwriteFiles)
                            File.Delete(outputDestination);
                        else
                            skip = true;

                    if (!skip)
                    {
                        using (StreamWriter streamDestination = new StreamWriter(outputDestination, false))
                        {
                            var dumpResult = await Dump(streamDestination, fileName);
                            WriterData.Status.NonCR2W += dumpResult.nonCR2W ? 1 : 0;
                            WriterData.Status.Exceptions += dumpResult.exceptions ? 1 : 0;
                        }

                        EventOnProcessed(++WriterData.Status.Processed);
                    }
                    else
                        WriterData.Status.Skipped++;
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
        internal LoggerWriterSingle(List<string> files, LoggerWriterData writerData, LoggerCR2WOptions cr2wOptions)
            : base(files, writerData, cr2wOptions) { }
        public override async Task PrepareDump()
        {
            string outputDestination = WriterData.OutputLocation;
            if (File.Exists(outputDestination))
                File.Delete(outputDestination);

            using (StreamWriter streamDestination = new StreamWriter(outputDestination, false))
                foreach (var fileName in Files)
                {
                    if (WriterData.CancelToken.IsCancellationRequested)
                        break;
                    var dumpResult = await Dump(streamDestination, fileName);
                    WriterData.Status.NonCR2W += dumpResult.nonCR2W ? 1 : 0;
                    WriterData.Status.Exceptions += dumpResult.exceptions ? 1 : 0;
                    WriterData.Status.Processed++;
                }
        }
    }
    internal abstract class LoggerWriter
    {
        protected LoggerCR2WOptions CR2WOptions;
        protected List<string> Files { get; }
        protected LoggerWriterData WriterData { get; set; }
        internal LoggerWriter(List<string> files, LoggerWriterData writerData, LoggerCR2WOptions cr2wOptions)
        {
            Files = files;
            WriterData = writerData;
            CR2WOptions = cr2wOptions;
        }

        public abstract Task PrepareDump();

        public delegate void OnProcessedDelegate(int count);

        public OnProcessedDelegate EventOnProcessed;

        protected async Task<(bool nonCR2W, bool exceptions)> Dump(StreamWriter streamDestination, string fileName)
        {
            LoggerOutputFile outputFile = new LoggerOutputFile(streamDestination, WriterData.PrefixFileName,
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
                line = Prefix + ":" + indent + text;
            else
                line = indent + text;

            OutputFile.WriteLine(line);

            return true;
        }
    }

    internal struct LoggerWriterData
    {
        public CancellationToken CancelToken { get; set; }
        public StatusController Status { get; set; }
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
        private static CR2WFile LoadCR2W(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                    return new CR2WFile(reader);
        }
        internal LoggerCR2W(string fileName, LoggerOutputFile writer, LoggerCR2WOptions options)
            : this(LoggerCR2W.LoadCR2W(fileName), writer, options) {}
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
